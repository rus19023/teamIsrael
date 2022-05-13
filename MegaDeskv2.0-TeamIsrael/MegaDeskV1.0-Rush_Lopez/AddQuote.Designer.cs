namespace MegaDeskV1._0_Rush_Lopez
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.btnSaveQuote = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.tbDesktopDepth = new System.Windows.Forms.TextBox();
            this.tbDesktopWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.lblRushDays = new System.Windows.Forms.Label();
            this.lblQuoteDate = new System.Windows.Forms.Label();
            this.cbRushDays = new System.Windows.Forms.ComboBox();
            this.lblNumDrawers = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cbDrawers = new System.Windows.Forms.ComboBox();
            this.errProviderWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderDepth = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveQuote
            // 
            this.btnSaveQuote.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSaveQuote.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSaveQuote.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSaveQuote.Location = new System.Drawing.Point(600, 198);
            this.btnSaveQuote.Name = "btnSaveQuote";
            this.btnSaveQuote.Size = new System.Drawing.Size(312, 84);
            this.btnSaveQuote.TabIndex = 30;
            this.btnSaveQuote.Text = "&Save Quote";
            this.btnSaveQuote.UseVisualStyleBackColor = false;
            this.btnSaveQuote.Click += new System.EventHandler(this.saveQuote);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFirstName.Location = new System.Drawing.Point(100, 62);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblFirstName.Size = new System.Drawing.Size(147, 27);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Client First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbFirstName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tbFirstName.Location = new System.Drawing.Point(286, 65);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(220, 27);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Text = "Doris";
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            this.tbFirstName.Enter += new System.EventHandler(this.textboxEnter);
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbLastName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbLastName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tbLastName.Location = new System.Drawing.Point(286, 98);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(220, 27);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.Text = "Rush-Lopez";
            this.tbLastName.Enter += new System.EventHandler(this.textboxEnter);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLastName.Location = new System.Drawing.Point(100, 94);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblLastName.Size = new System.Drawing.Size(149, 27);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Client Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.BackColor = System.Drawing.Color.Transparent;
            this.lblDepth.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDepth.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblDepth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDepth.Location = new System.Drawing.Point(100, 159);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblDepth.Size = new System.Drawing.Size(66, 27);
            this.lblDepth.TabIndex = 34;
            this.lblDepth.Text = "Depth";
            this.lblDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDesktopDepth
            // 
            this.tbDesktopDepth.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbDesktopDepth.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbDesktopDepth.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tbDesktopDepth.Location = new System.Drawing.Point(286, 162);
            this.tbDesktopDepth.Name = "tbDesktopDepth";
            this.tbDesktopDepth.Size = new System.Drawing.Size(121, 27);
            this.tbDesktopDepth.TabIndex = 4;
            this.tbDesktopDepth.Text = "24";
            this.tbDesktopDepth.Enter += new System.EventHandler(this.textboxEnter);
            this.tbDesktopDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthKeyPress);
            this.tbDesktopDepth.Validating += new System.ComponentModel.CancelEventHandler(this.depthValidating);
            this.tbDesktopDepth.Validated += new System.EventHandler(this.depthValidated);
            // 
            // tbDesktopWidth
            // 
            this.tbDesktopWidth.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbDesktopWidth.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbDesktopWidth.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tbDesktopWidth.Location = new System.Drawing.Point(286, 130);
            this.tbDesktopWidth.Name = "tbDesktopWidth";
            this.tbDesktopWidth.Size = new System.Drawing.Size(121, 27);
            this.tbDesktopWidth.TabIndex = 3;
            this.tbDesktopWidth.Text = "48";
            this.tbDesktopWidth.Enter += new System.EventHandler(this.textboxEnter);
            this.tbDesktopWidth.Validating += new System.ComponentModel.CancelEventHandler(this.widthValidating);
            this.tbDesktopWidth.Validated += new System.EventHandler(this.widthValidated);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblWidth.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblWidth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWidth.Location = new System.Drawing.Point(100, 127);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblWidth.Size = new System.Drawing.Size(62, 27);
            this.lblWidth.TabIndex = 33;
            this.lblWidth.Text = "Width";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbMaterial
            // 
            this.cbMaterial.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.DropDownWidth = 120;
            this.cbMaterial.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cbMaterial.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(286, 228);
            this.cbMaterial.MaxDropDownItems = 5;
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(121, 29);
            this.cbMaterial.TabIndex = 6;
            // 
            // lblRushDays
            // 
            this.lblRushDays.AutoSize = true;
            this.lblRushDays.BackColor = System.Drawing.Color.Transparent;
            this.lblRushDays.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblRushDays.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblRushDays.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRushDays.Location = new System.Drawing.Point(100, 257);
            this.lblRushDays.Name = "lblRushDays";
            this.lblRushDays.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblRushDays.Size = new System.Drawing.Size(93, 27);
            this.lblRushDays.TabIndex = 41;
            this.lblRushDays.Text = "Rush Days";
            this.lblRushDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuoteDate
            // 
            this.lblQuoteDate.AutoSize = true;
            this.lblQuoteDate.BackColor = System.Drawing.Color.Transparent;
            this.lblQuoteDate.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblQuoteDate.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblQuoteDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQuoteDate.Location = new System.Drawing.Point(21815, 289);
            this.lblQuoteDate.Name = "lblQuoteDate";
            this.lblQuoteDate.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblQuoteDate.Size = new System.Drawing.Size(133, 29);
            this.lblQuoteDate.TabIndex = 43;
            this.lblQuoteDate.Text = "Quote Date";
            this.lblQuoteDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbRushDays
            // 
            this.cbRushDays.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbRushDays.DisplayMember = "3, 5, 7";
            this.cbRushDays.DropDownWidth = 120;
            this.cbRushDays.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cbRushDays.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cbRushDays.FormattingEnabled = true;
            this.cbRushDays.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.cbRushDays.Location = new System.Drawing.Point(286, 260);
            this.cbRushDays.MaxDropDownItems = 5;
            this.cbRushDays.Name = "cbRushDays";
            this.cbRushDays.Size = new System.Drawing.Size(121, 29);
            this.cbRushDays.TabIndex = 7;
            this.cbRushDays.Text = "7";
            // 
            // lblNumDrawers
            // 
            this.lblNumDrawers.AutoSize = true;
            this.lblNumDrawers.BackColor = System.Drawing.Color.Transparent;
            this.lblNumDrawers.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblNumDrawers.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblNumDrawers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNumDrawers.Location = new System.Drawing.Point(100, 192);
            this.lblNumDrawers.Name = "lblNumDrawers";
            this.lblNumDrawers.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblNumDrawers.Size = new System.Drawing.Size(165, 27);
            this.lblNumDrawers.TabIndex = 44;
            this.lblNumDrawers.Text = "Number of Drawers";
            this.lblNumDrawers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.BackColor = System.Drawing.Color.Transparent;
            this.lblMaterial.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMaterial.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaterial.Location = new System.Drawing.Point(100, 224);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblMaterial.Size = new System.Drawing.Size(81, 27);
            this.lblMaterial.TabIndex = 45;
            this.lblMaterial.Text = "Material";
            this.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbDrawers
            // 
            this.cbDrawers.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbDrawers.DropDownWidth = 120;
            this.cbDrawers.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cbDrawers.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cbDrawers.FormattingEnabled = true;
            this.cbDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbDrawers.Location = new System.Drawing.Point(286, 193);
            this.cbDrawers.MaxDropDownItems = 5;
            this.cbDrawers.Name = "cbDrawers";
            this.cbDrawers.Size = new System.Drawing.Size(121, 29);
            this.cbDrawers.TabIndex = 5;
            this.cbDrawers.Text = "3";
            // 
            // errProviderWidth
            // 
            this.errProviderWidth.ContainerControl = this;
            // 
            // errProviderDepth
            // 
            this.errProviderDepth.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AcceptButton = this.btnSaveQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = global::MegaDeskV1._0_Rush_Lopez.Properties.Resources.addQuote;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 548);
            this.Controls.Add(this.cbDrawers);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblNumDrawers);
            this.Controls.Add(this.cbRushDays);
            this.Controls.Add(this.lblQuoteDate);
            this.Controls.Add(this.lblRushDays);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.tbDesktopDepth);
            this.Controls.Add(this.tbDesktopWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnSaveQuote);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDeskv2.0: Add Quote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.returnToMenu);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveQuote;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.TextBox tbDesktopDepth;
        private System.Windows.Forms.TextBox tbDesktopWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label lblRushDays;
        private System.Windows.Forms.Label lblQuoteDate;
        private System.Windows.Forms.ComboBox cbRushDays;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblNumDrawers;
        private System.Windows.Forms.ComboBox cbDrawers;
        private System.Windows.Forms.ErrorProvider errProviderWidth;
        private System.Windows.Forms.ErrorProvider errProviderDepth;
    }
}