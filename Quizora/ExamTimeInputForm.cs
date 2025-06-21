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
    public partial class ExamTimeInputForm : Form
    {
        public string EnteredTime => txt_duration.Text.Trim();

        public ExamTimeInputForm()
        {
            InitializeComponent();
            this.AcceptButton = btn_ok;
            this.CancelButton = btn_cancel;
        }


        private void ExamTimeInputForm_Load(object sender, EventArgs e)
        {
            txt_duration.Focus();
        }

        private void txt_Duration_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_duration.Text))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid time.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
