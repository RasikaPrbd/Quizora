using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class AddStudents : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public AddStudents()
        {
            InitializeComponent();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            string regNo = txt_regNo.Text.Trim();

            // Validate
            if (string.IsNullOrEmpty(txt_firstName.Text) ||
                string.IsNullOrEmpty(txt_lastName.Text) ||
                string.IsNullOrEmpty(regNo) ||
                string.IsNullOrEmpty(txt_email.Text) ||
                string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Please complete all fields before adding a student.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicates
            FirebaseResponse checkRes = await client.GetAsync("users/" + regNo);
            if (checkRes.Body != "null")
            {
                MessageBox.Show("A student with this registration number already exists. Please use a unique one.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create student object
            User newUser = new User
            {
                FirstName = txt_firstName.Text,
                LastName = txt_lastName.Text,
                RegNo = regNo,
                Email = txt_email.Text,
                Password = txt_password.Text,
                Role = "Student"
            };

            // Save to Firebase
            FirebaseResponse saveRes = await client.SetAsync("users/" + regNo, newUser);
            if (saveRes.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("New student has been added successfully!", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close(); // or clear fields for another entry
            }
            else
            {
                MessageBox.Show("Failed to add the student. Please try again or check your connection.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            txt_regNo.Text = "";
            txt_email.Text = "";
            txt_password.Text = "";
            txt_conPassword.Text = "";
        }
    }
}
