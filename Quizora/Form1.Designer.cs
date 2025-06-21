namespace Quizora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_userType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_invalidPass = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.check_showPass = new System.Windows.Forms.CheckBox();
            this.btn_AdminLogin = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.check_showpassStu = new System.Windows.Forms.CheckBox();
            this.btn_register = new Guna.UI2.WinForms.Guna2Button();
            this.btn_StuLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txt_stuPassword = new System.Windows.Forms.TextBox();
            this.lbl_invalidPassStu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_enroll = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(619, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select User Type";
            // 
            // cmb_userType
            // 
            this.cmb_userType.BackColor = System.Drawing.SystemColors.Info;
            this.cmb_userType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_userType.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_userType.ForeColor = System.Drawing.Color.Black;
            this.cmb_userType.FormattingEnabled = true;
            this.cmb_userType.Items.AddRange(new object[] {
            "Student",
            "Admin"});
            this.cmb_userType.Location = new System.Drawing.Point(1091, 381);
            this.cmb_userType.Name = "cmb_userType";
            this.cmb_userType.Size = new System.Drawing.Size(225, 45);
            this.cmb_userType.TabIndex = 2;
            this.cmb_userType.SelectedIndexChanged += new System.EventHandler(this.cmb_userType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(156, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Admin Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(79, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // lbl_invalidPass
            // 
            this.lbl_invalidPass.AutoSize = true;
            this.lbl_invalidPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invalidPass.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalidPass.Location = new System.Drawing.Point(115, 460);
            this.lbl_invalidPass.Name = "lbl_invalidPass";
            this.lbl_invalidPass.Size = new System.Drawing.Size(232, 20);
            this.lbl_invalidPass.TabIndex = 3;
            this.lbl_invalidPass.Text = "Invalid username or password";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(84, 186);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(340, 30);
            this.txt_name.TabIndex = 4;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Location = new System.Drawing.Point(84, 301);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(340, 30);
            this.txt_password.TabIndex = 5;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // check_showPass
            // 
            this.check_showPass.AutoSize = true;
            this.check_showPass.ForeColor = System.Drawing.Color.White;
            this.check_showPass.Location = new System.Drawing.Point(104, 339);
            this.check_showPass.Name = "check_showPass";
            this.check_showPass.Size = new System.Drawing.Size(125, 20);
            this.check_showPass.TabIndex = 7;
            this.check_showPass.Text = "Show Password";
            this.check_showPass.UseVisualStyleBackColor = true;
            this.check_showPass.CheckedChanged += new System.EventHandler(this.check_showPass_CheckedChanged_1);
            // 
            // btn_AdminLogin
            // 
            this.btn_AdminLogin.BorderRadius = 18;
            this.btn_AdminLogin.BorderThickness = 1;
            this.btn_AdminLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AdminLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AdminLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AdminLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AdminLogin.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_AdminLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminLogin.ForeColor = System.Drawing.Color.White;
            this.btn_AdminLogin.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_AdminLogin.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_AdminLogin.HoverState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_AdminLogin.Location = new System.Drawing.Point(137, 389);
            this.btn_AdminLogin.Name = "btn_AdminLogin";
            this.btn_AdminLogin.Size = new System.Drawing.Size(180, 45);
            this.btn_AdminLogin.TabIndex = 31;
            this.btn_AdminLogin.Text = "Login";
            this.btn_AdminLogin.Click += new System.EventHandler(this.btn_AdminLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_AdminLogin);
            this.panel1.Controls.Add(this.check_showPass);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.lbl_invalidPass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(17, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 490);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.check_showpassStu);
            this.panel2.Controls.Add(this.btn_register);
            this.panel2.Controls.Add(this.btn_StuLogin);
            this.panel2.Controls.Add(this.txt_stuPassword);
            this.panel2.Controls.Add(this.lbl_invalidPassStu);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_enroll);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(855, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 512);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // check_showpassStu
            // 
            this.check_showpassStu.AutoSize = true;
            this.check_showpassStu.ForeColor = System.Drawing.Color.White;
            this.check_showpassStu.Location = new System.Drawing.Point(102, 329);
            this.check_showpassStu.Name = "check_showpassStu";
            this.check_showpassStu.Size = new System.Drawing.Size(125, 20);
            this.check_showpassStu.TabIndex = 31;
            this.check_showpassStu.Text = "Show Password";
            this.check_showpassStu.UseVisualStyleBackColor = true;
            this.check_showpassStu.CheckedChanged += new System.EventHandler(this.check_showpassStu_CheckedChanged);
            // 
            // btn_register
            // 
            this.btn_register.BorderRadius = 18;
            this.btn_register.BorderThickness = 1;
            this.btn_register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_register.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_register.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_register.Location = new System.Drawing.Point(130, 462);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(180, 45);
            this.btn_register.TabIndex = 30;
            this.btn_register.Text = "Register";
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_StuLogin
            // 
            this.btn_StuLogin.BorderRadius = 18;
            this.btn_StuLogin.BorderThickness = 1;
            this.btn_StuLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_StuLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_StuLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_StuLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_StuLogin.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_StuLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StuLogin.ForeColor = System.Drawing.Color.White;
            this.btn_StuLogin.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_StuLogin.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_StuLogin.HoverState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_StuLogin.Location = new System.Drawing.Point(130, 353);
            this.btn_StuLogin.Name = "btn_StuLogin";
            this.btn_StuLogin.Size = new System.Drawing.Size(180, 45);
            this.btn_StuLogin.TabIndex = 30;
            this.btn_StuLogin.Text = "Login";
            this.btn_StuLogin.Click += new System.EventHandler(this.btn_StuLogin_Click);
            // 
            // txt_stuPassword
            // 
            this.txt_stuPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stuPassword.ForeColor = System.Drawing.Color.Black;
            this.txt_stuPassword.Location = new System.Drawing.Point(84, 293);
            this.txt_stuPassword.Name = "txt_stuPassword";
            this.txt_stuPassword.Size = new System.Drawing.Size(340, 30);
            this.txt_stuPassword.TabIndex = 5;
            this.txt_stuPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_stuPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_stuPassword_KeyDown);
            // 
            // lbl_invalidPassStu
            // 
            this.lbl_invalidPassStu.AutoSize = true;
            this.lbl_invalidPassStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invalidPassStu.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalidPassStu.Location = new System.Drawing.Point(110, 403);
            this.lbl_invalidPassStu.Name = "lbl_invalidPassStu";
            this.lbl_invalidPassStu.Size = new System.Drawing.Size(232, 20);
            this.lbl_invalidPassStu.TabIndex = 3;
            this.lbl_invalidPassStu.Text = "Invalid username or password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(69, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Don\'t have an account?";
            // 
            // txt_enroll
            // 
            this.txt_enroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enroll.ForeColor = System.Drawing.Color.Black;
            this.txt_enroll.Location = new System.Drawing.Point(84, 191);
            this.txt_enroll.Name = "txt_enroll";
            this.txt_enroll.Size = new System.Drawing.Size(340, 30);
            this.txt_enroll.TabIndex = 4;
            this.txt_enroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_enroll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_enroll_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(79, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(79, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Student Registration No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(135, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Student Login";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(815, 519);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 552);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_exit.Location = new System.Drawing.Point(1680, -80);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(115, 77);
            this.btn_exit.TabIndex = 36;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1200);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmb_userType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_userType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_invalidPass;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.CheckBox check_showPass;
        private Guna.UI2.WinForms.Guna2Button btn_AdminLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox check_showpassStu;
        private Guna.UI2.WinForms.Guna2Button btn_register;
        private Guna.UI2.WinForms.Guna2Button btn_StuLogin;
        private System.Windows.Forms.TextBox txt_stuPassword;
        private System.Windows.Forms.Label lbl_invalidPassStu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_enroll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
    }
}

