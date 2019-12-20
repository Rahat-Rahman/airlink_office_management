namespace Airlink
{
    partial class ExportReqInfo
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
            this.PBStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnRequest = new MetroFramework.Controls.MetroButton();
            this.txtParcelType = new MetroFramework.Controls.MetroTextBox();
            this.txtRContact = new MetroFramework.Controls.MetroTextBox();
            this.txtRAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtRName = new MetroFramework.Controls.MetroTextBox();
            this.txtSContact = new MetroFramework.Controls.MetroTextBox();
            this.txtSAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtSName = new MetroFramework.Controls.MetroTextBox();
            this.lblRContact = new MetroFramework.Controls.MetroLabel();
            this.lblRAddress = new MetroFramework.Controls.MetroLabel();
            this.lblRName = new MetroFramework.Controls.MetroLabel();
            this.lblRTitle = new MetroFramework.Controls.MetroLabel();
            this.lblParcelType = new MetroFramework.Controls.MetroLabel();
            this.lblSContact = new MetroFramework.Controls.MetroLabel();
            this.lblSName = new MetroFramework.Controls.MetroLabel();
            this.lblSender = new MetroFramework.Controls.MetroLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMedium = new MetroFramework.Controls.MetroLabel();
            this.comboMedium = new System.Windows.Forms.ComboBox();
            this.lblSAddress = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerExpReqPage = new System.Windows.Forms.Timer(this.components);
            this.txtRCountry = new MetroFramework.Controls.MetroTextBox();
            this.lblRCountry = new MetroFramework.Controls.MetroLabel();
            this.PBStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBStatus
            // 
            this.PBStatus.AutoSize = false;
            this.PBStatus.BackColor = System.Drawing.Color.White;
            this.PBStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.PBStatus.Location = new System.Drawing.Point(20, 408);
            this.PBStatus.Name = "PBStatus";
            this.PBStatus.Size = new System.Drawing.Size(828, 19);
            this.PBStatus.TabIndex = 72;
            this.PBStatus.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 13);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::Airlink.Properties.Resources.IPvt1Irv1_l9O4W1zIYVyhJVaQILgWSKUjAlna4Dc3Ru1WeJ;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(4, 8);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(98, 90);
            this.metroPanel1.TabIndex = 69;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnRequest
            // 
            this.btnRequest.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRequest.Location = new System.Drawing.Point(633, 275);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(162, 23);
            this.btnRequest.TabIndex = 68;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.UseSelectable = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // txtParcelType
            // 
            // 
            // 
            // 
            this.txtParcelType.CustomButton.Image = null;
            this.txtParcelType.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtParcelType.CustomButton.Name = "";
            this.txtParcelType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtParcelType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtParcelType.CustomButton.TabIndex = 1;
            this.txtParcelType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtParcelType.CustomButton.UseSelectable = true;
            this.txtParcelType.CustomButton.Visible = false;
            this.txtParcelType.Lines = new string[0];
            this.txtParcelType.Location = new System.Drawing.Point(253, 313);
            this.txtParcelType.MaxLength = 32767;
            this.txtParcelType.Name = "txtParcelType";
            this.txtParcelType.PasswordChar = '\0';
            this.txtParcelType.PromptText = "Parcel Type";
            this.txtParcelType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtParcelType.SelectedText = "";
            this.txtParcelType.SelectionLength = 0;
            this.txtParcelType.SelectionStart = 0;
            this.txtParcelType.ShortcutsEnabled = true;
            this.txtParcelType.Size = new System.Drawing.Size(166, 23);
            this.txtParcelType.TabIndex = 67;
            this.txtParcelType.UseSelectable = true;
            this.txtParcelType.WaterMark = "Parcel Type";
            this.txtParcelType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtParcelType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRContact
            // 
            // 
            // 
            // 
            this.txtRContact.CustomButton.Image = null;
            this.txtRContact.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtRContact.CustomButton.Name = "";
            this.txtRContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRContact.CustomButton.TabIndex = 1;
            this.txtRContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRContact.CustomButton.UseSelectable = true;
            this.txtRContact.CustomButton.Visible = false;
            this.txtRContact.Lines = new string[0];
            this.txtRContact.Location = new System.Drawing.Point(203, 223);
            this.txtRContact.MaxLength = 32767;
            this.txtRContact.Name = "txtRContact";
            this.txtRContact.PasswordChar = '\0';
            this.txtRContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRContact.SelectedText = "";
            this.txtRContact.SelectionLength = 0;
            this.txtRContact.SelectionStart = 0;
            this.txtRContact.ShortcutsEnabled = true;
            this.txtRContact.Size = new System.Drawing.Size(188, 23);
            this.txtRContact.TabIndex = 66;
            this.txtRContact.UseSelectable = true;
            this.txtRContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRAddress
            // 
            // 
            // 
            // 
            this.txtRAddress.CustomButton.Image = null;
            this.txtRAddress.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtRAddress.CustomButton.Name = "";
            this.txtRAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRAddress.CustomButton.TabIndex = 1;
            this.txtRAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRAddress.CustomButton.UseSelectable = true;
            this.txtRAddress.CustomButton.Visible = false;
            this.txtRAddress.Lines = new string[0];
            this.txtRAddress.Location = new System.Drawing.Point(203, 190);
            this.txtRAddress.MaxLength = 32767;
            this.txtRAddress.Name = "txtRAddress";
            this.txtRAddress.PasswordChar = '\0';
            this.txtRAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRAddress.SelectedText = "";
            this.txtRAddress.SelectionLength = 0;
            this.txtRAddress.SelectionStart = 0;
            this.txtRAddress.ShortcutsEnabled = true;
            this.txtRAddress.Size = new System.Drawing.Size(188, 23);
            this.txtRAddress.TabIndex = 65;
            this.txtRAddress.UseSelectable = true;
            this.txtRAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRName
            // 
            // 
            // 
            // 
            this.txtRName.CustomButton.Image = null;
            this.txtRName.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtRName.CustomButton.Name = "";
            this.txtRName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRName.CustomButton.TabIndex = 1;
            this.txtRName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRName.CustomButton.UseSelectable = true;
            this.txtRName.CustomButton.Visible = false;
            this.txtRName.Lines = new string[0];
            this.txtRName.Location = new System.Drawing.Point(203, 156);
            this.txtRName.MaxLength = 32767;
            this.txtRName.Name = "txtRName";
            this.txtRName.PasswordChar = '\0';
            this.txtRName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRName.SelectedText = "";
            this.txtRName.SelectionLength = 0;
            this.txtRName.SelectionStart = 0;
            this.txtRName.ShortcutsEnabled = true;
            this.txtRName.Size = new System.Drawing.Size(188, 23);
            this.txtRName.TabIndex = 64;
            this.txtRName.UseSelectable = true;
            this.txtRName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSContact
            // 
            // 
            // 
            // 
            this.txtSContact.CustomButton.Image = null;
            this.txtSContact.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtSContact.CustomButton.Name = "";
            this.txtSContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSContact.CustomButton.TabIndex = 1;
            this.txtSContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSContact.CustomButton.UseSelectable = true;
            this.txtSContact.CustomButton.Visible = false;
            this.txtSContact.Lines = new string[0];
            this.txtSContact.Location = new System.Drawing.Point(608, 223);
            this.txtSContact.MaxLength = 32767;
            this.txtSContact.Name = "txtSContact";
            this.txtSContact.PasswordChar = '\0';
            this.txtSContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSContact.SelectedText = "";
            this.txtSContact.SelectionLength = 0;
            this.txtSContact.SelectionStart = 0;
            this.txtSContact.ShortcutsEnabled = true;
            this.txtSContact.Size = new System.Drawing.Size(188, 23);
            this.txtSContact.TabIndex = 63;
            this.txtSContact.UseSelectable = true;
            this.txtSContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSAddress
            // 
            // 
            // 
            // 
            this.txtSAddress.CustomButton.Image = null;
            this.txtSAddress.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtSAddress.CustomButton.Name = "";
            this.txtSAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSAddress.CustomButton.TabIndex = 1;
            this.txtSAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSAddress.CustomButton.UseSelectable = true;
            this.txtSAddress.CustomButton.Visible = false;
            this.txtSAddress.Lines = new string[0];
            this.txtSAddress.Location = new System.Drawing.Point(608, 190);
            this.txtSAddress.MaxLength = 32767;
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.PasswordChar = '\0';
            this.txtSAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSAddress.SelectedText = "";
            this.txtSAddress.SelectionLength = 0;
            this.txtSAddress.SelectionStart = 0;
            this.txtSAddress.ShortcutsEnabled = true;
            this.txtSAddress.Size = new System.Drawing.Size(188, 23);
            this.txtSAddress.TabIndex = 62;
            this.txtSAddress.UseSelectable = true;
            this.txtSAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSName
            // 
            // 
            // 
            // 
            this.txtSName.CustomButton.Image = null;
            this.txtSName.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtSName.CustomButton.Name = "";
            this.txtSName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSName.CustomButton.TabIndex = 1;
            this.txtSName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSName.CustomButton.UseSelectable = true;
            this.txtSName.CustomButton.Visible = false;
            this.txtSName.Lines = new string[0];
            this.txtSName.Location = new System.Drawing.Point(608, 156);
            this.txtSName.MaxLength = 32767;
            this.txtSName.Name = "txtSName";
            this.txtSName.PasswordChar = '\0';
            this.txtSName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSName.SelectedText = "";
            this.txtSName.SelectionLength = 0;
            this.txtSName.SelectionStart = 0;
            this.txtSName.ShortcutsEnabled = true;
            this.txtSName.Size = new System.Drawing.Size(188, 23);
            this.txtSName.TabIndex = 61;
            this.txtSName.UseSelectable = true;
            this.txtSName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRContact
            // 
            this.lblRContact.AutoSize = true;
            this.lblRContact.Location = new System.Drawing.Point(118, 227);
            this.lblRContact.Name = "lblRContact";
            this.lblRContact.Size = new System.Drawing.Size(86, 19);
            this.lblRContact.TabIndex = 60;
            this.lblRContact.Text = "Contact No. :";
            // 
            // lblRAddress
            // 
            this.lblRAddress.AutoSize = true;
            this.lblRAddress.Location = new System.Drawing.Point(118, 190);
            this.lblRAddress.Name = "lblRAddress";
            this.lblRAddress.Size = new System.Drawing.Size(63, 19);
            this.lblRAddress.TabIndex = 59;
            this.lblRAddress.Text = "Address :";
            // 
            // lblRName
            // 
            this.lblRName.AutoSize = true;
            this.lblRName.Location = new System.Drawing.Point(118, 156);
            this.lblRName.Name = "lblRName";
            this.lblRName.Size = new System.Drawing.Size(52, 19);
            this.lblRName.TabIndex = 58;
            this.lblRName.Text = "Name :";
            // 
            // lblRTitle
            // 
            this.lblRTitle.AutoSize = true;
            this.lblRTitle.Location = new System.Drawing.Point(118, 116);
            this.lblRTitle.Name = "lblRTitle";
            this.lblRTitle.Size = new System.Drawing.Size(137, 19);
            this.lblRTitle.TabIndex = 57;
            this.lblRTitle.Text = "Receiver Information ,";
            this.lblRTitle.Click += new System.EventHandler(this.lblRTitle_Click);
            // 
            // lblParcelType
            // 
            this.lblParcelType.AutoSize = true;
            this.lblParcelType.Location = new System.Drawing.Point(118, 313);
            this.lblParcelType.Name = "lblParcelType";
            this.lblParcelType.Size = new System.Drawing.Size(82, 19);
            this.lblParcelType.TabIndex = 56;
            this.lblParcelType.Text = "Parcel Type :";
            // 
            // lblSContact
            // 
            this.lblSContact.AutoSize = true;
            this.lblSContact.Location = new System.Drawing.Point(488, 227);
            this.lblSContact.Name = "lblSContact";
            this.lblSContact.Size = new System.Drawing.Size(86, 19);
            this.lblSContact.TabIndex = 55;
            this.lblSContact.Text = "Contact No. :";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(488, 156);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(52, 19);
            this.lblSName.TabIndex = 53;
            this.lblSName.Text = "Name :";
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(488, 116);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(129, 19);
            this.lblSender.TabIndex = 52;
            this.lblSender.Text = "Sender Information ,";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(108, 75);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 23);
            this.lblTitle.TabIndex = 51;
            this.lblTitle.Text = "Export Request Details";
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Location = new System.Drawing.Point(118, 350);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(130, 19);
            this.lblMedium.TabIndex = 73;
            this.lblMedium.Text = "Suggested Medium :";
            // 
            // comboMedium
            // 
            this.comboMedium.FormattingEnabled = true;
            this.comboMedium.Items.AddRange(new object[] {
            "DHL",
            "TNT",
            "DPEX"});
            this.comboMedium.Location = new System.Drawing.Point(252, 350);
            this.comboMedium.Name = "comboMedium";
            this.comboMedium.Size = new System.Drawing.Size(166, 21);
            this.comboMedium.TabIndex = 74;
            // 
            // lblSAddress
            // 
            this.lblSAddress.AutoSize = true;
            this.lblSAddress.Location = new System.Drawing.Point(488, 190);
            this.lblSAddress.Name = "lblSAddress";
            this.lblSAddress.Size = new System.Drawing.Size(63, 19);
            this.lblSAddress.TabIndex = 75;
            this.lblSAddress.Text = "Address :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(512, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerExpReqPage
            // 
            this.timerExpReqPage.Interval = 2000;
            this.timerExpReqPage.Tick += new System.EventHandler(this.timerExpReqPage_Tick);
            // 
            // txtRCountry
            // 
            // 
            // 
            // 
            this.txtRCountry.CustomButton.Image = null;
            this.txtRCountry.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtRCountry.CustomButton.Name = "";
            this.txtRCountry.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRCountry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRCountry.CustomButton.TabIndex = 1;
            this.txtRCountry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRCountry.CustomButton.UseSelectable = true;
            this.txtRCountry.CustomButton.Visible = false;
            this.txtRCountry.Lines = new string[0];
            this.txtRCountry.Location = new System.Drawing.Point(203, 256);
            this.txtRCountry.MaxLength = 32767;
            this.txtRCountry.Name = "txtRCountry";
            this.txtRCountry.PasswordChar = '\0';
            this.txtRCountry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRCountry.SelectedText = "";
            this.txtRCountry.SelectionLength = 0;
            this.txtRCountry.SelectionStart = 0;
            this.txtRCountry.ShortcutsEnabled = true;
            this.txtRCountry.Size = new System.Drawing.Size(188, 23);
            this.txtRCountry.TabIndex = 78;
            this.txtRCountry.UseSelectable = true;
            this.txtRCountry.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRCountry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRCountry
            // 
            this.lblRCountry.AutoSize = true;
            this.lblRCountry.Location = new System.Drawing.Point(118, 260);
            this.lblRCountry.Name = "lblRCountry";
            this.lblRCountry.Size = new System.Drawing.Size(63, 19);
            this.lblRCountry.TabIndex = 77;
            this.lblRCountry.Text = "Country :";
            // 
            // ExportReqInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 447);
            this.Controls.Add(this.txtRCountry);
            this.Controls.Add(this.lblRCountry);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSAddress);
            this.Controls.Add(this.comboMedium);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.PBStatus);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.txtParcelType);
            this.Controls.Add(this.txtRContact);
            this.Controls.Add(this.txtRAddress);
            this.Controls.Add(this.txtRName);
            this.Controls.Add(this.txtSContact);
            this.Controls.Add(this.txtSAddress);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.lblRContact);
            this.Controls.Add(this.lblRAddress);
            this.Controls.Add(this.lblRName);
            this.Controls.Add(this.lblRTitle);
            this.Controls.Add(this.lblParcelType);
            this.Controls.Add(this.lblSContact);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.lblTitle);
            this.Name = "ExportReqInfo";
            this.Text = "Airlink International courier";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportReqInfo_FormClosing);
            this.Load += new System.EventHandler(this.ExportReqInfo_Load);
            this.PBStatus.ResumeLayout(false);
            this.PBStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip PBStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnRequest;
        private MetroFramework.Controls.MetroTextBox txtParcelType;
        private MetroFramework.Controls.MetroTextBox txtRContact;
        private MetroFramework.Controls.MetroTextBox txtRAddress;
        private MetroFramework.Controls.MetroTextBox txtRName;
        private MetroFramework.Controls.MetroTextBox txtSContact;
        private MetroFramework.Controls.MetroTextBox txtSAddress;
        private MetroFramework.Controls.MetroTextBox txtSName;
        private MetroFramework.Controls.MetroLabel lblRContact;
        private MetroFramework.Controls.MetroLabel lblRAddress;
        private MetroFramework.Controls.MetroLabel lblRName;
        private MetroFramework.Controls.MetroLabel lblRTitle;
        private MetroFramework.Controls.MetroLabel lblParcelType;
        private MetroFramework.Controls.MetroLabel lblSContact;
        private MetroFramework.Controls.MetroLabel lblSName;
        private MetroFramework.Controls.MetroLabel lblSender;
        private System.Windows.Forms.Label lblTitle;
        private MetroFramework.Controls.MetroLabel lblMedium;
        private System.Windows.Forms.ComboBox comboMedium;
        private MetroFramework.Controls.MetroLabel lblSAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerExpReqPage;
        private MetroFramework.Controls.MetroTextBox txtRCountry;
        private MetroFramework.Controls.MetroLabel lblRCountry;
    }
}