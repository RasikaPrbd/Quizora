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
            uC_manageStudents1.Visible = false;
            uC_viewAndDeleteQuestions1.Visible = false;
            uC_studentResults1.Visible = false;
            uC_AddQuestionsToPapers1.Visible = false;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void uC_updateQuestions1_Load(object sender, EventArgs e)
        {

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

        private void btn_addNewQues_Click(object sender, EventArgs e)
        {
            uC_addNewQuestion1.Visible = true;
            uC_addNewQuestion1.BringToFront();
        }

        private void btn_updateQues_Click(object sender, EventArgs e)
        {
            uC_updateQuestions1.Visible = true;
            uC_updateQuestions1.BringToFront();
        }

        private void btn_deleteQues_Click(object sender, EventArgs e)
        {
            uC_viewAndDeleteQuestions1.Visible = true;
            uC_viewAndDeleteQuestions1.BringToFront();
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                          "Confirm Logout",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                btn_logout.BackColor = Color.LimeGreen;
            }

        }

        private void uC_viewAndDeleteQuestions1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            uC_studentResults1.Visible = true;
            uC_studentResults1.BringToFront();
        }

        private void btn_manageStudentDetails_Click(object sender, EventArgs e)
        {
            uC_manageStudents1.Visible = true;
            uC_manageStudents1.BringToFront();
        }

        private void btn_addQuestToPapers_Click(object sender, EventArgs e)
        {
            uC_AddQuestionsToPapers1.Visible = true;
            uC_AddQuestionsToPapers1.BringToFront();
        }
    }
}
