namespace MegaDeskV1._0_Rush_Lopez
{
    partial class ViewAllQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.labelViewAllQuotes = new System.Windows.Forms.Label();
            this.dgvAllQuotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelViewAllQuotes
            // 
            this.labelViewAllQuotes.AutoSize = true;
            this.labelViewAllQuotes.BackColor = System.Drawing.Color.Transparent;
            this.labelViewAllQuotes.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewAllQuotes.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelViewAllQuotes.Location = new System.Drawing.Point(378, 9);
            this.labelViewAllQuotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelViewAllQuotes.Name = "labelViewAllQuotes";
            this.labelViewAllQuotes.Padding = new System.Windows.Forms.Padding(10);
            this.labelViewAllQuotes.Size = new System.Drawing.Size(459, 84);
            this.labelViewAllQuotes.TabIndex = 1;
            this.labelViewAllQuotes.Text = "View All Quotes";
            // 
            // dgvAllQuotes
            // 
            this.dgvAllQuotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllQuotes.Location = new System.Drawing.Point(65, 112);
            this.dgvAllQuotes.Name = "dgvAllQuotes";
            this.dgvAllQuotes.RowHeadersWidth = 51;
            this.dgvAllQuotes.RowTemplate.Height = 24;
            this.dgvAllQuotes.Size = new System.Drawing.Size(1060, 515);
            this.dgvAllQuotes.TabIndex = 2;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.dgvAllQuotes);
            this.Controls.Add(this.labelViewAllQuotes);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAllQuotes";
            this.Text = "MegaDeskvw.0: View All Quotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.returnToMenu);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelViewAllQuotes;
        private System.Windows.Forms.DataGridView dgvAllQuotes;
    }
}