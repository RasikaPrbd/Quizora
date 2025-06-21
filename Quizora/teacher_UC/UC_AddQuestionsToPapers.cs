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


namespace Quizora.teacher_UC
{
    public partial class UC_AddQuestionsToPapers : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        int questionCounter = 1;

        public UC_AddQuestionsToPapers()
        {
            InitializeComponent();
        }

        private void cmb_PaperNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void UC_AddQuestionsToPapers_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Firebase connection failed.");
                return;
            }
            await LoadPaperNumbers();
        }
        private async Task LoadPaperNumbers()
        {
            FirebaseResponse res = await client.GetAsync("papers");

            if (res.Body != "null")
            {
                Dictionary<string, object> data = res.ResultAs<Dictionary<string, object>>();
                cmb_PaperNum.Items.Clear();

                foreach (var paper in data.Keys)
                {
                    cmb_PaperNum.Items.Add(paper);
                }
            }
        }

        private async void cmb_PaperNum_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_PaperNum.SelectedItem == null)
            {
                MessageBox.Show("Please select a paper first.", "No Paper Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedPaper = cmb_PaperNum.SelectedItem.ToString();

            FirebaseResponse res = await client.GetAsync("papers/" + selectedPaper + "/questions");

            if (res.Body != "null")
            {
                var questions = res.ResultAs<Dictionary<string, object>>();
                questionCounter = questions.Count + 1; // ✅ keep in sync
                txt_Question.Focus();
            }
            else
            {
                questionCounter = 0;
            }

            lbl_qNum.Text = questionCounter.ToString("D2"); // ✅ always update label

        }
        private async Task SaveQuestion()
        {
            var q = new Question
            {
                PaperNo = cmb_PaperNum.SelectedItem.ToString(),
                QuestionNo = questionCounter.ToString("D2"),
                QuestionText = txt_Question.Text,
                OptionA = txt_option1.Text,
                OptionB = txt_option2.Text,
                OptionC = txt_option3.Text,
                OptionD = txt_option4.Text,
                CorrectAnswer = cmb_answer.Text
            };

            string path = $"papers/{q.PaperNo}/questions/{q.QuestionNo}";

            // 🛑 First check if the question number already exists
            FirebaseResponse existing = await client.GetAsync(path);
            if (existing.Body != "null")
            {
                MessageBox.Show($"Question {q.QuestionNo} already exists. Cannot overwrite.", "Duplicate Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Save only if not existing
            await client.SetAsync(path, q);
        }

        private async void btn_next_Click(object sender, EventArgs e)
        {
            // 🔍 Validate input fields
            if (string.IsNullOrWhiteSpace(txt_Question.Text) ||
                string.IsNullOrWhiteSpace(txt_option1.Text) ||
                string.IsNullOrWhiteSpace(txt_option2.Text) ||
                string.IsNullOrWhiteSpace(txt_option3.Text) ||
                string.IsNullOrWhiteSpace(txt_option4.Text) ||
                cmb_answer.SelectedIndex == -1 ||
                cmb_PaperNum.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all fields before saving.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Save question asynchronously
            await SaveQuestion();

            // ✅ Show success message
            MessageBox.Show($"Question {questionCounter.ToString("D2")} saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ➕ Move to next question
            questionCounter++;
            lbl_qNum.Text = questionCounter.ToString("D2");

            // 🧽 Clear inputs for next question
            txt_Question.Clear();
            txt_option1.Clear();
            txt_option2.Clear();
            txt_option3.Clear();
            txt_option4.Clear();
            cmb_answer.SelectedIndex = -1;

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_Question.Clear();
            txt_option1.Clear();
            txt_option2.Clear();
            txt_option3.Clear();
            txt_option4.Clear();
            cmb_answer.SelectedIndex = -1;

        }

        private async void btn_finish_Click(object sender, EventArgs e)
        {
            // Check if user typed something but didn’t click Next
            bool hasUnsavedInput =
                !string.IsNullOrWhiteSpace(txt_Question.Text) ||
                !string.IsNullOrWhiteSpace(txt_option1.Text) ||
                !string.IsNullOrWhiteSpace(txt_option2.Text) ||
                !string.IsNullOrWhiteSpace(txt_option3.Text) ||
                !string.IsNullOrWhiteSpace(txt_option4.Text) ||
                cmb_answer.SelectedIndex != -1;

            if (hasUnsavedInput)
            {
                var saveConfirm = MessageBox.Show("You have an unsaved question. Do you want to save it before finishing?",
                                                  "Unsaved Question",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);

                if (saveConfirm == DialogResult.Cancel)
                {
                    return; // Don't proceed
                }
                else if (saveConfirm == DialogResult.Yes)
                {
                    if (cmb_PaperNum.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a paper number before saving.", "Missing Paper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    await SaveQuestion(); // 🔁 Save the current question
                    MessageBox.Show("Question saved before finishing.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    questionCounter++;
                }
                // If No, continue without saving
            }

            // Final confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to finish adding questions to this paper?",
                                                  "Confirm Finish",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Questions added successfully!", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🧽 Clear all input fields
                txt_Question.Clear();
                txt_option1.Clear();
                txt_option2.Clear();
                txt_option3.Clear();
                txt_option4.Clear();
                cmb_answer.SelectedIndex = -1;
                cmb_PaperNum.SelectedIndex = -1;

                // 🔁 Reset question counter and label
                questionCounter = 1;
                lbl_qNum.Text = "01";
            }
        }

        private void txt_Question_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_option1.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_option1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_option2.Focus();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                txt_Question.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_option2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_option3.Focus();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                txt_option1.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_option3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_option4.Focus();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                txt_option2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_option4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_option3.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
