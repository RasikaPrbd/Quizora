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
    public partial class UC_studentResults : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private List<ExamResultDisplay> allResults = new List<ExamResultDisplay>();

        public UC_studentResults()
        {
            InitializeComponent();
        }

        private async void UC_studentResults_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Connection to Firebase failed!");
                return;
            }

            await LoadAllResults();
        }

        private async Task LoadAllResults()
        {
            allResults.Clear();
            cmb_filterPaper.Items.Clear();

            FirebaseResponse res = await client.GetAsync("results");
            var studentNodes = res.ResultAs<Dictionary<string, object>>(); // regNo level

            if (studentNodes == null)
                return;

            foreach (var student in studentNodes)
            {
                string regNo = student.Key;

                FirebaseResponse studentResultsRes = await client.GetAsync("results/" + regNo);
                var paperResults = studentResultsRes.ResultAs<Dictionary<string, ExamResult>>(); // paperNo level

                if (paperResults == null)
                    continue;

                FirebaseResponse userRes = await client.GetAsync("users/" + regNo);
                User user = userRes.ResultAs<User>();

                if (user == null) continue;

                foreach (var paperEntry in paperResults)
                {
                    string paperNo = paperEntry.Key;
                    ExamResult exam = paperEntry.Value;

                    if (exam == null) continue;

                    // ✅ Only add paperNo once
                    if (!cmb_filterPaper.Items.Contains(paperNo))
                        cmb_filterPaper.Items.Add(paperNo);

                    allResults.Add(new ExamResultDisplay
                    {
                        RegNo = regNo,
                        StudentName = $"{user.FirstName} {user.LastName}",
                        PaperNo = paperNo,
                        DateTime = exam.DateTime,
                        CorrectAnswers = exam.Correct,
                        TotalQuestions = exam.Total,
                        Percentage = exam.Percentage
                    });
                }
            }

            DisplayResults(allResults); // show everything at start
        }

        private void DisplayResults(List<ExamResultDisplay> results)
        {
            dgv_results.Rows.Clear();
            dgv_results.Columns.Clear();

            dgv_results.Columns.Add("StudentName", "Student Name");
            dgv_results.Columns.Add("RegNo", "Registration No");
            dgv_results.Columns.Add("PaperNo", "Paper No");
            dgv_results.Columns.Add("DateTime", "Date/Time");
            dgv_results.Columns.Add("Score", "Score");
            dgv_results.Columns.Add("Percentage", "Percentage");

            foreach (var item in results)
            {
                dgv_results.Rows.Add(
                    item.StudentName,
                    item.RegNo,
                    item.PaperNo,
                    item.DateTime,
                    $"{item.CorrectAnswers}/{item.TotalQuestions}",
                    item.Percentage
                );
            }

            dgv_results.ReadOnly = true;
            dgv_results.AllowUserToAddRows = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string regNoFilter = txt_searchRegNo.Text.Trim().ToLower();
            string paperFilter = cmb_filterPaper.SelectedItem?.ToString();

            var filtered = allResults.Where(r =>
                (string.IsNullOrEmpty(regNoFilter) || r.RegNo.ToLower().Contains(regNoFilter)) &&
                (string.IsNullOrEmpty(paperFilter) || r.PaperNo == paperFilter)
            ).ToList();

            DisplayResults(filtered);
        }

        private void btn_clearFilters_Click(object sender, EventArgs e)
        {
            txt_searchRegNo.Clear();
            cmb_filterPaper.SelectedIndex = -1;
            DisplayResults(allResults); // reload all
        }
    }

    // ✅ Updated model to match your database
    public class ExamResult
    {
        public string DateTime { get; set; }
        public int Correct { get; set; }
        public int Total { get; set; }
        public string Percentage { get; set; }
        public string PaperNo { get; set; }
    }

    public class ExamResultDisplay
    {
        public string StudentName { get; set; }
        public string RegNo { get; set; }
        public string PaperNo { get; set; }
        public string DateTime { get; set; }
        public int CorrectAnswers { get; set; }
        public int TotalQuestions { get; set; }
        public string Percentage { get; set; }
    }
}
