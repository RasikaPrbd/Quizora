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

namespace Quizora.teacher_UC
{
    public partial class UC_manageStudents : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;


        public UC_manageStudents()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddStudents addStudents = new AddStudents();

            // ✅ Show once and store the result
            var result = addStudents.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadStudents(); // ✅ Refresh table
            }

        }

        private void UC_manageStudents_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Firebase connection failed!");
                return;
            }
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;

            LoadStudents(); // ✅ call this only after client is initialized
            dgv_students.RowHeadersVisible = false;
            dgv_students.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv_students.DefaultCellStyle.Font = new Font("Segoe UI", 10);

        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_students.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student from the table before attempting to delete.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgv_students.SelectedRows[0];
            string regNo = row.Cells["RegNo"].Value.ToString();

            var confirm = MessageBox.Show($"Are you sure you want to delete student {regNo}?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                FirebaseResponse res = await client.DeleteAsync("users/" + regNo);

                if (res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("The student has been successfully deleted from the system.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents();  // Refresh the table after delete
                }
                else
                {
                    MessageBox.Show("An error occurred while trying to delete the student. Please try again.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private async void LoadStudents()
        {
            try
            {
                FirebaseResponse res = await client.GetAsync("users");
                var data = res.ResultAs<Dictionary<string, User>>();

                dgv_students.Rows.Clear();
                dgv_students.Columns.Clear();

                dgv_students.Columns.Add("RegNo", "Reg. Number");
                dgv_students.Columns.Add("FirstName", "First Name");
                dgv_students.Columns.Add("LastName", "Last Name");
                dgv_students.Columns.Add("Email", "Email");
                dgv_students.Columns.Add("Password", "Password");

                if (data != null)
                {
                    foreach (var user in data.Values)
                    {
                        if (user.Role == "Student")
                        {
                            dgv_students.Rows.Add(user.RegNo, user.FirstName, user.LastName, user.Email, user.Password);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_students.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student from the table before attempting to edit.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get values from selected row
            DataGridViewRow row = dgv_students.SelectedRows[0];
            string regNo = row.Cells["RegNo"].Value.ToString();
            string firstName = row.Cells["FirstName"].Value.ToString();
            string lastName = row.Cells["LastName"].Value.ToString();
            string email = row.Cells["Email"].Value.ToString();
            string password = row.Cells["Password"].Value.ToString();

            // Pass to edit form
            EditStudentDetails editForm = new EditStudentDetails(regNo, firstName, lastName, email, password);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadStudents(); // Refresh table after update
            }
        }

        private void dgv_students_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_students.SelectedRows.Count > 0)
            {
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
            }
            else
            {
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
            }
        }
    }
}
