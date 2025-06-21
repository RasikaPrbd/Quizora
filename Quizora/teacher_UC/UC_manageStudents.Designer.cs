namespace Quizora.teacher_UC
{
    partial class UC_manageStudents
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_manageStudents));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_students = new System.Windows.Forms.DataGridView();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(130, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Students Accounts";
            // 
            // dgv_students
            // 
            this.dgv_students.AllowUserToAddRows = false;
            this.dgv_students.AllowUserToDeleteRows = false;
            this.dgv_students.AllowUserToResizeColumns = false;
            this.dgv_students.AllowUserToResizeRows = false;
            this.dgv_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_students.Location = new System.Drawing.Point(137, 211);
            this.dgv_students.Name = "dgv_students";
            this.dgv_students.ReadOnly = true;
            this.dgv_students.RowHeadersWidth = 51;
            this.dgv_students.RowTemplate.Height = 24;
            this.dgv_students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_students.Size = new System.Drawing.Size(1209, 652);
            this.dgv_students.TabIndex = 3;
            this.dgv_students.SelectionChanged += new System.EventHandler(this.dgv_students_SelectionChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BorderRadius = 18;
            this.btn_add.BorderThickness = 1;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_add.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_add.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_add.Location = new System.Drawing.Point(244, 1003);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(180, 45);
            this.btn_add.TabIndex = 31;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BorderRadius = 18;
            this.btn_edit.BorderThickness = 1;
            this.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_edit.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_edit.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_edit.Location = new System.Drawing.Point(562, 1003);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(180, 45);
            this.btn_edit.TabIndex = 31;
            this.btn_edit.Text = "Edit";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderRadius = 18;
            this.btn_delete.BorderThickness = 1;
            this.btn_delete.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_delete.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_delete.Location = new System.Drawing.Point(1076, 1003);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(180, 45);
            this.btn_delete.TabIndex = 32;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_manageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_students);
            this.Controls.Add(this.label1);
            this.Name = "UC_manageStudents";
            this.Size = new System.Drawing.Size(1507, 1155);
            this.Load += new System.EventHandler(this.UC_manageStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_students;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
