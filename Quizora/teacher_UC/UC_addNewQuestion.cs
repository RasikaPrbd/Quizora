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
using Microsoft.VisualBasic;


namespace Quizora.teacher_UC
{
    public partial class UC_addNewQuestion : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        int questionCounter = 1;


        public UC_addNewQuestion()
        {
            InitializeComponent();
        }

        private void UC_addNewQuestion_Load(object sender, EventArgs e)
        {
            client=new FireSharp.FirebaseClient(config);
            if (client == null )
            {
                MessageBox.Show("Connection to firebase is failed");
            }

            
            /* if (client != null)
            {
                MessageBox.Show("connection is successfully");
            } */
            lbl_qNum.Text = "01";
        }

        private void SaveQuestion()
        {
            var q = new Question
            {
                PaperNo = txt_paperNumber.Text,
                QuestionNo = questionCounter.ToString("D2"),
                QuestionText = txt_Question.Text,
                OptionA = txt_option1.Text,
                OptionB = txt_option2.Text,
                OptionC = txt_option3.Text,
                OptionD = txt_option4.Text,
                CorrectAnswer = cmb_answer.Text
            };

            string path = $"papers/{q.PaperNo}/questions/{q.QuestionNo}";
            client.Set(path, q);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            txt_Question.Clear();
            txt_option1.Clear();
            txt_option2.Clear();
            txt_option3.Clear();
            txt_option4.Clear();
            cmb_answer.SelectedIndex = -1;
        }

        private void btn_next_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Question.Text) ||
                string.IsNullOrWhiteSpace(txt_option1.Text) ||
                string.IsNullOrWhiteSpace(txt_option2.Text) ||
                string.IsNullOrWhiteSpace(txt_option3.Text) ||
                string.IsNullOrWhiteSpace(txt_option4.Text) ||
                cmb_answer.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txt_paperNumber.Text))
            {
                MessageBox.Show("Please complete all fields before saving.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveQuestion();

            questionCounter++;
            lbl_qNum.Text = questionCounter.ToString("D2");

            txt_Question.Clear();
            txt_option1.Clear();
            txt_option2.Clear();
            txt_option3.Clear();
            txt_option4.Clear();
            cmb_answer.SelectedIndex = -1;
        }

        private async void btn_finish_Click(object sender, EventArgs e)
        {
            var timeForm = new ExamTimeInputForm();
            if (timeForm.ShowDialog() == DialogResult.OK)
            {
                if (int.TryParse(timeForm.EnteredTime, out int durationMinutes))
                {
                    await client.SetAsync($"papers/{txt_paperNumber.Text}/duration", durationMinutes);
                    MessageBox.Show("Paper added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid time. Time not saved.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
