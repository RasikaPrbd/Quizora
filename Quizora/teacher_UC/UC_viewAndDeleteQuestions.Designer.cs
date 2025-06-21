namespace Quizora.teacher_UC
{
    partial class UC_viewAndDeleteQuestions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_viewAndDeleteQuestions));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_PaperNum = new System.Windows.Forms.ComboBox();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.dgView_paper = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgView_paper)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(405, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "View and Delete Questions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(132, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paper Number";
            // 
            // cmb_PaperNum
            // 
            this.cmb_PaperNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PaperNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PaperNum.ForeColor = System.Drawing.Color.Black;
            this.cmb_PaperNum.FormattingEnabled = true;
            this.cmb_PaperNum.Location = new System.Drawing.Point(312, 187);
            this.cmb_PaperNum.Name = "cmb_PaperNum";
            this.cmb_PaperNum.Size = new System.Drawing.Size(121, 33);
            this.cmb_PaperNum.TabIndex = 3;
            this.cmb_PaperNum.SelectedIndexChanged += new System.EventHandler(this.cmb_PaperNum_SelectedIndexChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderRadius = 18;
            this.btn_delete.BorderThickness = 1;
            this.btn_delete.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_delete.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_delete.Location = new System.Drawing.Point(1176, 1016);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(180, 45);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgView_paper
            // 
            this.dgView_paper.AllowUserToAddRows = false;
            this.dgView_paper.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgView_paper.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgView_paper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgView_paper.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgView_paper.ColumnHeadersHeight = 4;
            this.dgView_paper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgView_paper.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgView_paper.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgView_paper.Location = new System.Drawing.Point(86, 342);
            this.dgView_paper.Name = "dgView_paper";
            this.dgView_paper.ReadOnly = true;
            this.dgView_paper.RowHeadersVisible = false;
            this.dgView_paper.RowHeadersWidth = 51;
            this.dgView_paper.RowTemplate.Height = 24;
            this.dgView_paper.Size = new System.Drawing.Size(1402, 621);
            this.dgView_paper.TabIndex = 32;
            this.dgView_paper.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgView_paper.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgView_paper.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgView_paper.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgView_paper.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgView_paper.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgView_paper.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgView_paper.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgView_paper.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgView_paper.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView_paper.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgView_paper.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgView_paper.ThemeStyle.HeaderStyle.Height = 4;
            this.dgView_paper.ThemeStyle.ReadOnly = true;
            this.dgView_paper.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgView_paper.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgView_paper.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView_paper.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgView_paper.ThemeStyle.RowsStyle.Height = 24;
            this.dgView_paper.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgView_paper.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_viewAndDeleteQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.dgView_paper);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cmb_PaperNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_viewAndDeleteQuestions";
            this.Size = new System.Drawing.Size(1507, 1155);
            this.Load += new System.EventHandler(this.UC_viewAndDeleteQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView_paper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_PaperNum;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2DataGridView dgView_paper;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
