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
            this.lvAllQuotes = new System.Windows.Forms.ListView();
            this.labelViewAllQuotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvAllQuotes
            // 
            this.lvAllQuotes.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvAllQuotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAllQuotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAllQuotes.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.lvAllQuotes.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lvAllQuotes.FullRowSelect = true;
            this.lvAllQuotes.GridLines = true;
            this.lvAllQuotes.HideSelection = false;
            this.lvAllQuotes.Location = new System.Drawing.Point(50, 105);
            this.lvAllQuotes.Margin = new System.Windows.Forms.Padding(4);
            this.lvAllQuotes.MultiSelect = false;
            this.lvAllQuotes.Name = "lvAllQuotes";
            this.lvAllQuotes.ShowItemToolTips = true;
            this.lvAllQuotes.Size = new System.Drawing.Size(1000, 840);
            this.lvAllQuotes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAllQuotes.TabIndex = 0;
            this.lvAllQuotes.UseCompatibleStateImageBehavior = false;
            this.lvAllQuotes.SelectedIndexChanged += new System.EventHandler(this.lvAllQuotes_SelectedIndexChanged);
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
            this.labelViewAllQuotes.Size = new System.Drawing.Size(539, 97);
            this.labelViewAllQuotes.TabIndex = 1;
            this.labelViewAllQuotes.Text = "View All Quotes";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 701);
            this.Controls.Add(this.labelViewAllQuotes);
            this.Controls.Add(this.lvAllQuotes);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.Text = "MegaDeskvw.0: View All Quotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAllQuotes;
        private System.Windows.Forms.Label labelViewAllQuotes;
    }
}