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
using System.Net;
using System.Net.Mail;

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
            txt_firstName.Focus();
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

                SendEmailToStudent(user.Email, user.RegNo, user.Password);


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
            txt_firstName.Focus();
        }

        private void txt_firstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_lastName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_lastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_regNo.Focus();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                txt_firstName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_regNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_email.Focus();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                txt_lastName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_password.Focus();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                txt_regNo.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_conPassword.Focus();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                txt_email.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_conPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_register.PerformClick();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                txt_password.Focus();
                e.SuppressKeyPress = true;
            }
        }
        
        private void SendEmailToStudent(string toEmail, string regNo, string password)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("quizora.examinationsystem@gmail.com", "QUIZORA Admin");
                message.To.Add(toEmail);
                message.Subject = "Your QUIZORA Exam Account Has Been Created";

                // 📧 HTML email body
                message.IsBodyHtml = true;
                message.Body = $@"
                    <html>
                    <body style='font-family:Segoe UI, sans-serif; color:#333;'>
                        <h2 style='color:#4CAF50;'>Welcome to QUIZORA!</h2>
                        <p>Dear Student,</p>
                        <p>Your exam account has been created successfully. You can now log in using the following details:</p>
                        <table style='border: 1px solid #ccc; padding: 10px;'>
                            <tr>
                                <td><strong>Username (Reg. No):</strong></td>
                                <td>{regNo}</td>
                            </tr>
                            <tr>
                                <td><strong>Password:</strong></td>
                                <td>{password}</td>
                            </tr>
                        </table>
                        <p>🔐 Please keep your login credentials safe.</p>
                        <br>
                        <p>Good luck with your exams!</p>
                        <p style='font-size: 12px; color: #888;'>— QUIZORA Team</p>
                    </body>
                    </html>";

                // SMTP settings
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("quizora.examinationsystem@gmail.com", "kpdsbasysbeuqbtx");
                smtp.EnableSsl = true;
                smtp.Send(message);

                MessageBox.Show("Registration email sent successfully!", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send registration email.\n\n" + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_conPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
