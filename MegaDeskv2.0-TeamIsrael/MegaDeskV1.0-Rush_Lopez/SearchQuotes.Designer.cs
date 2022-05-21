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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblMaterial.Location = new System.Drawing.Point(300, 20);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblMaterial.Size = new System.Drawing.Size(166, 23);
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
            this.cbMaterial.Location = new System.Drawing.Point(473, 20);
            this.cbMaterial.MaxDropDownItems = 5;
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(121, 29);
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
            this.searchQuoteButton.Location = new System.Drawing.Point(361, 385);
            this.searchQuoteButton.Name = "searchQuoteButton";
            this.searchQuoteButton.Size = new System.Drawing.Size(220, 75);
            this.searchQuoteButton.TabIndex = 48;
            this.searchQuoteButton.Text = "Back to Menu";
            this.searchQuoteButton.UseVisualStyleBackColor = false;
            this.searchQuoteButton.Click += new System.EventHandler(this.searchQuoteButton_Click);
            // 
            // quoteSearchResults
            // 
            this.quoteSearchResults.AllowUserToAddRows = false;
            this.quoteSearchResults.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.quoteSearchResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.quoteSearchResults.BackgroundColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.quoteSearchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.quoteSearchResults.ColumnHeadersHeight = 40;
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
            this.quoteSearchResults.Location = new System.Drawing.Point(123, 64);
            this.quoteSearchResults.Name = "quoteSearchResults";
            this.quoteSearchResults.ReadOnly = true;
            this.quoteSearchResults.RowHeadersWidth = 50;
            this.quoteSearchResults.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LemonChiffon;
            this.quoteSearchResults.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteSearchResults.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.quoteSearchResults.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            this.quoteSearchResults.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.quoteSearchResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.quoteSearchResults.Size = new System.Drawing.Size(695, 300);
            this.quoteSearchResults.TabIndex = 2;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.customerName.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerName.HeaderText = "Name";
            this.customerName.MaxInputLength = 30;
            this.customerName.MinimumWidth = 8;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 150;
            // 
            // quoteDate
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.quoteDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.quoteDate.HeaderText = "Date";
            this.quoteDate.MaxInputLength = 12;
            this.quoteDate.MinimumWidth = 8;
            this.quoteDate.Name = "quoteDate";
            this.quoteDate.ReadOnly = true;
            // 
            // width
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.width.DefaultCellStyle = dataGridViewCellStyle5;
            this.width.HeaderText = "Width";
            this.width.MaxInputLength = 2;
            this.width.MinimumWidth = 8;
            this.width.Name = "width";
            this.width.ReadOnly = true;
            this.width.Width = 50;
            // 
            // depth
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.depth.DefaultCellStyle = dataGridViewCellStyle6;
            this.depth.HeaderText = "Depth";
            this.depth.MaxInputLength = 2;
            this.depth.MinimumWidth = 8;
            this.depth.Name = "depth";
            this.depth.ReadOnly = true;
            this.depth.Width = 50;
            // 
            // drawers
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.drawers.DefaultCellStyle = dataGridViewCellStyle7;
            this.drawers.HeaderText = "# of Drawers";
            this.drawers.MaxInputLength = 2;
            this.drawers.MinimumWidth = 8;
            this.drawers.Name = "drawers";
            this.drawers.ReadOnly = true;
            this.drawers.Width = 70;
            // 
            // surfaceMaterial
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.surfaceMaterial.DefaultCellStyle = dataGridViewCellStyle8;
            this.surfaceMaterial.HeaderText = "Material";
            this.surfaceMaterial.MaxInputLength = 20;
            this.surfaceMaterial.MinimumWidth = 8;
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.ReadOnly = true;
            // 
            // rushOptions
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.rushOptions.DefaultCellStyle = dataGridViewCellStyle9;
            this.rushOptions.HeaderText = "Rush Days";
            this.rushOptions.MaxInputLength = 10;
            this.rushOptions.MinimumWidth = 8;
            this.rushOptions.Name = "rushOptions";
            this.rushOptions.ReadOnly = true;
            this.rushOptions.Width = 50;
            // 
            // totalPrice
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.totalPrice.DefaultCellStyle = dataGridViewCellStyle10;
            this.totalPrice.HeaderText = "Total";
            this.totalPrice.MaxInputLength = 12;
            this.totalPrice.MinimumWidth = 8;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 75;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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