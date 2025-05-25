namespace Quizora
{
    partial class StudentDashboard
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_studentName = new System.Windows.Forms.Label();
            this.lbl_regNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_PaperNum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_questionCount = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_Start = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_viewResults = new Guna.UI2.WinForms.Guna2Button();
            this.lnklbl_logout = new System.Windows.Forms.LinkLabel();
            this.dgv_Results = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Results)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registratuion Number :";
            // 
            // lbl_studentName
            // 
            this.lbl_studentName.AutoSize = true;
            this.lbl_studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_studentName.Location = new System.Drawing.Point(819, 131);
            this.lbl_studentName.Name = "lbl_studentName";
            this.lbl_studentName.Size = new System.Drawing.Size(73, 29);
            this.lbl_studentName.TabIndex = 4;
            this.lbl_studentName.Text = "name";
            // 
            // lbl_regNo
            // 
            this.lbl_regNo.AutoSize = true;
            this.lbl_regNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regNo.Location = new System.Drawing.Point(819, 202);
            this.lbl_regNo.Name = "lbl_regNo";
            this.lbl_regNo.Size = new System.Drawing.Size(95, 29);
            this.lbl_regNo.TabIndex = 5;
            this.lbl_regNo.Text = "number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select Paper Number :";
            // 
            // cmb_PaperNum
            // 
            this.cmb_PaperNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PaperNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PaperNum.ForeColor = System.Drawing.Color.Black;
            this.cmb_PaperNum.FormattingEnabled = true;
            this.cmb_PaperNum.Location = new System.Drawing.Point(550, 64);
            this.cmb_PaperNum.Name = "cmb_PaperNum";
            this.cmb_PaperNum.Size = new System.Drawing.Size(121, 33);
            this.cmb_PaperNum.TabIndex = 7;
            this.cmb_PaperNum.SelectedIndexChanged += new System.EventHandler(this.cmb_PaperNum_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Questions :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Time :";
            // 
            // lbl_questionCount
            // 
            this.lbl_questionCount.AutoSize = true;
            this.lbl_questionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionCount.Location = new System.Drawing.Point(414, 147);
            this.lbl_questionCount.Name = "lbl_questionCount";
            this.lbl_questionCount.Size = new System.Drawing.Size(39, 29);
            this.lbl_questionCount.TabIndex = 10;
            this.lbl_questionCount.Text = "00";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(414, 206);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(39, 29);
            this.lbl_time.TabIndex = 11;
            this.lbl_time.Text = "00";
            // 
            // btn_Start
            // 
            this.btn_Start.BorderRadius = 18;
            this.btn_Start.BorderThickness = 1;
            this.btn_Start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Start.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_Start.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_Start.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Start.HoverState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_Start.Location = new System.Drawing.Point(534, 293);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(180, 45);
            this.btn_Start.TabIndex = 31;
            this.btn_Start.Text = "Start";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Start);
            this.groupBox1.Controls.Add(this.lbl_time);
            this.groupBox1.Controls.Add(this.lbl_questionCount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_PaperNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(417, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 414);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // btn_viewResults
            // 
            this.btn_viewResults.BorderRadius = 18;
            this.btn_viewResults.BorderThickness = 1;
            this.btn_viewResults.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewResults.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewResults.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_viewResults.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_viewResults.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewResults.ForeColor = System.Drawing.Color.White;
            this.btn_viewResults.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_viewResults.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_viewResults.HoverState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_viewResults.Location = new System.Drawing.Point(317, 795);
            this.btn_viewResults.Name = "btn_viewResults";
            this.btn_viewResults.Size = new System.Drawing.Size(186, 45);
            this.btn_viewResults.TabIndex = 33;
            this.btn_viewResults.Text = "View Results";
            this.btn_viewResults.Click += new System.EventHandler(this.btn_viewResults_Click);
            // 
            // lnklbl_logout
            // 
            this.lnklbl_logout.AutoSize = true;
            this.lnklbl_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklbl_logout.Location = new System.Drawing.Point(39, 36);
            this.lnklbl_logout.Name = "lnklbl_logout";
            this.lnklbl_logout.Size = new System.Drawing.Size(82, 25);
            this.lnklbl_logout.TabIndex = 34;
            this.lnklbl_logout.TabStop = true;
            this.lnklbl_logout.Text = "Log Out";
            this.lnklbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_logout_LinkClicked);
            // 
            // dgv_Results
            // 
            this.dgv_Results.AllowUserToAddRows = false;
            this.dgv_Results.AllowUserToDeleteRows = false;
            this.dgv_Results.AllowUserToResizeColumns = false;
            this.dgv_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Results.Location = new System.Drawing.Point(266, 846);
            this.dgv_Results.Name = "dgv_Results";
            this.dgv_Results.ReadOnly = true;
            this.dgv_Results.RowHeadersWidth = 51;
            this.dgv_Results.RowTemplate.Height = 24;
            this.dgv_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Results.Size = new System.Drawing.Size(1328, 281);
            this.dgv_Results.TabIndex = 35;
            this.dgv_Results.Visible = false;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1153);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Results);
            this.Controls.Add(this.lnklbl_logout);
            this.Controls.Add(this.btn_viewResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_regNo);
            this.Controls.Add(this.lbl_studentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_studentName;
        private System.Windows.Forms.Label lbl_regNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_PaperNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_questionCount;
        private System.Windows.Forms.Label lbl_time;
        private Guna.UI2.WinForms.Guna2Button btn_Start;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_viewResults;
        private System.Windows.Forms.LinkLabel lnklbl_logout;
        private System.Windows.Forms.DataGridView dgv_Results;
    }
}