using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Quizora
{
    public partial class ExamForm : Form
    {
        private IFirebaseClient client;
        private List<Question> questions = new List<Question>();
        private int currentIndex = 0;

        private string paperNo;
        private User currentUser;
        private int switchCount = 0;

        private bool isSubmitting = false;

        private int timeLeftInSeconds;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        public ExamForm(string paperNo, User user)
        {
            InitializeComponent();
            this.paperNo = paperNo;
            this.currentUser = user;

            DisableCheatingControls(lbl_questionText);
            DisableCheatingControls(rbtn_option1);
            DisableCheatingControls(rbtn_option2);
            DisableCheatingControls(rbtn_option3);
            DisableCheatingControls(rbtn_option4);

        }
        public ExamForm()
        {
            InitializeComponent();
        }
        private Dictionary<int, string> selectedAnswers = new Dictionary<int, string>();
        private bool submitButtonShown = false;


        private async void ExamForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //this.Deactivate += ExamForm_Deactivate;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true; // Keep on top

            KeyboardInterceptor.StartBlock(); // 🚫 Block system keys

            KillProcesses(new string[]
            {
                "chrome",        // Google Chrome
                "msedge",        // Microsoft Edge
                "firefox",       // Mozilla Firefox
                "opera",         // Opera
                "brave",         // Brave browser
                "chatgpt",       // ChatGPT desktop app (if exists)
                "notion",        // Example AI-related tool
                "bing",          // Copilot (might be embedded in Edge)
            });

            lbl_Papernum.Text = "Paper: " + paperNo;
            lbl_regNum.Text = "Reg No: " + currentUser.RegNo;

            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse res = await client.GetAsync("papers/" + paperNo + "/questions");
            var data = res.ResultAs<Dictionary<string, Question>>();

            questions = data.OrderBy(q => q.Key).Select(q => q.Value).ToList();
            lbl_totalQuestions.Text = questions.Count.ToString();
            DisplayQuestion();

            FirebaseResponse timeRes = await client.GetAsync("papers/" + paperNo + "/duration");
            if (timeRes.Body != "null")
            {
                int durationMinutes = timeRes.ResultAs<int>();
                timeLeftInSeconds = durationMinutes * 60;

                lbl_timer.Text = FormatTime(timeLeftInSeconds); // Show initial time
                examTimer.Start(); // Start ticking
            }
            else
            {
                timeLeftInSeconds = 0;
                lbl_timer.Text = "00:00";
            }

        }
        private void DisplayQuestion()
        {
                var q = questions[currentIndex];

                lbl_questionNum.Text = (currentIndex + 1).ToString();
                lbl_questionText.Text = q.QuestionText;

                rbtn_option1.Text = q.OptionA;
                rbtn_option2.Text = q.OptionB;
                rbtn_option3.Text = q.OptionC;
                rbtn_option4.Text = q.OptionD;

                // Reset previous selection
                rbtn_option1.Checked = false;
                rbtn_option2.Checked = false;
                rbtn_option3.Checked = false;
                rbtn_option4.Checked = false;

                // Show/hide buttons based on position
                btn_previous.Visible = currentIndex > 0;
                btn_next.Enabled = currentIndex < questions.Count - 1;

            // Restore previous selection
            if (selectedAnswers.ContainsKey(currentIndex))
            {
                string selected = selectedAnswers[currentIndex];
                rbtn_option1.Checked = selected == "Option 01";
                rbtn_option2.Checked = selected == "Option 02";
                rbtn_option3.Checked = selected == "Option 03";
                rbtn_option4.Checked = selected == "Option 04";
            }
            else
            {
                rbtn_option1.Checked = false;
                rbtn_option2.Checked = false;
                rbtn_option3.Checked = false;
                rbtn_option4.Checked = false;
            }

            // Show Submit button only at the end
            btn_submit.Visible = submitButtonShown || currentIndex == questions.Count - 1;

            if (currentIndex == questions.Count - 1)
                submitButtonShown = true;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            SaveAnswer(); // Save current answer

            if (currentIndex < questions.Count - 1)
            {
                currentIndex++;
                DisplayQuestion();
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayQuestion();
            }
        }
        private void SaveAnswer()
        {
            string selected = "";

            if (rbtn_option1.Checked) selected = "Option 01";
            if (rbtn_option2.Checked) selected = "Option 02";
            if (rbtn_option3.Checked) selected = "Option 03";
            if (rbtn_option4.Checked) selected = "Option 04";

            selectedAnswers[currentIndex] = selected;

        }

        private async void btn_submit_Click(object sender, EventArgs e)
        {
            KeyboardInterceptor.StopBlock();

            var confirm = MessageBox.Show("Are you sure you want to submit the exam?", "Submit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            SaveAnswer(); // Save last answer
            int correct = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                string selected = selectedAnswers.ContainsKey(i) ? selectedAnswers[i] : "";
                if (selected == questions[i].CorrectAnswer)
                    correct++;
            }

            MessageBox.Show($"You got {correct} out of {questions.Count} correct.");

            string dateTimeNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string regNo = currentUser.RegNo;

            // Convert selectedAnswers to string-keyed dictionary
            var selectedAnswersToSave = new Dictionary<string, string>();
            foreach (var entry in selectedAnswers)
            {
                string questionNo = (entry.Key + 1).ToString("D2");
                selectedAnswersToSave[questionNo] = entry.Value;
            }

            var examResult = new
            {
                PaperNo = paperNo,
                DateTime = dateTimeNow,
                Correct = correct,
                Total = questions.Count,
                Percentage = ((double)correct / questions.Count * 100).ToString("0.00"),
                selectedAnswers = selectedAnswersToSave
            };

            await client.SetAsync($"results/{regNo}/{paperNo}", examResult);

            await client.SetAsync($"results/{regNo}/{paperNo}/answers", selectedAnswersToSave);

            StudentDashboard studentDashboard = new StudentDashboard(currentUser);
            studentDashboard.Show();
            this.Close();

        }

        private string FormatTime(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            return $"{minutes:D2}:{seconds:D2}";
        }


        private void examTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeftInSeconds > 0)
            {
                timeLeftInSeconds--;
                lbl_timer.Text = FormatTime(timeLeftInSeconds);

                // Optional: turn red at last minute
                if (timeLeftInSeconds == 60)
                    lbl_timer.ForeColor = Color.Red;
            }
            else
            {
                examTimer.Stop();
                AutoSubmit();
            }

        }
        /// <summary>
        /// Final one‑shot submission path (timeout or cheating).
        /// Writes the result, shows a single message, then returns to dashboard.
        /// </summary>
        private async void AutoSubmit()
        {
            KeyboardInterceptor.StopBlock();

            // 1️⃣  Exit immediately if we’ve already started submitting
            if (isSubmitting) return;
            isSubmitting = true;

            // Detach the deactivate handler so it can’t fire again while we’re closing
         //   this.Deactivate -= ExamForm_Deactivate;

            // 2️⃣  Stop timer and capture the very last answer
            examTimer.Stop();
            SaveAnswer();

            // 3️⃣  Calculate score
            int correct = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                string selected = selectedAnswers.TryGetValue(i, out var val) ? val : "";
                if (selected == questions[i].CorrectAnswer) correct++;
            }

            // 4️⃣  Build answer map (01 → Option xx)
            var answersToSave = selectedAnswers
                .ToDictionary(kvp => (kvp.Key + 1).ToString("D2"), kvp => kvp.Value);

            // 5️⃣  Persist to Firebase
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string regNo = currentUser.RegNo;

            var resultObj = new
            {
                PaperNo = paperNo,
                DateTime = now,
                Correct = correct,
                Total = questions.Count,
                Percentage = ((double)correct / questions.Count * 100).ToString("0.00"),
                selectedAnswers = answersToSave
            };

            try
            {
                await client.SetAsync($"results/{regNo}/{paperNo}", resultObj);
                await client.SetAsync($"results/{regNo}/{paperNo}/answers", answersToSave);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving results:\n{ex.Message}", "Save Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 6️⃣  Notify the student once
            MessageBox.Show(
                $"Your exam was submitted automatically.\n\n" +
                $"Score : {correct} / {questions.Count}",
                "Exam Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // 7️⃣  Return to dashboard
            var dash = new StudentDashboard(currentUser);
            dash.Show();
            this.Close();          // closes the exam form safely
        }

        /*private void ExamForm_Deactivate(object sender, EventArgs e)
        {
            if (isSubmitting) return;      // already in the middle of submission

            switchCount++;

            if (switchCount == 1)
            {
                MessageBox.Show("You switched away from the exam window. Please stay focused!",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (switchCount >= 2)
            {
                // ⚠️  do NOT set isSubmitting here; let AutoSubmit handle it once
                MessageBox.Show("You switched away multiple times. Your exam will now be submitted.",
                                "Cheating Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AutoSubmit();              // single, final call
            }
        }*/

        private void DisableCheatingControls(Control ctrl)
        {
            // Disable right-click
            ctrl.MouseUp += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    // Do nothing — prevents default context menu
                }
            };

            // Block Ctrl+C and Ctrl+V
            ctrl.KeyDown += (s, e) =>
            {
                if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.A))
                {
                    e.SuppressKeyPress = true;
                }
            };
        }
        public class KeyboardInterceptor
        {
            private const int WH_KEYBOARD_LL = 13;
            private const int WM_KEYDOWN = 0x0100;

            private static LowLevelKeyboardProc _proc = HookCallback;
            private static IntPtr _hookID = IntPtr.Zero;

            public static void StartBlock()
            {
                _hookID = SetHook(_proc);
            }

            public static void StopBlock()
            {
                UnhookWindowsHookEx(_hookID);
            }

            private static IntPtr SetHook(LowLevelKeyboardProc proc)
            {
                using (Process curProcess = Process.GetCurrentProcess())
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                        GetModuleHandle(curModule.ModuleName), 0);
                }
            }

            private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

            private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
            {
                if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                    bool alt = (Control.ModifierKeys & Keys.Alt) == Keys.Alt;
                    bool ctrl = (Control.ModifierKeys & Keys.Control) == Keys.Control;

                    // Block common keys
                    if (
                        vkCode == 0x5B || // Left Windows
                        vkCode == 0x5C || // Right Windows
                        (vkCode == (int)Keys.Tab && alt) ||            // Alt+Tab
                        (vkCode == (int)Keys.Escape && ctrl) ||        // Ctrl+Esc
                        (vkCode == (int)Keys.F4 && alt) ||             // Alt+F4
                        (vkCode == (int)Keys.D && (Control.ModifierKeys & Keys.LWin) == Keys.LWin) || // Win+D
                        (vkCode == (int)Keys.M && (Control.ModifierKeys & Keys.LWin) == Keys.LWin)    // Win+M
                    )
                    {
                        return (IntPtr)1; // Block the key
                    }

                }

                return CallNextHookEx(_hookID, nCode, wParam, lParam);
            }

            // Win32 imports
            [DllImport("user32.dll")]
            private static extern IntPtr SetWindowsHookEx(int idHook,
                LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

            [DllImport("user32.dll")]
            private static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("user32.dll")]
            private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
                IntPtr wParam, IntPtr lParam);

            [DllImport("kernel32.dll")]
            private static extern IntPtr GetModuleHandle(string lpModuleName);
        }
        private void KillProcesses(string[] processNames)
        {
            foreach (string name in processNames)
            {
                try
                {
                    var processes = Process.GetProcessesByName(name);
                    foreach (var p in processes)
                    {
                        p.Kill();
                    }
                }
                catch (Exception ex)
                {
                    // Optional: log or show error (not recommended during exams)
                    Console.WriteLine($"Error killing {name}: {ex.Message}");
                }
            }
        }

    }
}
