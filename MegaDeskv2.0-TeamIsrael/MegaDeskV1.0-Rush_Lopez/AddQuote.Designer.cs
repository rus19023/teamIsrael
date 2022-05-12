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
            this.dbMaterial = new System.Windows.Forms.ComboBox();
            this.tbNumDrawers = new System.Windows.Forms.NumericUpDown();
            this.lblRushDays = new System.Windows.Forms.Label();
            this.tbQuoteDate = new System.Windows.Forms.TextBox();
            this.lblQuoteDate = new System.Windows.Forms.Label();
            this.cbRushDays = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWarn = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderValid = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNumDrawers = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblDateQuoted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWarn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveQuote
            // 
            this.btnSaveQuote.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSaveQuote.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSaveQuote.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSaveQuote.Location = new System.Drawing.Point(900, 305);
            this.btnSaveQuote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveQuote.Name = "btnSaveQuote";
            this.btnSaveQuote.Size = new System.Drawing.Size(468, 129);
            this.btnSaveQuote.TabIndex = 30;
            this.btnSaveQuote.Text = "&Save Quote";
            this.btnSaveQuote.UseVisualStyleBackColor = false;
            this.btnSaveQuote.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFirstName.Location = new System.Drawing.Point(150, 95);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblFirstName.Size = new System.Drawing.Size(149, 31);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Client First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbFirstName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tbFirstName.Location = new System.Drawing.Point(430, 100);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(328, 27);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Text = "Enter first name";
            this.tbFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbLastName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbLastName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tbLastName.Location = new System.Drawing.Point(430, 150);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(328, 27);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.Text = "Enter last name";
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLastName.Location = new System.Drawing.Point(150, 145);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblLastName.Size = new System.Drawing.Size(151, 31);
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
            this.lblDepth.Location = new System.Drawing.Point(150, 245);
            this.lblDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblDepth.Size = new System.Drawing.Size(68, 31);
            this.lblDepth.TabIndex = 34;
            this.lblDepth.Text = "Depth";
            this.lblDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDesktopDepth
            // 
            this.tbDesktopDepth.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbDesktopDepth.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbDesktopDepth.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tbDesktopDepth.Location = new System.Drawing.Point(430, 250);
            this.tbDesktopDepth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDesktopDepth.Name = "tbDesktopDepth";
            this.tbDesktopDepth.Size = new System.Drawing.Size(180, 27);
            this.tbDesktopDepth.TabIndex = 4;
            this.tbDesktopDepth.Text = "Enter depth of desktop";
            this.tbDesktopDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDesktopDepth_KeyPress);
            this.tbDesktopDepth.Validating += new System.ComponentModel.CancelEventHandler(this.tbDesktopDepth_Validating);
            // 
            // tbDesktopWidth
            // 
            this.tbDesktopWidth.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbDesktopWidth.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbDesktopWidth.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tbDesktopWidth.Location = new System.Drawing.Point(430, 200);
            this.tbDesktopWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDesktopWidth.Name = "tbDesktopWidth";
            this.tbDesktopWidth.Size = new System.Drawing.Size(180, 27);
            this.tbDesktopWidth.TabIndex = 3;
            this.tbDesktopWidth.Text = "Enter width";
            this.tbDesktopWidth.TextChanged += new System.EventHandler(this.tbWidth_TextChanged);
            this.tbDesktopWidth.Validating += new System.ComponentModel.CancelEventHandler(this.tbWidth_Validating);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblWidth.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblWidth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWidth.Location = new System.Drawing.Point(150, 195);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWidth.Size = new System.Drawing.Size(64, 31);
            this.lblWidth.TabIndex = 33;
            this.lblWidth.Text = "Width";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dbMaterial
            // 
            this.dbMaterial.BackColor = System.Drawing.Color.LemonChiffon;
            this.dbMaterial.DropDownWidth = 120;
            this.dbMaterial.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dbMaterial.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.dbMaterial.FormattingEnabled = true;
            this.dbMaterial.Items.AddRange(new object[] {
            "Oak",
            "Veneer",
            "Rosewood"});
            this.dbMaterial.Location = new System.Drawing.Point(430, 350);
            this.dbMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbMaterial.MaxDropDownItems = 5;
            this.dbMaterial.Name = "dbMaterial";
            this.dbMaterial.Size = new System.Drawing.Size(180, 29);
            this.dbMaterial.TabIndex = 6;
            this.dbMaterial.Text = "enum Material";
            // 
            // tbNumDrawers
            // 
            this.tbNumDrawers.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbNumDrawers.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbNumDrawers.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tbNumDrawers.Location = new System.Drawing.Point(430, 300);
            this.tbNumDrawers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNumDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.tbNumDrawers.Name = "tbNumDrawers";
            this.tbNumDrawers.Size = new System.Drawing.Size(180, 27);
            this.tbNumDrawers.TabIndex = 5;
            // 
            // lblRushDays
            // 
            this.lblRushDays.AutoSize = true;
            this.lblRushDays.BackColor = System.Drawing.Color.Transparent;
            this.lblRushDays.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblRushDays.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblRushDays.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRushDays.Location = new System.Drawing.Point(150, 395);
            this.lblRushDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRushDays.Name = "lblRushDays";
            this.lblRushDays.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblRushDays.Size = new System.Drawing.Size(95, 31);
            this.lblRushDays.TabIndex = 41;
            this.lblRushDays.Text = "Rush Days";
            this.lblRushDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbQuoteDate
            // 
            this.tbQuoteDate.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbQuoteDate.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbQuoteDate.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tbQuoteDate.Location = new System.Drawing.Point(430, 450);
            this.tbQuoteDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbQuoteDate.Name = "tbQuoteDate";
            this.tbQuoteDate.Size = new System.Drawing.Size(180, 27);
            this.tbQuoteDate.TabIndex = 8;
            // 
            // lblQuoteDate
            // 
            this.lblQuoteDate.AutoSize = true;
            this.lblQuoteDate.BackColor = System.Drawing.Color.Transparent;
            this.lblQuoteDate.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblQuoteDate.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblQuoteDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQuoteDate.Location = new System.Drawing.Point(32723, 445);
            this.lblQuoteDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuoteDate.Name = "lblQuoteDate";
            this.lblQuoteDate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblQuoteDate.Size = new System.Drawing.Size(135, 33);
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
            "3",
            "5",
            "7"});
            this.cbRushDays.Location = new System.Drawing.Point(430, 400);
            this.cbRushDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRushDays.MaxDropDownItems = 5;
            this.cbRushDays.Name = "cbRushDays";
            this.cbRushDays.Size = new System.Drawing.Size(180, 29);
            this.cbRushDays.TabIndex = 7;
            this.cbRushDays.Text = "enum Rush";
            this.cbRushDays.ValueMember = "3, 5, 7";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // errorProviderWarn
            // 
            this.errorProviderWarn.ContainerControl = this;
            // 
            // errorProviderValid
            // 
            this.errorProviderValid.ContainerControl = this;
            this.errorProviderValid.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderValid.Icon")));
            // 
            // lblNumDrawers
            // 
            this.lblNumDrawers.AutoSize = true;
            this.lblNumDrawers.BackColor = System.Drawing.Color.Transparent;
            this.lblNumDrawers.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblNumDrawers.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblNumDrawers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNumDrawers.Location = new System.Drawing.Point(150, 295);
            this.lblNumDrawers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumDrawers.Name = "lblNumDrawers";
            this.lblNumDrawers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblNumDrawers.Size = new System.Drawing.Size(167, 31);
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
            this.lblMaterial.Location = new System.Drawing.Point(150, 345);
            this.lblMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblMaterial.Size = new System.Drawing.Size(83, 31);
            this.lblMaterial.TabIndex = 45;
            this.lblMaterial.Text = "Material";
            this.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateQuoted
            // 
            this.lblDateQuoted.AutoSize = true;
            this.lblDateQuoted.BackColor = System.Drawing.Color.Transparent;
            this.lblDateQuoted.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDateQuoted.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblDateQuoted.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDateQuoted.Location = new System.Drawing.Point(150, 445);
            this.lblDateQuoted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateQuoted.Name = "lblDateQuoted";
            this.lblDateQuoted.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblDateQuoted.Size = new System.Drawing.Size(113, 31);
            this.lblDateQuoted.TabIndex = 46;
            this.lblDateQuoted.Text = "Quote Date";
            this.lblDateQuoted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddQuote
            // 
            this.AcceptButton = this.btnSaveQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = global::MegaDeskV1._0_Rush_Lopez.Properties.Resources.addQuote;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.lblDateQuoted);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblNumDrawers);
            this.Controls.Add(this.cbRushDays);
            this.Controls.Add(this.tbQuoteDate);
            this.Controls.Add(this.lblQuoteDate);
            this.Controls.Add(this.lblRushDays);
            this.Controls.Add(this.tbNumDrawers);
            this.Controls.Add(this.dbMaterial);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk: Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbNumDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWarn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValid)).EndInit();
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
        private System.Windows.Forms.ComboBox dbMaterial;
        private System.Windows.Forms.NumericUpDown tbNumDrawers;
        private System.Windows.Forms.Label lblRushDays;
        private System.Windows.Forms.TextBox tbQuoteDate;
        private System.Windows.Forms.Label lblQuoteDate;
        private System.Windows.Forms.ComboBox cbRushDays;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProviderWarn;
        private System.Windows.Forms.ErrorProvider errorProviderValid;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblNumDrawers;
        internal System.Windows.Forms.Label lblDateQuoted;
    }
}