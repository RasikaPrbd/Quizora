using FireSharp.Response;
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
    public partial class StudentDashboard : Form
    {
        private User currentUser;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public StudentDashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
            dgv_Results.CellContentClick += dgv_Results_CellContentClick;

        }

        public StudentDashboard()
        {
            InitializeComponent();
        }

        private async void StudentDashboard_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Connection to firebase is failed");
            }

            // Show student info
            lbl_studentName.Text = currentUser.FirstName + " " + currentUser.LastName;
            lbl_regNo.Text = currentUser.RegNo;

            LoadPendingExams();

            // Load papers
            /*FirebaseResponse res = await client.GetAsync("papers");
            if (res.Body != "null")
            {
                var papers = res.ResultAs<Dictionary<string, object>>();
                cmb_PaperNum.Items.Clear();
                foreach (var paper in papers.Keys)
                {
                    cmb_PaperNum.Items.Add(paper);
                }
            }*/
        }

        private async void cmb_PaperNum_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                string paperNo = cmb_PaperNum.SelectedItem.ToString();

                FirebaseResponse res = await client.GetAsync($"papers/{paperNo}/questions");
                if (res.Body != "null")
                {
                    var questions = res.ResultAs<Dictionary<string, object>>();
                    lbl_questionCount.Text = questions.Count.ToString();

                // Fetch actual duration from Firebase
                FirebaseResponse timeRes = await client.GetAsync($"papers/{paperNo}/duration");
                if (timeRes.Body != "null")
                {
                    int duration = timeRes.ResultAs<int>();
                    lbl_time.Text = $"{duration} minutes";
                }
                else
                {
                    lbl_time.Text = "Time: N/A";
                }

            }
            else
                {
                    lbl_questionCount.Text = "Questions: 0";
                    lbl_time.Text = "Time: N/A";
                }
            

        }

        private void lnklbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                       "Confirm Logout",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 loginForm = new Form1(); // adjust to your login form class name
                loginForm.Show();
                this.Close(); // or this.Hide() depending on your flow
            }

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (cmb_PaperNum.SelectedItem == null)
            {
                MessageBox.Show("Please select a paper from the list before starting the exam.", "Paper Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedPaper = cmb_PaperNum.SelectedItem.ToString();

            // Open ExamForm with paper number and current user
            ExamForm examForm = new ExamForm(selectedPaper, currentUser);
            examForm.Show();

            this.Hide(); // Optional: hide dashboard during exam
        }
        private async void LoadPendingExams()
        {
            try
            {
                // 1. Get all available paper numbers
                FirebaseResponse allPapersRes = await client.GetAsync("papers");
                var allPapers = allPapersRes.ResultAs<Dictionary<string, object>>();
                if (allPapers == null) return;

                // 2. Get student's completed exams
                FirebaseResponse studentResultsRes = await client.GetAsync("results/" + currentUser.RegNo);
                var completedExams = studentResultsRes.ResultAs<Dictionary<string, object>>();
                List<string> completed = completedExams?.Keys.ToList() ?? new List<string>();

                // 3. Filter: show only papers that are NOT completed
                cmb_PaperNum.Items.Clear();
                foreach (var paperNo in allPapers.Keys)
                {
                    if (!completed.Contains(paperNo))
                    {
                        cmb_PaperNum.Items.Add(paperNo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load exams: " + ex.Message);
            }
        }

        private async void btn_viewResults_Click(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse res = await client.GetAsync("results/" + currentUser.RegNo);
                var results = res.ResultAs<Dictionary<string, ExamResult>>();

                dgv_Results.Rows.Clear();
                dgv_Results.Columns.Clear();

                // Add columns to DataGridView
                dgv_Results.Columns.Add("PaperNo", "Paper Number");
                dgv_Results.Columns.Add("DateTime", "Date & Time");
                dgv_Results.Columns.Add("Correct", "Correct / Total");
                dgv_Results.Columns.Add("Percentage", "Percentage");

                // Add the 'View' link column if not already added
                if (!dgv_Results.Columns.Contains("View"))
                {
                    DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
                    linkColumn.HeaderText = "Details";
                    linkColumn.Name = "View";
                    linkColumn.Text = "View";
                    linkColumn.UseColumnTextForLinkValue = true;
                    dgv_Results.Columns.Add(linkColumn);
                }

                if (results != null)
                {
                    dgv_Results.Visible = true;
                    dgv_Results.RowHeadersVisible = false;
                    dgv_Results.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    dgv_Results.DefaultCellStyle.Font = new Font("Segoe UI", 10);

                    foreach (var result in results.Values)
                    {
                        dgv_Results.Rows.Add(
                            result.PaperNo,
                            result.DateTime,
                            $"{result.Correct} / {result.Total}",
                            $"{result.Percentage}%"
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No exam results were found for this student.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading results: " + ex.Message);
            }
        }
        private bool isDetailOpen = false;

        private void dgv_Results_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_Results.Columns[e.ColumnIndex].Name == "View")
            {
                // Get PaperNo from the clicked row
                string paperNo = dgv_Results.Rows[e.RowIndex].Cells["PaperNo"].Value.ToString();

                // Open a new form to show detailed result
                DetailedResultForm detailedForm = new DetailedResultForm(currentUser.RegNo, paperNo);
                detailedForm.ShowDialog(); // Show as modal
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?",
                                         "Confirm Exit",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
