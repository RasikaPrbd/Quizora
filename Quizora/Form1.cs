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
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rpqBhXHwXkZ9TIBo0gf64kJdmUW569Z37FwIEDRK",
            BasePath = "https://quizora-7ef02-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();

            txt_password.PasswordChar = '*';

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            panel1.Visible=false;
            panel2.Visible=false;
            lbl_invalidPass.Visible=false;
            lbl_invalidPassStu.Visible=false;
            groupBox1.Visible=false;
            txt_stuPassword.PasswordChar = '*';


            client = new FireSharp.FirebaseClient(config);

            /* if (client!=null)
            {
                MessageBox.Show("connection is established");
            } */
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

        private void cmb_userType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            if(cmb_userType.SelectedIndex == 0)
            {
                panel1.Visible=false;
                panel2.Visible=true;
                panel2.BringToFront();
                //panel1.SendToBack();
            }
            else if(cmb_userType.SelectedIndex == 1)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel1.BringToFront();
                //panel2.SendToBack();
                //MessageBox.Show("Admin panel visible now"); // ✅ DEBUG

            }
        }

        private void check_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showPass.Checked == true)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }


        private void btn_register_Click(object sender, EventArgs e)
        {
            StudentRegistration studentRegistration = new StudentRegistration();
            studentRegistration.Show();
            this.Hide();
        }

        private async void btn_StuLogin_Click(object sender, EventArgs e)
        {
            string regNo = txt_enroll.Text.Trim();
            string password = txt_stuPassword.Text.Trim();

            if (string.IsNullOrEmpty(regNo) || string.IsNullOrEmpty(password))
            {
                lbl_invalidPassStu.Visible = true;
               // MessageBox.Show("Please fill in both Register Number and Password.");
                return;
            }

            try
            {
                FirebaseResponse res = await client.GetAsync("users/" + regNo);

                if (res.Body == "null")
                {
                    lbl_invalidPassStu.Visible = true;
                  //  MessageBox.Show("Register Number not found.");
                    return;
                }

                User user = res.ResultAs<User>();

                if (user.Password != password)
                {
                    lbl_invalidPassStu.Visible = true;
                  //  MessageBox.Show("Incorrect password.");
                    return;
                }

                if (user.Role != "Student")
                {
                    MessageBox.Show("You are not allowed to access the student dashboard.");
                    return;
                }

                // ✅ Login success
                lbl_invalidPassStu.Visible = false;
                StudentDashboard dashboard = new StudentDashboard(user);
                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }

        }

        private void check_showpassStu_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showpassStu.Checked == true)
            {
                txt_stuPassword.PasswordChar = '\0';
            }
            else
            {
                txt_stuPassword.PasswordChar = '*';
            }
        }

        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "admin" && txt_password.Text == "admin")
            {
                lbl_invalidPass.Visible = false;
                Admin_form admin_Form = new Admin_form();
                admin_Form.Show();
                this.Hide();
            }
            else
            {
                lbl_invalidPass.Visible = true;
            }
        }

        private void check_showPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (check_showPass.Checked == true)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }
    }
    
}
