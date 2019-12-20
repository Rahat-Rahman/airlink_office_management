namespace Airlink
{
    partial class trackingFormDpex
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.txtDPEXTrack = new MetroFramework.Controls.MetroTextBox();
            this.btnDPEXTrack = new System.Windows.Forms.Button();
            this.lblTrack = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 526);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblTrack);
            this.metroPanel1.Controls.Add(this.btnDPEXTrack);
            this.metroPanel1.Controls.Add(this.txtDPEXTrack);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(959, 46);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(3, 55);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(959, 468);
            this.webBrowser3.TabIndex = 1;
            // 
            // txtDPEXTrack
            // 
            // 
            // 
            // 
            this.txtDPEXTrack.CustomButton.Image = null;
            this.txtDPEXTrack.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtDPEXTrack.CustomButton.Name = "";
            this.txtDPEXTrack.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDPEXTrack.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDPEXTrack.CustomButton.TabIndex = 1;
            this.txtDPEXTrack.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDPEXTrack.CustomButton.UseSelectable = true;
            this.txtDPEXTrack.CustomButton.Visible = false;
            this.txtDPEXTrack.Lines = new string[0];
            this.txtDPEXTrack.Location = new System.Drawing.Point(156, 10);
            this.txtDPEXTrack.MaxLength = 32767;
            this.txtDPEXTrack.Name = "txtDPEXTrack";
            this.txtDPEXTrack.PasswordChar = '\0';
            this.txtDPEXTrack.PromptText = "Enter Air Waybill/Tracking Number";
            this.txtDPEXTrack.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDPEXTrack.SelectedText = "";
            this.txtDPEXTrack.SelectionLength = 0;
            this.txtDPEXTrack.SelectionStart = 0;
            this.txtDPEXTrack.ShortcutsEnabled = true;
            this.txtDPEXTrack.Size = new System.Drawing.Size(209, 23);
            this.txtDPEXTrack.TabIndex = 3;
            this.txtDPEXTrack.UseSelectable = true;
            this.txtDPEXTrack.WaterMark = "Enter Air Waybill/Tracking Number";
            this.txtDPEXTrack.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDPEXTrack.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDPEXTrack
            // 
            this.btnDPEXTrack.BackColor = System.Drawing.Color.DarkGray;
            this.btnDPEXTrack.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDPEXTrack.Location = new System.Drawing.Point(416, 10);
            this.btnDPEXTrack.Name = "btnDPEXTrack";
            this.btnDPEXTrack.Size = new System.Drawing.Size(115, 23);
            this.btnDPEXTrack.TabIndex = 6;
            this.btnDPEXTrack.Text = "Track";
            this.btnDPEXTrack.UseVisualStyleBackColor = false;
            this.btnDPEXTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // lblTrack
            // 
            this.lblTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTrack.Location = new System.Drawing.Point(3, 10);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(147, 23);
            this.lblTrack.TabIndex = 7;
            this.lblTrack.Text = "Track Your Parcel :";
            // 
            // trackingFormDpex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 606);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "trackingFormDpex";
            this.Text = "DPEX WORLDWIDE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.trackingFormDpex_FormClosing);
            this.Load += new System.EventHandler(this.trackingFormDpex_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtDPEXTrack;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.Button btnDPEXTrack;
        private System.Windows.Forms.Label lblTrack;
    }
}