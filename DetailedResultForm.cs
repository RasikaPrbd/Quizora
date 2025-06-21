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
    public partial class DetailedResultForm : Form
    {
        private string regNo;
        private string paperNo;

        private IFirebaseClient client;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        public DetailedResultForm(string regNo, string paperNo)
        {
            InitializeComponent();

            this.regNo = regNo;
            this.paperNo = paperNo;
        }

        private async void DetailedResultForm_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Failed to connect to Firebase.");
                return;
            }
            // Resize form to fit the DataGridView + some padding
            int widthPadding = 40;
            int heightPadding = 80;

            this.Width = dgv_detailed.Width + widthPadding;
            this.Height = dgv_detailed.Height + heightPadding;


            dgv_detailed.Columns.Clear();
            dgv_detailed.Rows.Clear();

            dgv_detailed.Columns.Add("QNo", "Q.No");
            dgv_detailed.Columns.Add("Question", "Question");
            dgv_detailed.Columns.Add("Selected", "Selected Answer");
            dgv_detailed.Columns.Add("Correct", "Correct Answer");

            dgv_detailed.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv_detailed.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv_detailed.RowHeadersVisible = false;
            dgv_detailed.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_detailed.Columns["Question"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_detailed.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_detailed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgv_detailed.ReadOnly = true;
            dgv_detailed.AllowUserToAddRows = false;
            dgv_detailed.AllowUserToDeleteRows = false;
            dgv_detailed.AllowUserToResizeRows = false;
            dgv_detailed.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_detailed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ShowIcon = false;
            dgv_detailed.Columns["QNo"].Width = 50; // or any small value like 40, 60 depending on your design



            // Get student selected answers
            FirebaseResponse answersRes = await client.GetAsync($"results/{regNo}/{paperNo}/answers");
            Dictionary<string, string> selectedAnswers = answersRes.ResultAs<Dictionary<string, string>>();

            // Get actual questions
            FirebaseResponse questionsRes = await client.GetAsync($"papers/{paperNo}/questions");
            Dictionary<string, Question> questions = questionsRes.ResultAs<Dictionary<string, Question>>();

            if (questions != null)
            {
                foreach (var qEntry in questions.OrderBy(q => q.Key))
                {

                    string qNo = qEntry.Key;
                    Question q = qEntry.Value;

                    string selectedKey = selectedAnswers != null && selectedAnswers.ContainsKey(qNo)
                        ? selectedAnswers[qNo]
                        : "";

                    // Map option keys to actual text
                    string studentAnswer = "Not Answered";
                    if (selectedKey == "Option 01") studentAnswer = q.OptionA;
                    else if (selectedKey == "Option 02") studentAnswer = q.OptionB;
                    else if (selectedKey == "Option 03") studentAnswer = q.OptionC;
                    else if (selectedKey == "Option 04") studentAnswer = q.OptionD;

                    string correctAnswer = "";
                    if (q.CorrectAnswer == "Option 01") correctAnswer = q.OptionA;
                    else if (q.CorrectAnswer == "Option 02") correctAnswer = q.OptionB;
                    else if (q.CorrectAnswer == "Option 03") correctAnswer = q.OptionC;
                    else if (q.CorrectAnswer == "Option 04") correctAnswer = q.OptionD;

                    int rowIndex = dgv_detailed.Rows.Add(qNo, q.QuestionText, studentAnswer, correctAnswer);

                    // ✅ Color the whole row
                    if (studentAnswer == correctAnswer)
                    {
                        dgv_detailed.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Honeydew; // green
                    }
                    else
                    {
                        dgv_detailed.Rows[rowIndex].DefaultCellStyle.BackColor = Color.MistyRose; // red
                    }
                    dgv_detailed.Dock = DockStyle.Fill;
                }
            }
        }
    }
}
