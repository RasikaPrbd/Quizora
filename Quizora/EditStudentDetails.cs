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
    public partial class EditStudentDetails : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        string regNoOriginal;

        public EditStudentDetails()
        {
            InitializeComponent();
        }
        public EditStudentDetails(string regNo, string firstName, string lastName, string email, string password)
        {
            InitializeComponent();
            regNoOriginal = regNo;
            txt_regNo.Text = regNo;
            txt_firstName.Text = firstName;
            txt_lastName.Text = lastName;
            txt_email.Text = email;
            txt_password.Text = password;

            txt_regNo.ReadOnly = true; // Don't allow changing RegNo
            
            client = new FireSharp.FirebaseClient(config);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_firstName.Text) ||
                string.IsNullOrWhiteSpace(txt_lastName.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User updatedUser = new User
            {
                RegNo = regNoOriginal,
                FirstName = txt_firstName.Text,
                LastName = txt_lastName.Text,
                Email = txt_email.Text,
                Password = txt_password.Text,
                Role = "Student"
            };

            FirebaseResponse res = await client.UpdateAsync("users/" + regNoOriginal, updatedUser);

            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Student details have been updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update student.");
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_email.Clear();
            txt_password.Clear();
        }
    }
}
