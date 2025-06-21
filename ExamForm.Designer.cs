namespace Quizora
{
    partial class ExamForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Papernum = new System.Windows.Forms.Label();
            this.lbl_regNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_questionNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_totalQuestions = new System.Windows.Forms.Label();
            this.rbtn_option1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lbl_questionText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbtn_option2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtn_option3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtn_option4 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btn_next = new Guna.UI2.WinForms.Guna2Button();
            this.btn_previous = new Guna.UI2.WinForms.Guna2Button();
            this.btn_submit = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.examTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registration Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paper Number :";
            // 
            // lbl_Papernum
            // 
            this.lbl_Papernum.AutoSize = true;
            this.lbl_Papernum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Papernum.Location = new System.Drawing.Point(560, 101);
            this.lbl_Papernum.Name = "lbl_Papernum";
            this.lbl_Papernum.Size = new System.Drawing.Size(52, 29);
            this.lbl_Papernum.TabIndex = 11;
            this.lbl_Papernum.Text = "000";
            // 
            // lbl_regNum
            // 
            this.lbl_regNum.AutoSize = true;
            this.lbl_regNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regNum.Location = new System.Drawing.Point(560, 190);
            this.lbl_regNum.Name = "lbl_regNum";
            this.lbl_regNum.Size = new System.Drawing.Size(52, 29);
            this.lbl_regNum.TabIndex = 12;
            this.lbl_regNum.Text = "000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Question";
            // 
            // lbl_questionNum
            // 
            this.lbl_questionNum.AutoSize = true;
            this.lbl_questionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionNum.Location = new System.Drawing.Point(436, 343);
            this.lbl_questionNum.Name = "lbl_questionNum";
            this.lbl_questionNum.Size = new System.Drawing.Size(39, 29);
            this.lbl_questionNum.TabIndex = 14;
            this.lbl_questionNum.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "of";
            // 
            // lbl_totalQuestions
            // 
            this.lbl_totalQuestions.AutoSize = true;
            this.lbl_totalQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalQuestions.Location = new System.Drawing.Point(509, 343);
            this.lbl_totalQuestions.Name = "lbl_totalQuestions";
            this.lbl_totalQuestions.Size = new System.Drawing.Size(52, 29);
            this.lbl_totalQuestions.TabIndex = 16;
            this.lbl_totalQuestions.Text = "000";
            // 
            // rbtn_option1
            // 
            this.rbtn_option1.AutoSize = true;
            this.rbtn_option1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_option1.CheckedState.BorderThickness = 0;
            this.rbtn_option1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_option1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_option1.CheckedState.InnerOffset = -4;
            this.rbtn_option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_option1.Location = new System.Drawing.Point(418, 599);
            this.rbtn_option1.Name = "rbtn_option1";
            this.rbtn_option1.Size = new System.Drawing.Size(114, 33);
            this.rbtn_option1.TabIndex = 19;
            this.rbtn_option1.Text = "option1";
            this.rbtn_option1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_option1.UncheckedState.BorderThickness = 2;
            this.rbtn_option1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_option1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lbl_questionText
            // 
            this.lbl_questionText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_questionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionText.Location = new System.Drawing.Point(131, 45);
            this.lbl_questionText.Name = "lbl_questionText";
            this.lbl_questionText.Size = new System.Drawing.Size(134, 40);
            this.lbl_questionText.TabIndex = 20;
            this.lbl_questionText.Text = "Question";
            // 
            // rbtn_option2
            // 
            this.rbtn_option2.AutoSize = true;
            this.rbtn_option2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_option2.CheckedState.BorderThickness = 0;
            this.rbtn_option2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_option2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_option2.CheckedState.InnerOffset = -4;
            this.rbtn_option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_option2.Location = new System.Drawing.Point(418, 671);
            this.rbtn_option2.Name = "rbtn_option2";
            this.rbtn_option2.Size = new System.Drawing.Size(114, 33);
            this.rbtn_option2.TabIndex = 19;
            this.rbtn_option2.Text = "option2";
            this.rbtn_option2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_option2.UncheckedState.BorderThickness = 2;
            this.rbtn_option2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_option2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtn_option3
            // 
            this.rbtn_option3.AutoSize = true;
            this.rbtn_option3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_option3.CheckedState.BorderThickness = 0;
            this.rbtn_option3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_option3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_option3.CheckedState.InnerOffset = -4;
            this.rbtn_option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_option3.Location = new System.Drawing.Point(418, 736);
            this.rbtn_option3.Name = "rbtn_option3";
            this.rbtn_option3.Size = new System.Drawing.Size(114, 33);
            this.rbtn_option3.TabIndex = 19;
            this.rbtn_option3.Text = "option3";
            this.rbtn_option3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_option3.UncheckedState.BorderThickness = 2;
            this.rbtn_option3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_option3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtn_option4
            // 
            this.rbtn_option4.AutoSize = true;
            this.rbtn_option4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_option4.CheckedState.BorderThickness = 0;
            this.rbtn_option4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_option4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_option4.CheckedState.InnerOffset = -4;
            this.rbtn_option4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_option4.Location = new System.Drawing.Point(418, 803);
            this.rbtn_option4.Name = "rbtn_option4";
            this.rbtn_option4.Size = new System.Drawing.Size(114, 33);
            this.rbtn_option4.TabIndex = 19;
            this.rbtn_option4.Text = "option4";
            this.rbtn_option4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_option4.UncheckedState.BorderThickness = 2;
            this.rbtn_option4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_option4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btn_next
            // 
            this.btn_next.BorderRadius = 18;
            this.btn_next.BorderThickness = 1;
            this.btn_next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_next.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_next.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_next.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_next.HoverState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_next.Location = new System.Drawing.Point(965, 950);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(180, 45);
            this.btn_next.TabIndex = 32;
            this.btn_next.Text = "Next";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BorderRadius = 18;
            this.btn_previous.BorderThickness = 1;
            this.btn_previous.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_previous.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_previous.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_previous.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_previous.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_previous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_previous.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_previous.HoverState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_previous.Location = new System.Drawing.Point(432, 950);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(180, 45);
            this.btn_previous.TabIndex = 33;
            this.btn_previous.Text = "Previous";
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BorderRadius = 18;
            this.btn_submit.BorderThickness = 1;
            this.btn_submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_submit.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_submit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_submit.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_submit.HoverState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_submit.Location = new System.Drawing.Point(1080, 1074);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(180, 45);
            this.btn_submit.TabIndex = 34;
            this.btn_submit.Text = "Submit";
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1085, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Time Remaining :";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(1335, 344);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(71, 29);
            this.lbl_timer.TabIndex = 36;
            this.lbl_timer.Text = "00:00";
            // 
            // examTimer
            // 
            this.examTimer.Interval = 1000;
            this.examTimer.Tick += new System.EventHandler(this.examTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(206, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 197);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_questionText);
            this.groupBox2.Location = new System.Drawing.Point(206, 461);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1473, 397);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1902, 1153);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.rbtn_option4);
            this.Controls.Add(this.rbtn_option3);
            this.Controls.Add(this.rbtn_option2);
            this.Controls.Add(this.rbtn_option1);
            this.Controls.Add(this.lbl_totalQuestions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_questionNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_regNum);
            this.Controls.Add(this.lbl_Papernum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Papernum;
        private System.Windows.Forms.Label lbl_regNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_questionNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_totalQuestions;
        private Guna.UI2.WinForms.Guna2RadioButton rbtn_option1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_questionText;
        private Guna.UI2.WinForms.Guna2RadioButton rbtn_option2;
        private Guna.UI2.WinForms.Guna2RadioButton rbtn_option3;
        private Guna.UI2.WinForms.Guna2RadioButton rbtn_option4;
        private Guna.UI2.WinForms.Guna2Button btn_next;
        private Guna.UI2.WinForms.Guna2Button btn_previous;
        private Guna.UI2.WinForms.Guna2Button btn_submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Timer examTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}