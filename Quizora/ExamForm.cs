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
            MessageBox.Show("Are you sure you want to submit the exam?", "Submit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                SaveAnswer(); // Save the last answer
                int correct = 0;

                for (int i = 0; i < questions.Count; i++)
                {
                    string selected = selectedAnswers.ContainsKey(i) ? selectedAnswers[i] : "";
                    if (selected == questions[i].CorrectAnswer)
                        correct++;
                }

                MessageBox.Show($"You got {correct} out of {questions.Count} correct.");

                // After calculating 'correct'
                string dateTimeNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string regNo = currentUser.RegNo;

                var examResult = new
                {
                    PaperNo = paperNo,
                    DateTime = dateTimeNow,
                    Correct = correct,
                    Total = questions.Count,
                    Percentage = ((double)correct / questions.Count * 100).ToString("0.00")
                };

                // Save to Firebase: results/{regNo}/{paperNo}
                await client.SetAsync($"results/{regNo}/{paperNo}", examResult);


                // TODO: Close form and go to dashboard
                StudentDashboard studentDashboard = new StudentDashboard(currentUser);
                studentDashboard.Show();
                this.Close();
                // Temporarily close here
            }
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
        private void AutoSubmit()
        {
            SaveAnswer();

            int correct = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                string selected = selectedAnswers.ContainsKey(i) ? selectedAnswers[i] : "";
                if (selected == questions[i].CorrectAnswer)
                    correct++;
            }

            MessageBox.Show("Your exam has been submitted automatically.", "Exam Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"You answered {correct} out of {questions.Count} correctly.", "Exam Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: return to dashboard
            StudentDashboard studentDashboard = new StudentDashboard();
            studentDashboard.Show();
            this.Close(); 
            
        }
        /*private void ExamForm_Deactivate(object sender, EventArgs e)
        {
            switchCount++;

            if (switchCount == 1)
            {
                MessageBox.Show("You switched away from the exam window. Please stay focused!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (switchCount >= 2)
            {
                MessageBox.Show("You switched away multiple times. Exam will be submitted.", "Cheating Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AutoSubmit(); // ✅ Make sure this method handles submission logic
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
                if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
                {
                    e.SuppressKeyPress = true;
                }
            };
        }

    }
}
