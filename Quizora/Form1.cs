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

            client = new FireSharp.FirebaseClient(config);

            /* if (client!=null)
            {
                MessageBox.Show("connection is established");
            } */
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmb_userType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_userType.SelectedIndex == 0)
            {
                panel1.Visible=false;
                panel2.Visible=true;
            }
            else if(cmb_userType.SelectedIndex == 1)
            {
                panel1.Visible = true;
                panel2.Visible = false;
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

        private void btn_AdminLogin_Click_1(object sender, EventArgs e)
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
    }
}
