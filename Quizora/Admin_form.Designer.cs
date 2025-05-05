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
            this.button6 = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_results = new System.Windows.Forms.Button();
            this.btn_deleteQuestion = new System.Windows.Forms.Button();
            this.btn_updateQuestion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AddNewQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_updateQuestions1 = new Quizora.teacher_UC.UC_updateQuestions();
            this.uC_addNewQuestion1 = new Quizora.teacher_UC.UC_addNewQuestion();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_results);
            this.panel1.Controls.Add(this.btn_deleteQuestion);
            this.panel1.Controls.Add(this.btn_updateQuestion);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_AddNewQuestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1156);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(12, 913);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 71);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(0, 725);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(400, 68);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_results
            // 
            this.btn_results.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_results.ForeColor = System.Drawing.Color.Black;
            this.btn_results.Location = new System.Drawing.Point(0, 621);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(400, 68);
            this.btn_results.TabIndex = 5;
            this.btn_results.Text = "Student Results";
            this.btn_results.UseVisualStyleBackColor = true;
            // 
            // btn_deleteQuestion
            // 
            this.btn_deleteQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteQuestion.ForeColor = System.Drawing.Color.Black;
            this.btn_deleteQuestion.Location = new System.Drawing.Point(0, 525);
            this.btn_deleteQuestion.Name = "btn_deleteQuestion";
            this.btn_deleteQuestion.Size = new System.Drawing.Size(400, 68);
            this.btn_deleteQuestion.TabIndex = 4;
            this.btn_deleteQuestion.Text = "View And Delete Questions";
            this.btn_deleteQuestion.UseVisualStyleBackColor = true;
            this.btn_deleteQuestion.Click += new System.EventHandler(this.btn_deleteQuestion_Click);
            // 
            // btn_updateQuestion
            // 
            this.btn_updateQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateQuestion.ForeColor = System.Drawing.Color.Black;
            this.btn_updateQuestion.Location = new System.Drawing.Point(0, 424);
            this.btn_updateQuestion.Name = "btn_updateQuestion";
            this.btn_updateQuestion.Size = new System.Drawing.Size(400, 68);
            this.btn_updateQuestion.TabIndex = 3;
            this.btn_updateQuestion.Text = "Update Questions";
            this.btn_updateQuestion.UseVisualStyleBackColor = true;
            this.btn_updateQuestion.Click += new System.EventHandler(this.btn_updateQuestion_Click);
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
            // btn_AddNewQuestion
            // 
            this.btn_AddNewQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewQuestion.ForeColor = System.Drawing.Color.Black;
            this.btn_AddNewQuestion.Location = new System.Drawing.Point(0, 322);
            this.btn_AddNewQuestion.Name = "btn_AddNewQuestion";
            this.btn_AddNewQuestion.Size = new System.Drawing.Size(397, 68);
            this.btn_AddNewQuestion.TabIndex = 1;
            this.btn_AddNewQuestion.Text = "Add New Questions";
            this.btn_AddNewQuestion.UseVisualStyleBackColor = true;
            this.btn_AddNewQuestion.Click += new System.EventHandler(this.btn_AddNewQuestion_Click);
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
            this.panel2.Controls.Add(this.uC_updateQuestions1);
            this.panel2.Controls.Add(this.uC_addNewQuestion1);
            this.panel2.Location = new System.Drawing.Point(395, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1507, 1155);
            this.panel2.TabIndex = 1;
            // 
            // uC_updateQuestions1
            // 
            this.uC_updateQuestions1.BackColor = System.Drawing.Color.White;
            this.uC_updateQuestions1.Location = new System.Drawing.Point(4, 0);
            this.uC_updateQuestions1.Name = "uC_updateQuestions1";
            this.uC_updateQuestions1.Size = new System.Drawing.Size(1507, 1155);
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
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
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
        private System.Windows.Forms.Button btn_AddNewQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.Button btn_deleteQuestion;
        private System.Windows.Forms.Button btn_updateQuestion;
        private System.Windows.Forms.Button button6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private teacher_UC.UC_addNewQuestion uC_addNewQuestion1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private teacher_UC.UC_updateQuestions uC_updateQuestions1;
    }
}