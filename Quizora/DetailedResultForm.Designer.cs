namespace Quizora
{
    partial class DetailedResultForm
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
            this.dgv_detailed = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detailed)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_detailed
            // 
            this.dgv_detailed.AllowUserToAddRows = false;
            this.dgv_detailed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detailed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_detailed.Location = new System.Drawing.Point(0, 0);
            this.dgv_detailed.Name = "dgv_detailed";
            this.dgv_detailed.ReadOnly = true;
            this.dgv_detailed.RowHeadersWidth = 51;
            this.dgv_detailed.RowTemplate.Height = 24;
            this.dgv_detailed.Size = new System.Drawing.Size(1397, 450);
            this.dgv_detailed.TabIndex = 0;
            // 
            // DetailedResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 450);
            this.Controls.Add(this.dgv_detailed);
            this.Name = "DetailedResultForm";
            this.Text = "DetailedResultForm";
            this.Load += new System.EventHandler(this.DetailedResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detailed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_detailed;
    }
}