namespace Quizora
{
    partial class Admin_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_manageStudentDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_results = new Guna.UI2.WinForms.Guna2Button();
            this.btn_deleteQues = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updateQues = new Guna.UI2.WinForms.Guna2Button();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addNewQues = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_addQuestToPapers = new Guna.UI2.WinForms.Guna2Button();
            this.uC_studentResults1 = new Quizora.teacher_UC.UC_studentResults();
            this.uC_manageStudents1 = new Quizora.teacher_UC.UC_manageStudents();
            this.uC_viewAndDeleteQuestions1 = new Quizora.teacher_UC.UC_viewAndDeleteQuestions();
            this.uC_updateQuestions1 = new Quizora.teacher_UC.UC_updateQuestions();
            this.uC_addNewQuestion1 = new Quizora.teacher_UC.UC_addNewQuestion();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_AddQuestionsToPapers1 = new Quizora.teacher_UC.UC_AddQuestionsToPapers();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.btn_addQuestToPapers);
            this.panel1.Controls.Add(this.btn_manageStudentDetails);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_results);
            this.panel1.Controls.Add(this.btn_deleteQues);
            this.panel1.Controls.Add(this.btn_updateQues);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_addNewQues);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1156);
            this.panel1.TabIndex = 0;
            // 
            // btn_manageStudentDetails
            // 
            this.btn_manageStudentDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_manageStudentDetails.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_manageStudentDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_manageStudentDetails.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_manageStudentDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_manageStudentDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_manageStudentDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_manageStudentDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_manageStudentDetails.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_manageStudentDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageStudentDetails.ForeColor = System.Drawing.Color.Black;
            this.btn_manageStudentDetails.Location = new System.Drawing.Point(0, 800);
            this.btn_manageStudentDetails.Name = "btn_manageStudentDetails";
            this.btn_manageStudentDetails.Size = new System.Drawing.Size(397, 68);
            this.btn_manageStudentDetails.TabIndex = 10;
            this.btn_manageStudentDetails.Text = "View And Edit Student Details";
            this.btn_manageStudentDetails.Click += new System.EventHandler(this.btn_manageStudentDetails_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_logout.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_logout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_logout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(0, 900);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(397, 68);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click_1);
            // 
            // btn_results
            // 
            this.btn_results.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_results.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_results.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_results.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_results.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_results.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_results.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_results.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_results.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_results.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_results.ForeColor = System.Drawing.Color.Black;
            this.btn_results.Location = new System.Drawing.Point(0, 700);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(397, 68);
            this.btn_results.TabIndex = 8;
            this.btn_results.Text = "Student Results";
            this.btn_results.Click += new System.EventHandler(this.btn_results_Click);
            // 
            // btn_deleteQues
            // 
            this.btn_deleteQues.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_deleteQues.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_deleteQues.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_deleteQues.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_deleteQues.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteQues.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteQues.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deleteQues.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deleteQues.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_deleteQues.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteQues.ForeColor = System.Drawing.Color.Black;
            this.btn_deleteQues.Location = new System.Drawing.Point(0, 600);
            this.btn_deleteQues.Name = "btn_deleteQues";
            this.btn_deleteQues.Size = new System.Drawing.Size(397, 68);
            this.btn_deleteQues.TabIndex = 3;
            this.btn_deleteQues.Text = "View And Delete Questions";
            this.btn_deleteQues.Click += new System.EventHandler(this.btn_deleteQues_Click);
            // 
            // btn_updateQues
            // 
            this.btn_updateQues.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_updateQues.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_updateQues.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_updateQues.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_updateQues.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateQues.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateQues.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_updateQues.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_updateQues.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_updateQues.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateQues.ForeColor = System.Drawing.Color.Black;
            this.btn_updateQues.Location = new System.Drawing.Point(0, 500);
            this.btn_updateQues.Name = "btn_updateQues";
            this.btn_updateQues.Size = new System.Drawing.Size(397, 68);
            this.btn_updateQues.TabIndex = 4;
            this.btn_updateQues.Text = "Update Questions";
            this.btn_updateQues.Click += new System.EventHandler(this.btn_updateQues_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_exit.Location = new System.Drawing.Point(24, 990);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(115, 77);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_addNewQues
            // 
            this.btn_addNewQues.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_addNewQues.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_addNewQues.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_addNewQues.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_addNewQues.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addNewQues.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addNewQues.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addNewQues.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addNewQues.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_addNewQues.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNewQues.ForeColor = System.Drawing.Color.Black;
            this.btn_addNewQues.Location = new System.Drawing.Point(0, 300);
            this.btn_addNewQues.Name = "btn_addNewQues";
            this.btn_addNewQues.Size = new System.Drawing.Size(397, 68);
            this.btn_addNewQues.TabIndex = 2;
            this.btn_addNewQues.Text = "Add New Papers";
            this.btn_addNewQues.Click += new System.EventHandler(this.btn_addNewQues_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_AddQuestionsToPapers1);
            this.panel2.Controls.Add(this.uC_studentResults1);
            this.panel2.Controls.Add(this.uC_manageStudents1);
            this.panel2.Controls.Add(this.uC_viewAndDeleteQuestions1);
            this.panel2.Controls.Add(this.uC_updateQuestions1);
            this.panel2.Controls.Add(this.uC_addNewQuestion1);
            this.panel2.Location = new System.Drawing.Point(395, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1507, 1155);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // btn_addQuestToPapers
            // 
            this.btn_addQuestToPapers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_addQuestToPapers.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_addQuestToPapers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_addQuestToPapers.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_addQuestToPapers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addQuestToPapers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addQuestToPapers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addQuestToPapers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addQuestToPapers.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_addQuestToPapers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addQuestToPapers.ForeColor = System.Drawing.Color.Black;
            this.btn_addQuestToPapers.Location = new System.Drawing.Point(0, 400);
            this.btn_addQuestToPapers.Name = "btn_addQuestToPapers";
            this.btn_addQuestToPapers.Size = new System.Drawing.Size(397, 68);
            this.btn_addQuestToPapers.TabIndex = 11;
            this.btn_addQuestToPapers.Text = "Add Questions to Papers";
            this.btn_addQuestToPapers.Click += new System.EventHandler(this.btn_addQuestToPapers_Click);
            // 
            // uC_studentResults1
            // 
            this.uC_studentResults1.Location = new System.Drawing.Point(0, 0);
            this.uC_studentResults1.Name = "uC_studentResults1";
            this.uC_studentResults1.Size = new System.Drawing.Size(1507, 1155);
            this.uC_studentResults1.TabIndex = 4;
            // 
            // uC_manageStudents1
            // 
            this.uC_manageStudents1.Location = new System.Drawing.Point(0, 0);
            this.uC_manageStudents1.Name = "uC_manageStudents1";
            this.uC_manageStudents1.Size = new System.Drawing.Size(1507, 1155);
            this.uC_manageStudents1.TabIndex = 3;
            // 
            // uC_viewAndDeleteQuestions1
            // 
            this.uC_viewAndDeleteQuestions1.Location = new System.Drawing.Point(0, 0);
            this.uC_viewAndDeleteQuestions1.Name = "uC_viewAndDeleteQuestions1";
            this.uC_viewAndDeleteQuestions1.Size = new System.Drawing.Size(1507, 1155);
            this.uC_viewAndDeleteQuestions1.TabIndex = 2;
            this.uC_viewAndDeleteQuestions1.Load += new System.EventHandler(this.uC_viewAndDeleteQuestions1_Load);
            // 
            // uC_updateQuestions1
            // 
            this.uC_updateQuestions1.BackColor = System.Drawing.Color.White;
            this.uC_updateQuestions1.Location = new System.Drawing.Point(0, 0);
            this.uC_updateQuestions1.Name = "uC_updateQuestions1";
            this.uC_updateQuestions1.Size = new System.Drawing.Size(1511, 1155);
            this.uC_updateQuestions1.TabIndex = 1;
            this.uC_updateQuestions1.Load += new System.EventHandler(this.uC_updateQuestions1_Load);
            // 
            // uC_addNewQuestion1
            // 
            this.uC_addNewQuestion1.BackColor = System.Drawing.Color.White;
            this.uC_addNewQuestion1.Location = new System.Drawing.Point(3, 0);
            this.uC_addNewQuestion1.Name = "uC_addNewQuestion1";
            this.uC_addNewQuestion1.Size = new System.Drawing.Size(1507, 1155);
            this.uC_addNewQuestion1.TabIndex = 0;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // uC_AddQuestionsToPapers1
            // 
            this.uC_AddQuestionsToPapers1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddQuestionsToPapers1.Name = "uC_AddQuestionsToPapers1";
            this.uC_AddQuestionsToPapers1.Size = new System.Drawing.Size(1507, 1155);
            this.uC_AddQuestionsToPapers1.TabIndex = 5;
            // 
            // Admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1153);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_form";
            this.Load += new System.EventHandler(this.Admin_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private teacher_UC.UC_addNewQuestion uC_addNewQuestion1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private teacher_UC.UC_updateQuestions uC_updateQuestions1;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_addNewQues;
        private Guna.UI2.WinForms.Guna2Button btn_updateQues;
        private Guna.UI2.WinForms.Guna2Button btn_deleteQues;
        private Guna.UI2.WinForms.Guna2Button btn_results;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private teacher_UC.UC_viewAndDeleteQuestions uC_viewAndDeleteQuestions1;
        private Guna.UI2.WinForms.Guna2Button btn_manageStudentDetails;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private teacher_UC.UC_manageStudents uC_manageStudents1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private teacher_UC.UC_studentResults uC_studentResults1;
        private Guna.UI2.WinForms.Guna2Button btn_addQuestToPapers;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private teacher_UC.UC_AddQuestionsToPapers uC_AddQuestionsToPapers1;
    }
}