namespace Quizora.teacher_UC
{
    partial class UC_studentResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_studentResults));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_searchRegNo = new System.Windows.Forms.TextBox();
            this.cmb_filterPaper = new System.Windows.Forms.ComboBox();
            this.dgv_results = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clearFilters = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_results)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(122, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by Register No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(122, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filter by Paper No :";
            // 
            // txt_searchRegNo
            // 
            this.txt_searchRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchRegNo.ForeColor = System.Drawing.Color.Black;
            this.txt_searchRegNo.Location = new System.Drawing.Point(378, 184);
            this.txt_searchRegNo.Name = "txt_searchRegNo";
            this.txt_searchRegNo.Size = new System.Drawing.Size(121, 30);
            this.txt_searchRegNo.TabIndex = 16;
            this.txt_searchRegNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_filterPaper
            // 
            this.cmb_filterPaper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filterPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_filterPaper.ForeColor = System.Drawing.Color.Black;
            this.cmb_filterPaper.FormattingEnabled = true;
            this.cmb_filterPaper.Location = new System.Drawing.Point(378, 257);
            this.cmb_filterPaper.Name = "cmb_filterPaper";
            this.cmb_filterPaper.Size = new System.Drawing.Size(121, 33);
            this.cmb_filterPaper.TabIndex = 17;
            // 
            // dgv_results
            // 
            this.dgv_results.AllowUserToAddRows = false;
            this.dgv_results.AllowUserToDeleteRows = false;
            this.dgv_results.AllowUserToResizeColumns = false;
            this.dgv_results.AllowUserToResizeRows = false;
            this.dgv_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_results.Location = new System.Drawing.Point(149, 361);
            this.dgv_results.Name = "dgv_results";
            this.dgv_results.ReadOnly = true;
            this.dgv_results.RowHeadersWidth = 51;
            this.dgv_results.RowTemplate.Height = 24;
            this.dgv_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_results.Size = new System.Drawing.Size(1326, 599);
            this.dgv_results.TabIndex = 33;
            this.dgv_results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_results_CellContentClick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BorderRadius = 18;
            this.btn_Search.BorderThickness = 1;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Search.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_Search.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Search.HoverState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_Search.Location = new System.Drawing.Point(589, 228);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(180, 45);
            this.btn_Search.TabIndex = 32;
            this.btn_Search.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_clearFilters
            // 
            this.btn_clearFilters.BackColor = System.Drawing.Color.Transparent;
            this.btn_clearFilters.BorderColor = System.Drawing.Color.Transparent;
            this.btn_clearFilters.BorderRadius = 18;
            this.btn_clearFilters.BorderThickness = 1;
            this.btn_clearFilters.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clearFilters.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clearFilters.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clearFilters.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clearFilters.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_clearFilters.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearFilters.ForeColor = System.Drawing.Color.White;
            this.btn_clearFilters.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_clearFilters.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_clearFilters.HoverState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_clearFilters.Location = new System.Drawing.Point(1003, 228);
            this.btn_clearFilters.Name = "btn_clearFilters";
            this.btn_clearFilters.Size = new System.Drawing.Size(180, 45);
            this.btn_clearFilters.TabIndex = 34;
            this.btn_clearFilters.Text = "Clear Filters";
            this.btn_clearFilters.Click += new System.EventHandler(this.btn_clearFilters_Click);
            // 
            // UC_studentResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btn_clearFilters);
            this.Controls.Add(this.dgv_results);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cmb_filterPaper);
            this.Controls.Add(this.txt_searchRegNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_studentResults";
            this.Size = new System.Drawing.Size(1507, 1155);
            this.Load += new System.EventHandler(this.UC_studentResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_searchRegNo;
        private System.Windows.Forms.ComboBox cmb_filterPaper;
        private System.Windows.Forms.DataGridView dgv_results;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_clearFilters;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
    }
}
