using FireSharp.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Quizora.teacher_UC
{
    public partial class UC_updateQuestions : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public UC_updateQuestions()
        {
            InitializeComponent();
        }

        private void UC_updateQuestions_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Connection failed!");
                return;
            }
            LoadPaperNumbers();
        }
        private async void LoadPaperNumbers()
        {
            FirebaseResponse res = await client.GetAsync("papers");

            if (res.Body != null)
            {
                Dictionary<string, object> Papers = res.ResultAs<Dictionary<string, object>>();
            
                cmb_PaperNum.Items.Clear();

                foreach (var paper in Papers.Keys)
                {
                    cmb_PaperNum.Items.Add(paper);
                }
            }
        }

        private async void cmb_PaperNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_PaperNum.SelectedIndex == -1)
            {
                return;
            }

            string paperNo = cmb_PaperNum.SelectedItem.ToString();

            FirebaseResponse res = await client.GetAsync("papers/" + paperNo + "/questions");

            if (res.Body != null)
            {
                Dictionary<string, object>questions = res.ResultAs<Dictionary<string , object>>();

                cmb_QuestionNum.Items.Clear();

                foreach(var q in questions.Keys)
                {
                    cmb_QuestionNum.Items.Add(q);
                }
            }

        }

        private async void cmb_QuestionNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_PaperNum.SelectedItem==null || cmb_QuestionNum.SelectedItem == null)
            {
                return;
            }

            string paperNo = cmb_PaperNum.SelectedItem.ToString();
            string qno = cmb_QuestionNum.SelectedItem.ToString();

            FirebaseResponse res = await client.GetAsync($"papers/{paperNo}/questions/{qno}");
            
            if (res.Body == null)
            {
                MessageBox.Show("Selected question does not exist in the database.","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
            Question q = res.ResultAs<Question>();

            txt_Question.Text = q.QuestionText;
            txt_option1.Text = q.OptionA;
            txt_option2.Text = q.OptionB;
            txt_option3.Text = q.OptionC;
            txt_option4.Text = q.OptionD;
            cmb_answer.SelectedItem = q.CorrectAnswer;
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (cmb_PaperNum.SelectedItem == null || cmb_QuestionNum.SelectedItem == null)
            {
                MessageBox.Show("Please select both Paper and Question Number");
                return;
            }

            if (cmb_answer.SelectedItem == null)
            {
                MessageBox.Show("Please select the correct answer");
                return;
            }

            Question updatedQuestion = new Question
            {
                PaperNo = cmb_PaperNum.SelectedItem.ToString(),
                QuestionNo = cmb_QuestionNum.SelectedItem.ToString(),
                QuestionText = txt_Question.Text,
                OptionA = txt_option1.Text,
                OptionB = txt_option2.Text,
                OptionC = txt_option3.Text,
                OptionD = txt_option4.Text,
                CorrectAnswer = cmb_answer.SelectedItem.ToString()
            };

            FirebaseResponse res = await client.SetAsync($"papers/{updatedQuestion.PaperNo}/questions/{updatedQuestion.QuestionNo}", updatedQuestion);

            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Question updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to update question.");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_Question.Clear();
            txt_option1.Clear();
            txt_option2.Clear();
            txt_option3.Clear();
            txt_option4.Clear();

            cmb_PaperNum.SelectedIndex = -1;
            cmb_QuestionNum.SelectedIndex = -1;
            cmb_answer.SelectedIndex = -1;
        }
    }
}
