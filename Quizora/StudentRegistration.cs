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
    public partial class StudentRegistration : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Connection failed!");
                return;
            }
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (txt_firstName.Text == "" || txt_lastName.Text == "" || txt_regNo.Text == "" || txt_email.Text == "" || txt_password.Text == "" || txt_conPassword.Text == "")
            {
                MessageBox.Show("Please fill in all the required fields to register.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_password.Text != txt_conPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please retype.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if registration number already exists
            FirebaseResponse check = await client.GetAsync("users/" + txt_regNo.Text);
            if (check.Body != "null")
            {
                MessageBox.Show("The registration number you entered is already in use. Please use a unique registration number.", "Duplicate Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create user object
            User user = new User
            {
                FirstName = txt_firstName.Text,
                LastName = txt_lastName.Text,
                RegNo = txt_regNo.Text,
                Email = txt_email.Text,
                Password = txt_password.Text
            };

            // Save user in Firebase under users/{RegNo}
            SetResponse res = await client.SetAsync("users/" + user.RegNo, user);

            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Student has been registered successfully.", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally: redirect to login
                txt_firstName.Text = "";
                txt_lastName.Text = "";
                txt_regNo.Text = "";
                txt_email.Text = "";
                txt_password.Text = "";
                txt_conPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Registration failed due to an unexpected error. Please check your input and try again.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void linklbl_loginHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void btn_next_Click(object sender, EventArgs e)
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
