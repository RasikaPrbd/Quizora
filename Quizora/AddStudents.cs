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
using System.Net;
using System.Net.Mail;
using System.IO;


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
            if (txt_password.Text != txt_conPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please retype.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Clear();
                txt_conPassword.Clear();
                txt_password.Focus();
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
                SendEmailToStudent(newUser.Email, newUser.RegNo, newUser.Password);
                DialogResult confirm = MessageBox.Show("Student added. Do you want to add another one?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    btn_clear.PerformClick();
                    txt_firstName.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Failed to add the student. Please try again or check your connection.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            txt_firstName.Focus();
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
                btn_add.PerformClick();
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
                message.Subject = "Your QUIZORA Account Has Been Created";
                message.IsBodyHtml = true;

                string htmlBody = $@"
                    <html>
                    <body style='font-family:Segoe UI, sans-serif; color:#333;'>
                        <h2 style='color:#4CAF50;'>Welcome to QUIZORA!</h2>
                        <p>Dear Student,</p>
                        <p>Your exam account has been successfully added to the system. You can now log in using the credentials below:</p>
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
                        <p>🔐 Please keep your credentials confidential.</p>
                        <br>
                        <p>Best of luck with your exams!</p>
                        <p style='font-size: 12px; color: #888;'>— QUIZORA Team</p>
                    </body>
                    </html>";

                AlternateView altView = AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");
                message.AlternateViews.Add(altView);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("quizora.examinationsystem@gmail.com", "kpdsbasysbeuqbtx"); // App password
                smtp.EnableSsl = true;
                smtp.Send(message);

                MessageBox.Show("Account email sent successfully!", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email sending failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
