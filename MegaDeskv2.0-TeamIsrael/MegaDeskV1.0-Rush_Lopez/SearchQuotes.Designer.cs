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
            this.searchQuoteButton = new System.Windows.Forms.Button();
            this.quoteSearchResults = new System.Windows.Forms.DataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushOptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quoteSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.BackColor = System.Drawing.Color.Transparent;
            this.lblMaterial.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMaterial.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaterial.Location = new System.Drawing.Point(316, 42);
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
            this.cbMaterial.Location = new System.Drawing.Point(425, 40);
            this.cbMaterial.MaxDropDownItems = 5;
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(121, 29);
            this.cbMaterial.TabIndex = 46;
            // 
            // searchQuoteButton
            // 
            this.searchQuoteButton.AllowDrop = true;
            this.searchQuoteButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.searchQuoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchQuoteButton.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.searchQuoteButton.Location = new System.Drawing.Point(343, 89);
            this.searchQuoteButton.Name = "searchQuoteButton";
            this.searchQuoteButton.Size = new System.Drawing.Size(177, 47);
            this.searchQuoteButton.TabIndex = 48;
            this.searchQuoteButton.Text = "Search";
            this.searchQuoteButton.UseVisualStyleBackColor = false;
            this.searchQuoteButton.Click += new System.EventHandler(this.searchQuoteButton_Click);
            // 
            // quoteSearchResults
            // 
            this.quoteSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quoteSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.quoteDate,
            this.width,
            this.depth,
            this.drawers,
            this.surfaceMaterial,
            this.rushOptions,
            this.totalPrice});
            this.quoteSearchResults.Location = new System.Drawing.Point(48, 210);
            this.quoteSearchResults.Name = "quoteSearchResults";
            this.quoteSearchResults.Size = new System.Drawing.Size(840, 150);
            this.quoteSearchResults.TabIndex = 49;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Name";
            this.customerName.Name = "customerName";
            // 
            // quoteDate
            // 
            this.quoteDate.HeaderText = "Date";
            this.quoteDate.Name = "quoteDate";
            // 
            // width
            // 
            this.width.HeaderText = "Width";
            this.width.Name = "width";
            // 
            // depth
            // 
            this.depth.HeaderText = "depth";
            this.depth.Name = "depth";
            // 
            // drawers
            // 
            this.drawers.HeaderText = "Number of Drawers";
            this.drawers.Name = "drawers";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.HeaderText = "Material";
            this.surfaceMaterial.Name = "surfaceMaterial";
            // 
            // rushOptions
            // 
            this.rushOptions.HeaderText = "Rush Option";
            this.rushOptions.Name = "rushOptions";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total";
            this.totalPrice.Name = "totalPrice";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.quoteSearchResults);
            this.Controls.Add(this.searchQuoteButton);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.cbMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchQuotes";
            this.Text = "MegaDeskv2.0: Search Quotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.returnToMenu);
            ((System.ComponentModel.ISupportInitialize)(this.quoteSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Button searchQuoteButton;
        private System.Windows.Forms.DataGridView quoteSearchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
    }
}