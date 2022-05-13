namespace MegaDeskV1._0_Rush_Lopez
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.BackColor = System.Drawing.Color.Transparent;
            this.lblMaterial.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMaterial.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaterial.Location = new System.Drawing.Point(298, 91);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.lblMaterial.Size = new System.Drawing.Size(81, 27);
            this.lblMaterial.TabIndex = 47;
            this.lblMaterial.Text = "Material";
            this.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbMaterial
            // 
            this.cbMaterial.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.DropDownWidth = 120;
            this.cbMaterial.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cbMaterial.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(407, 89);
            this.cbMaterial.MaxDropDownItems = 5;
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(121, 29);
            this.cbMaterial.TabIndex = 46;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.cbMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchQuotes";
            this.Text = "MegaDeskv2.0: Search Quotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.returnToMenu);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cbMaterial;
    }
}