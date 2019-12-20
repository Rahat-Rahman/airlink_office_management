namespace Airlink
{
    partial class TrackingFormTNT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTNTTrack = new System.Windows.Forms.Button();
            this.txtTNTTrack = new System.Windows.Forms.TextBox();
            this.lblTrack = new System.Windows.Forms.Label();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 526);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTNTTrack);
            this.panel1.Controls.Add(this.txtTNTTrack);
            this.panel1.Controls.Add(this.lblTrack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnTNTTrack
            // 
            this.btnTNTTrack.BackColor = System.Drawing.Color.DarkGray;
            this.btnTNTTrack.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTNTTrack.Location = new System.Drawing.Point(380, 5);
            this.btnTNTTrack.Name = "btnTNTTrack";
            this.btnTNTTrack.Size = new System.Drawing.Size(102, 25);
            this.btnTNTTrack.TabIndex = 6;
            this.btnTNTTrack.Text = "Track";
            this.btnTNTTrack.UseVisualStyleBackColor = false;
            this.btnTNTTrack.Click += new System.EventHandler(this.btnTNTTrack_Click);
            // 
            // txtTNTTrack
            // 
            this.txtTNTTrack.Location = new System.Drawing.Point(165, 7);
            this.txtTNTTrack.Name = "txtTNTTrack";
            this.txtTNTTrack.Size = new System.Drawing.Size(196, 20);
            this.txtTNTTrack.TabIndex = 1;
            // 
            // lblTrack
            // 
            this.lblTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTrack.Location = new System.Drawing.Point(12, 7);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(147, 23);
            this.lblTrack.TabIndex = 0;
            this.lblTrack.Text = "Track Your Parcel :";
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 55);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(959, 468);
            this.webBrowser2.TabIndex = 1;
            // 
            // TrackingFormTNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 606);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TrackingFormTNT";
            this.Text = "TNT Express";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrackingFormTNT_FormClosing);
            this.Load += new System.EventHandler(this.TrackingFormTNT_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTNTTrack;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Button btnTNTTrack;
        private System.Windows.Forms.WebBrowser webBrowser2;

    }
}