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
    public partial class UC_viewAndDeleteQuestions : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public UC_viewAndDeleteQuestions()
        {
            InitializeComponent();
        }

        private async void UC_viewAndDeleteQuestions_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Connection failed!");
                return;
            }
            await LoadPaperNumbers();
        }
        

        private async Task LoadPaperNumbers()
        {
            FirebaseResponse res = await client.GetAsync("papers");
            if (res.Body != "null")
            {
                var data = res.ResultAs<Dictionary<string, object>>();
                cmb_PaperNum.Items.Clear();
                foreach (var paper in data.Keys)
                {
                    cmb_PaperNum.Items.Add(paper);
                }
            }
        }

        private async void cmb_PaperNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paperNo = cmb_PaperNum.SelectedItem.ToString();
            FirebaseResponse res = await client.GetAsync($"papers/{paperNo}/questions");

            if (res.Body != "null")
            {
                var questions = res.ResultAs<Dictionary<string, Question>>();
                var questionList = questions
                    .OrderBy(q => q.Key) // sort by QuestionNo
                    .Select(q => q.Value)
                    .ToList();

                dgView_paper.DataSource = questionList;

                // 🔻 Remove PaperNumber column (if it exists)
                if (dgView_paper.Columns.Contains("PaperNo"))
                {
                    dgView_paper.Columns["PaperNo"].Visible = false;
                }
                // ✅ Resize QuestionNo column (make it narrower)
                if (dgView_paper.Columns.Contains("QuestionNo"))
                {
                    dgView_paper.Columns["QuestionNo"].Width = 60; // Adjust width as needed (e.g., 50–70)
                }

                // Fix DataGridView appearance
                dgView_paper.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgView_paper.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                dgView_paper.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgView_paper.ColumnHeadersHeight = 35;

                dgView_paper.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dgView_paper.RowTemplate.Height = 30;
                dgView_paper.RowHeadersVisible = false;
                dgView_paper.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgView_paper.AllowUserToAddRows = false;
                dgView_paper.AllowUserToResizeRows = false;
                dgView_paper.ReadOnly = true;
            }
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (cmb_PaperNum.SelectedItem == null || dgView_paper.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select both a paper and a question before attempting to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string paperNo = cmb_PaperNum.SelectedItem.ToString();
            string selectedQNo = dgView_paper.SelectedRows[0].Cells["QuestionNo"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // STEP 1: Delete selected question
                await client.DeleteAsync($"papers/{paperNo}/questions/{selectedQNo}");
            }
            // STEP 2: Fetch remaining questions
            FirebaseResponse res = await client.GetAsync($"papers/{paperNo}/questions");
            if (res.Body == "null")
            {
                dgView_paper.DataSource = null;
                return;
            }

            // STEP 3: Get and sort the remaining questions
            var data = res.ResultAs<Dictionary<string, Question>>();
            var sorted = data.OrderBy(q => q.Key).Select(q => q.Value).ToList();

            // STEP 4: Delete the entire questions node to clear old numbering
            await client.DeleteAsync($"papers/{paperNo}/questions");

            // STEP 5: Re-number and re-insert
            for (int i = 0; i < sorted.Count; i++)
            {
                sorted[i].QuestionNo = (i + 1).ToString("D2"); // 01, 02, etc.
                await client.SetAsync($"papers/{paperNo}/questions/{sorted[i].QuestionNo}", sorted[i]);
            }


            MessageBox.Show("The selected question has been deleted and the remaining questions have been re-ordered successfully.", "Question Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmb_PaperNum_SelectedIndexChanged(null, null); // Refresh table
        }
    }
}
