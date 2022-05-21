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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblMaterial.BackColor = System.Drawing.Color.Transparent;
            this.lblMaterial.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMaterial.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaterial.Location = new System.Drawing.Point(450, 32);
            this.lblMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblMaterial.Size = new System.Drawing.Size(249, 35);
            this.lblMaterial.TabIndex = 47;
            this.lblMaterial.Text = "Choose a Material";
            this.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaterial.Click += new System.EventHandler(this.lblMaterial_Click);
            // 
            // cbMaterial
            // 
            this.cbMaterial.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.DropDownWidth = 120;
            this.cbMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMaterial.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cbMaterial.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(710, 33);
            this.cbMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMaterial.MaxDropDownItems = 5;
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(180, 29);
            this.cbMaterial.TabIndex = 46;
            this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            // 
            // searchQuoteButton
            // 
            this.searchQuoteButton.AllowDrop = true;
            this.searchQuoteButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.searchQuoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchQuoteButton.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.searchQuoteButton.Location = new System.Drawing.Point(572, 582);
            this.searchQuoteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchQuoteButton.Name = "searchQuoteButton";
            this.searchQuoteButton.Size = new System.Drawing.Size(330, 115);
            this.searchQuoteButton.TabIndex = 48;
            this.searchQuoteButton.Text = "Return to Menu";
            this.searchQuoteButton.UseVisualStyleBackColor = false;
            this.searchQuoteButton.Click += new System.EventHandler(this.searchQuoteButton_Click);
            // 
            // quoteSearchResults
            // 
            this.quoteSearchResults.AllowUserToAddRows = false;
            this.quoteSearchResults.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.quoteSearchResults.ColumnHeadersHeight = 34;
            this.quoteSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.quoteDate,
            this.width,
            this.depth,
            this.drawers,
            this.surfaceMaterial,
            this.rushOptions,
            this.totalPrice});
            this.quoteSearchResults.GridColor = System.Drawing.Color.DarkKhaki;
            this.quoteSearchResults.Location = new System.Drawing.Point(183, 85);
            this.quoteSearchResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quoteSearchResults.Name = "quoteSearchResults";
            this.quoteSearchResults.ReadOnly = true;
            this.quoteSearchResults.RowHeadersWidth = 50;
            this.quoteSearchResults.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LemonChiffon;
            this.quoteSearchResults.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteSearchResults.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.quoteSearchResults.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            this.quoteSearchResults.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.quoteSearchResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.quoteSearchResults.Size = new System.Drawing.Size(975, 462);
            this.quoteSearchResults.TabIndex = 2;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.customerName.DefaultCellStyle = dataGridViewCellStyle1;
            this.customerName.HeaderText = "Name";
            this.customerName.MaxInputLength = 30;
            this.customerName.MinimumWidth = 8;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 150;
            // 
            // quoteDate
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.quoteDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.quoteDate.HeaderText = "Date";
            this.quoteDate.MaxInputLength = 12;
            this.quoteDate.MinimumWidth = 8;
            this.quoteDate.Name = "quoteDate";
            this.quoteDate.ReadOnly = true;
            this.quoteDate.Width = 75;
            // 
            // width
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.width.DefaultCellStyle = dataGridViewCellStyle3;
            this.width.HeaderText = "Width";
            this.width.MaxInputLength = 2;
            this.width.MinimumWidth = 8;
            this.width.Name = "width";
            this.width.ReadOnly = true;
            this.width.Width = 50;
            // 
            // depth
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.depth.DefaultCellStyle = dataGridViewCellStyle4;
            this.depth.HeaderText = "Depth";
            this.depth.MaxInputLength = 2;
            this.depth.MinimumWidth = 8;
            this.depth.Name = "depth";
            this.depth.ReadOnly = true;
            this.depth.Width = 50;
            // 
            // drawers
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.drawers.DefaultCellStyle = dataGridViewCellStyle5;
            this.drawers.HeaderText = "# of Drawers";
            this.drawers.MaxInputLength = 2;
            this.drawers.MinimumWidth = 8;
            this.drawers.Name = "drawers";
            this.drawers.ReadOnly = true;
            this.drawers.Width = 50;
            // 
            // surfaceMaterial
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.surfaceMaterial.DefaultCellStyle = dataGridViewCellStyle6;
            this.surfaceMaterial.HeaderText = "Material";
            this.surfaceMaterial.MaxInputLength = 20;
            this.surfaceMaterial.MinimumWidth = 8;
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.ReadOnly = true;
            this.surfaceMaterial.Width = 150;
            // 
            // rushOptions
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.rushOptions.DefaultCellStyle = dataGridViewCellStyle7;
            this.rushOptions.HeaderText = "Rush Option";
            this.rushOptions.MaxInputLength = 10;
            this.rushOptions.MinimumWidth = 8;
            this.rushOptions.Name = "rushOptions";
            this.rushOptions.ReadOnly = true;
            this.rushOptions.Width = 50;
            // 
            // totalPrice
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.totalPrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.totalPrice.HeaderText = "Total";
            this.totalPrice.MaxInputLength = 12;
            this.totalPrice.MinimumWidth = 8;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 75;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1178, 702);
            this.Controls.Add(this.quoteSearchResults);
            this.Controls.Add(this.searchQuoteButton);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.cbMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchQuotes";
            this.Text = "MegaDeskv2.0: Search Quotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.returnToMenu);
            ((System.ComponentModel.ISupportInitialize)(this.quoteSearchResults)).EndInit();
            this.ResumeLayout(false);

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