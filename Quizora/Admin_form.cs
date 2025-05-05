using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizora
{
    public partial class Admin_form : Form
    {
        public Admin_form()
        {
            InitializeComponent();
        }

        private void Admin_form_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            uC_addNewQuestion1.Visible = false;
            uC_updateQuestions1.Visible = false; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AddNewQuestion_Click(object sender, EventArgs e)
        {
            uC_addNewQuestion1.Visible=true;
            uC_addNewQuestion1.BringToFront();
        }

        private void btn_updateQuestion_Click(object sender, EventArgs e)
        {
            uC_updateQuestions1.Visible=true;
            uC_updateQuestions1.BringToFront();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void uC_updateQuestions1_Load(object sender, EventArgs e)
        {

        }

        private void btn_deleteQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
