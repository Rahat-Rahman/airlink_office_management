using System.Windows.Forms;

namespace Airlink
{
    partial class EmpPageAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpPageAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTab = new MetroFramework.Controls.MetroTabControl();
            this.MtBasicInfo = new MetroFramework.Controls.MetroTabPage();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnPicAdd = new MetroFramework.Controls.MetroButton();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtDept = new MetroFramework.Controls.MetroTextBox();
            this.dtDob = new MetroFramework.Controls.MetroDateTime();
            this.groupBoxPassChng = new System.Windows.Forms.GroupBox();
            this.btnHideChar = new System.Windows.Forms.Button();
            this.btnShowChar = new System.Windows.Forms.Button();
            this.btnSavePass = new MetroFramework.Controls.MetroButton();
            this.txtConfirmNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtOldPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUserId = new MetroFramework.Controls.MetroTextBox();
            this.txtMail = new MetroFramework.Controls.MetroTextBox();
            this.txtDesignation = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBoxPP = new System.Windows.Forms.PictureBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.MTEmployees = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.btnESave = new MetroFramework.Controls.MetroButton();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.lblEUserName = new MetroFramework.Controls.MetroLabel();
            this.txtEUserName = new MetroFramework.Controls.MetroTextBox();
            this.lblEPassword = new MetroFramework.Controls.MetroLabel();
            this.txtEPassword = new MetroFramework.Controls.MetroTextBox();
            this.ddlEDepartment = new MetroFramework.Controls.MetroComboBox();
            this.DtpEDob = new MetroFramework.Controls.MetroDateTime();
            this.lblEDepartment = new MetroFramework.Controls.MetroLabel();
            this.lblEDob = new MetroFramework.Controls.MetroLabel();
            this.txtEEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblEEmail = new MetroFramework.Controls.MetroLabel();
            this.lblEDesignation = new MetroFramework.Controls.MetroLabel();
            this.txtEDesignation = new MetroFramework.Controls.MetroTextBox();
            this.lblEName = new MetroFramework.Controls.MetroLabel();
            this.txtEName = new MetroFramework.Controls.MetroTextBox();
            this.txtEId = new MetroFramework.Controls.MetroTextBox();
            this.lblEId = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnERefresh = new MetroFramework.Controls.MetroButton();
            this.btnEAdd = new MetroFramework.Controls.MetroButton();
            this.btnEDelete = new MetroFramework.Controls.MetroButton();
            this.txtESearch = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.GridEmployee = new MetroFramework.Controls.MetroGrid();
            this.EId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MtDepartments = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDeptSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.txtDeptName = new MetroFramework.Controls.MetroTextBox();
            this.txtDeptId = new MetroFramework.Controls.MetroTextBox();
            this.lblDeptName = new MetroFramework.Controls.MetroLabel();
            this.lblDeptId = new MetroFramework.Controls.MetroLabel();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeptRefresh = new MetroFramework.Controls.MetroButton();
            this.MtBill = new MetroFramework.Controls.MetroTabPage();
            this.btnAddRates = new MetroFramework.Controls.MetroButton();
            this.txtDPEXRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtTNTRate = new MetroFramework.Controls.MetroTextBox();
            this.txtDHLRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtRateSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnRateSave = new MetroFramework.Controls.MetroButton();
            this.txtCountryName = new MetroFramework.Controls.MetroTextBox();
            this.txtRateID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dgvRate = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MtExportDetail = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panelExportDetailSearch = new MetroFramework.Controls.MetroPanel();
            this.txtIdExport = new MetroFramework.Controls.MetroTextBox();
            this.btnDeleteReqExp = new MetroFramework.Controls.MetroButton();
            this.txtDetailAirwayBill = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel61 = new MetroFramework.Controls.MetroLabel();
            this.txtExportSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnExportRequestUpdate = new MetroFramework.Controls.MetroButton();
            this.txtDetailMedium = new MetroFramework.Controls.MetroTextBox();
            this.txtDetailParcelType = new MetroFramework.Controls.MetroTextBox();
            this.txtDetailSAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel30 = new MetroFramework.Controls.MetroLabel();
            this.txtDetailRAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel31 = new MetroFramework.Controls.MetroLabel();
            this.txtDetailSContactNo = new MetroFramework.Controls.MetroTextBox();
            this.txtDetailSName = new MetroFramework.Controls.MetroTextBox();
            this.txtDetailRContactNo = new MetroFramework.Controls.MetroTextBox();
            this.txtDetailRCountry = new MetroFramework.Controls.MetroTextBox();
            this.txtDetailRName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel32 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel33 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel34 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel35 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel36 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel37 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel38 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel39 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel40 = new MetroFramework.Controls.MetroLabel();
            this.dgvExport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MtImportDetail = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.txtIdImport = new MetroFramework.Controls.MetroTextBox();
            this.txtDetailArrived = new MetroFramework.Controls.MetroTextBox();
            this.lblArrived = new MetroFramework.Controls.MetroLabel();
            this.btnDeleteImp = new MetroFramework.Controls.MetroButton();
            this.txtSDetailAirwayBill2I = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel41 = new MetroFramework.Controls.MetroLabel();
            this.txtSDetailMedium2I = new MetroFramework.Controls.MetroTextBox();
            this.txtDetailParcelType2I = new MetroFramework.Controls.MetroTextBox();
            this.txtRDetailAddress2I = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel52 = new MetroFramework.Controls.MetroLabel();
            this.txtSDetailContact2I = new MetroFramework.Controls.MetroTextBox();
            this.txtSDetailName2I = new MetroFramework.Controls.MetroTextBox();
            this.txtRDetailContact2I = new MetroFramework.Controls.MetroTextBox();
            this.txtRDetailName2I = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel53 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel54 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel55 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel56 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel57 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel58 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel59 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel60 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchImport = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdateReqImport = new MetroFramework.Controls.MetroButton();
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MtCommunicate = new MetroFramework.Controls.MetroTabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.lblIsArrived = new System.Windows.Forms.Label();
            this.metroTab.SuspendLayout();
            this.MtBasicInfo.SuspendLayout();
            this.groupBoxPassChng.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPP)).BeginInit();
            this.MTEmployees.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).BeginInit();
            this.MtDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.MtBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRate)).BeginInit();
            this.MtExportDetail.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panelExportDetailSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).BeginInit();
            this.MtImportDetail.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTab
            // 
            this.metroTab.Controls.Add(this.MtBasicInfo);
            this.metroTab.Controls.Add(this.MTEmployees);
            this.metroTab.Controls.Add(this.MtDepartments);
            this.metroTab.Controls.Add(this.MtBill);
            this.metroTab.Controls.Add(this.MtExportDetail);
            this.metroTab.Controls.Add(this.MtImportDetail);
            this.metroTab.Controls.Add(this.MtCommunicate);
            this.metroTab.Location = new System.Drawing.Point(5, 90);
            this.metroTab.Name = "metroTab";
            this.metroTab.SelectedIndex = 3;
            this.metroTab.Size = new System.Drawing.Size(872, 385);
            this.metroTab.TabIndex = 0;
            this.metroTab.UseSelectable = true;
            // 
            // MtBasicInfo
            // 
            this.MtBasicInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MtBasicInfo.Controls.Add(this.txtPic);
            this.MtBasicInfo.Controls.Add(this.btnUpdate);
            this.MtBasicInfo.Controls.Add(this.btnPicAdd);
            this.MtBasicInfo.Controls.Add(this.lbl5);
            this.MtBasicInfo.Controls.Add(this.txtDept);
            this.MtBasicInfo.Controls.Add(this.dtDob);
            this.MtBasicInfo.Controls.Add(this.groupBoxPassChng);
            this.MtBasicInfo.Controls.Add(this.txtUserId);
            this.MtBasicInfo.Controls.Add(this.txtMail);
            this.MtBasicInfo.Controls.Add(this.txtDesignation);
            this.MtBasicInfo.Controls.Add(this.txtName);
            this.MtBasicInfo.Controls.Add(this.btnEdit);
            this.MtBasicInfo.Controls.Add(this.metroPanel1);
            this.MtBasicInfo.Controls.Add(this.lbl6);
            this.MtBasicInfo.Controls.Add(this.lbl2);
            this.MtBasicInfo.Controls.Add(this.lbl3);
            this.MtBasicInfo.Controls.Add(this.lbl4);
            this.MtBasicInfo.Controls.Add(this.lbl1);
            this.MtBasicInfo.HorizontalScrollbarBarColor = true;
            this.MtBasicInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.MtBasicInfo.HorizontalScrollbarSize = 10;
            this.MtBasicInfo.Location = new System.Drawing.Point(4, 38);
            this.MtBasicInfo.Name = "MtBasicInfo";
            this.MtBasicInfo.Size = new System.Drawing.Size(864, 343);
            this.MtBasicInfo.TabIndex = 0;
            this.MtBasicInfo.Text = "Information";
            this.MtBasicInfo.UseCustomBackColor = true;
            this.MtBasicInfo.UseCustomForeColor = true;
            this.MtBasicInfo.UseStyleColors = true;
            this.MtBasicInfo.VerticalScrollbarBarColor = true;
            this.MtBasicInfo.VerticalScrollbarHighlightOnWheel = false;
            this.MtBasicInfo.VerticalScrollbarSize = 10;
            this.MtBasicInfo.Click += new System.EventHandler(this.MtBasicInfo_Click);
            // 
            // txtPic
            // 
            this.txtPic.Location = new System.Drawing.Point(3, 177);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(154, 20);
            this.txtPic.TabIndex = 58;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(381, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 23);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseCustomForeColor = true;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.UseStyleColors = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPicAdd
            // 
            this.btnPicAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPicAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPicAdd.Location = new System.Drawing.Point(3, 203);
            this.btnPicAdd.Name = "btnPicAdd";
            this.btnPicAdd.Size = new System.Drawing.Size(154, 21);
            this.btnPicAdd.TabIndex = 40;
            this.btnPicAdd.Text = "Change Photo";
            this.btnPicAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPicAdd.UseCustomBackColor = true;
            this.btnPicAdd.UseCustomForeColor = true;
            this.btnPicAdd.UseSelectable = true;
            this.btnPicAdd.UseStyleColors = true;
            this.btnPicAdd.Click += new System.EventHandler(this.btnPicAdd_Click);
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(209, 141);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(100, 25);
            this.lbl5.TabIndex = 39;
            this.lbl5.Text = "Dept. Name :";
            this.lbl5.UseWaitCursor = true;
            // 
            // txtDept
            // 
            // 
            // 
            // 
            this.txtDept.CustomButton.Image = null;
            this.txtDept.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtDept.CustomButton.Name = "";
            this.txtDept.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDept.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDept.CustomButton.TabIndex = 1;
            this.txtDept.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDept.CustomButton.UseSelectable = true;
            this.txtDept.CustomButton.Visible = false;
            this.txtDept.Enabled = false;
            this.txtDept.Lines = new string[0];
            this.txtDept.Location = new System.Drawing.Point(315, 143);
            this.txtDept.MaxLength = 32767;
            this.txtDept.Name = "txtDept";
            this.txtDept.PasswordChar = '\0';
            this.txtDept.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDept.SelectedText = "";
            this.txtDept.SelectionLength = 0;
            this.txtDept.SelectionStart = 0;
            this.txtDept.ShortcutsEnabled = true;
            this.txtDept.Size = new System.Drawing.Size(184, 23);
            this.txtDept.TabIndex = 38;
            this.txtDept.UseSelectable = true;
            this.txtDept.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDept.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtDob
            // 
            this.dtDob.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDob.Location = new System.Drawing.Point(315, 172);
            this.dtDob.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(184, 25);
            this.dtDob.TabIndex = 37;
            // 
            // groupBoxPassChng
            // 
            this.groupBoxPassChng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxPassChng.Controls.Add(this.btnHideChar);
            this.groupBoxPassChng.Controls.Add(this.btnShowChar);
            this.groupBoxPassChng.Controls.Add(this.btnSavePass);
            this.groupBoxPassChng.Controls.Add(this.txtConfirmNewPassword);
            this.groupBoxPassChng.Controls.Add(this.txtNewPassword);
            this.groupBoxPassChng.Controls.Add(this.txtOldPassword);
            this.groupBoxPassChng.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBoxPassChng.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPassChng.ForeColor = System.Drawing.Color.Black;
            this.groupBoxPassChng.Location = new System.Drawing.Point(3, 230);
            this.groupBoxPassChng.Name = "groupBoxPassChng";
            this.groupBoxPassChng.Size = new System.Drawing.Size(445, 99);
            this.groupBoxPassChng.TabIndex = 36;
            this.groupBoxPassChng.TabStop = false;
            this.groupBoxPassChng.Text = "Change Password";
            this.groupBoxPassChng.UseCompatibleTextRendering = true;
            // 
            // btnHideChar
            // 
            this.btnHideChar.Location = new System.Drawing.Point(261, 41);
            this.btnHideChar.Name = "btnHideChar";
            this.btnHideChar.Size = new System.Drawing.Size(91, 23);
            this.btnHideChar.TabIndex = 5;
            this.btnHideChar.Text = "Hide Character";
            this.btnHideChar.UseVisualStyleBackColor = true;
            this.btnHideChar.Click += new System.EventHandler(this.btnHideChar_Click);
            // 
            // btnShowChar
            // 
            this.btnShowChar.Location = new System.Drawing.Point(261, 41);
            this.btnShowChar.Name = "btnShowChar";
            this.btnShowChar.Size = new System.Drawing.Size(91, 23);
            this.btnShowChar.TabIndex = 4;
            this.btnShowChar.Text = "Show Character";
            this.btnShowChar.UseVisualStyleBackColor = true;
            this.btnShowChar.Click += new System.EventHandler(this.btnShowChar_Click);
            // 
            // btnSavePass
            // 
            this.btnSavePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSavePass.Location = new System.Drawing.Point(261, 70);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(118, 23);
            this.btnSavePass.TabIndex = 3;
            this.btnSavePass.Text = "Save";
            this.btnSavePass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSavePass.UseCustomBackColor = true;
            this.btnSavePass.UseCustomForeColor = true;
            this.btnSavePass.UseSelectable = true;
            this.btnSavePass.UseStyleColors = true;
            this.btnSavePass.Click += new System.EventHandler(this.btnSavePass_Click);
            // 
            // txtConfirmNewPassword
            // 
            // 
            // 
            // 
            this.txtConfirmNewPassword.CustomButton.Image = null;
            this.txtConfirmNewPassword.CustomButton.Location = new System.Drawing.Point(170, 2);
            this.txtConfirmNewPassword.CustomButton.Name = "";
            this.txtConfirmNewPassword.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtConfirmNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmNewPassword.CustomButton.TabIndex = 1;
            this.txtConfirmNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmNewPassword.CustomButton.UseSelectable = true;
            this.txtConfirmNewPassword.CustomButton.Visible = false;
            this.txtConfirmNewPassword.Lines = new string[0];
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(6, 70);
            this.txtConfirmNewPassword.MaxLength = 32767;
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '\0';
            this.txtConfirmNewPassword.PromptText = "Confirm New Password";
            this.txtConfirmNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmNewPassword.SelectedText = "";
            this.txtConfirmNewPassword.SelectionLength = 0;
            this.txtConfirmNewPassword.SelectionStart = 0;
            this.txtConfirmNewPassword.ShortcutsEnabled = true;
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(188, 20);
            this.txtConfirmNewPassword.TabIndex = 2;
            this.txtConfirmNewPassword.UseSelectable = true;
            this.txtConfirmNewPassword.WaterMark = "Confirm New Password";
            this.txtConfirmNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNewPassword
            // 
            // 
            // 
            // 
            this.txtNewPassword.CustomButton.Image = null;
            this.txtNewPassword.CustomButton.Location = new System.Drawing.Point(170, 2);
            this.txtNewPassword.CustomButton.Name = "";
            this.txtNewPassword.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPassword.CustomButton.TabIndex = 1;
            this.txtNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPassword.CustomButton.UseSelectable = true;
            this.txtNewPassword.CustomButton.Visible = false;
            this.txtNewPassword.Lines = new string[0];
            this.txtNewPassword.Location = new System.Drawing.Point(6, 47);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.PromptText = "New Password";
            this.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.ShortcutsEnabled = true;
            this.txtNewPassword.Size = new System.Drawing.Size(188, 20);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSelectable = true;
            this.txtNewPassword.WaterMark = "New Password";
            this.txtNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOldPassword
            // 
            // 
            // 
            // 
            this.txtOldPassword.CustomButton.Image = null;
            this.txtOldPassword.CustomButton.Location = new System.Drawing.Point(170, 2);
            this.txtOldPassword.CustomButton.Name = "";
            this.txtOldPassword.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtOldPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldPassword.CustomButton.TabIndex = 1;
            this.txtOldPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldPassword.CustomButton.UseSelectable = true;
            this.txtOldPassword.CustomButton.Visible = false;
            this.txtOldPassword.Lines = new string[0];
            this.txtOldPassword.Location = new System.Drawing.Point(6, 21);
            this.txtOldPassword.MaxLength = 32767;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '\0';
            this.txtOldPassword.PromptText = "Old Password";
            this.txtOldPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldPassword.SelectedText = "";
            this.txtOldPassword.SelectionLength = 0;
            this.txtOldPassword.SelectionStart = 0;
            this.txtOldPassword.ShortcutsEnabled = true;
            this.txtOldPassword.Size = new System.Drawing.Size(188, 20);
            this.txtOldPassword.TabIndex = 0;
            this.txtOldPassword.UseSelectable = true;
            this.txtOldPassword.WaterMark = "Old Password";
            this.txtOldPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOldPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserId
            // 
            // 
            // 
            // 
            this.txtUserId.CustomButton.Image = null;
            this.txtUserId.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtUserId.CustomButton.Name = "";
            this.txtUserId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserId.CustomButton.TabIndex = 1;
            this.txtUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserId.CustomButton.UseSelectable = true;
            this.txtUserId.CustomButton.Visible = false;
            this.txtUserId.Lines = new string[0];
            this.txtUserId.Location = new System.Drawing.Point(315, 44);
            this.txtUserId.MaxLength = 32767;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PasswordChar = '\0';
            this.txtUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserId.SelectedText = "";
            this.txtUserId.SelectionLength = 0;
            this.txtUserId.SelectionStart = 0;
            this.txtUserId.ShortcutsEnabled = true;
            this.txtUserId.Size = new System.Drawing.Size(184, 23);
            this.txtUserId.TabIndex = 34;
            this.txtUserId.UseSelectable = true;
            this.txtUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMail
            // 
            // 
            // 
            // 
            this.txtMail.CustomButton.Image = null;
            this.txtMail.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtMail.CustomButton.Name = "";
            this.txtMail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMail.CustomButton.TabIndex = 1;
            this.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMail.CustomButton.UseSelectable = true;
            this.txtMail.CustomButton.Visible = false;
            this.txtMail.Lines = new string[0];
            this.txtMail.Location = new System.Drawing.Point(315, 78);
            this.txtMail.MaxLength = 32767;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(184, 23);
            this.txtMail.TabIndex = 33;
            this.txtMail.UseSelectable = true;
            this.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDesignation
            // 
            // 
            // 
            // 
            this.txtDesignation.CustomButton.Image = null;
            this.txtDesignation.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtDesignation.CustomButton.Name = "";
            this.txtDesignation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDesignation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesignation.CustomButton.TabIndex = 1;
            this.txtDesignation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesignation.CustomButton.UseSelectable = true;
            this.txtDesignation.CustomButton.Visible = false;
            this.txtDesignation.Lines = new string[0];
            this.txtDesignation.Location = new System.Drawing.Point(315, 110);
            this.txtDesignation.MaxLength = 32767;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.PasswordChar = '\0';
            this.txtDesignation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesignation.SelectedText = "";
            this.txtDesignation.SelectionLength = 0;
            this.txtDesignation.SelectionStart = 0;
            this.txtDesignation.ShortcutsEnabled = true;
            this.txtDesignation.Size = new System.Drawing.Size(184, 23);
            this.txtDesignation.TabIndex = 32;
            this.txtDesignation.UseSelectable = true;
            this.txtDesignation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesignation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(315, 14);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(184, 23);
            this.txtName.TabIndex = 31;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.Location = new System.Drawing.Point(212, 203);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 23);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Change Account Password";
            this.btnEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEdit.UseCustomBackColor = true;
            this.btnEdit.UseCustomForeColor = true;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.UseStyleColors = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pictureBoxPP);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(154, 165);
            this.metroPanel1.TabIndex = 28;
            this.metroPanel1.UseWaitCursor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBoxPP
            // 
            this.pictureBoxPP.BackgroundImage = global::Airlink.Properties.Resources.user_512;
            this.pictureBoxPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPP.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPP.Name = "pictureBoxPP";
            this.pictureBoxPP.Size = new System.Drawing.Size(148, 159);
            this.pictureBoxPP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPP.TabIndex = 8;
            this.pictureBoxPP.TabStop = false;
            this.pictureBoxPP.UseWaitCursor = true;
            // 
            // lbl6
            // 
            this.lbl6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(209, 172);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(100, 25);
            this.lbl6.TabIndex = 27;
            this.lbl6.Text = "Date of Birth  :";
            this.lbl6.UseWaitCursor = true;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(209, 44);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 23);
            this.lbl2.TabIndex = 26;
            this.lbl2.Text = "User Name :";
            this.lbl2.UseWaitCursor = true;
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(209, 78);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 23);
            this.lbl3.TabIndex = 25;
            this.lbl3.Text = "E-mail :";
            this.lbl3.UseWaitCursor = true;
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(209, 110);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(100, 23);
            this.lbl4.TabIndex = 24;
            this.lbl4.Text = "Designation :";
            this.lbl4.UseWaitCursor = true;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(209, 14);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 23);
            this.lbl1.TabIndex = 23;
            this.lbl1.Text = "Name :";
            this.lbl1.UseWaitCursor = true;
            // 
            // MTEmployees
            // 
            this.MTEmployees.Controls.Add(this.tableLayoutPanel1);
            this.MTEmployees.HorizontalScrollbarBarColor = true;
            this.MTEmployees.HorizontalScrollbarHighlightOnWheel = false;
            this.MTEmployees.HorizontalScrollbarSize = 10;
            this.MTEmployees.Location = new System.Drawing.Point(4, 38);
            this.MTEmployees.Name = "MTEmployees";
            this.MTEmployees.Size = new System.Drawing.Size(864, 343);
            this.MTEmployees.TabIndex = 6;
            this.MTEmployees.Text = "Employees";
            this.MTEmployees.VerticalScrollbarBarColor = true;
            this.MTEmployees.VerticalScrollbarHighlightOnWheel = false;
            this.MTEmployees.VerticalScrollbarSize = 10;
            this.MTEmployees.Click += new System.EventHandler(this.MTEmployees_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(864, 343);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.metroPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(617, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(244, 337);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.btnESave);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(3, 3);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(238, 44);
            this.metroPanel4.TabIndex = 0;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // btnESave
            // 
            this.btnESave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnESave.Location = new System.Drawing.Point(13, 12);
            this.btnESave.Name = "btnESave";
            this.btnESave.Size = new System.Drawing.Size(86, 23);
            this.btnESave.TabIndex = 2;
            this.btnESave.Text = "Save";
            this.btnESave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnESave.UseCustomBackColor = true;
            this.btnESave.UseCustomForeColor = true;
            this.btnESave.UseSelectable = true;
            this.btnESave.UseStyleColors = true;
            this.btnESave.Click += new System.EventHandler(this.btnESave_Click);
            // 
            // metroPanel5
            // 
            this.metroPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel5.Controls.Add(this.lblEUserName);
            this.metroPanel5.Controls.Add(this.txtEUserName);
            this.metroPanel5.Controls.Add(this.lblEPassword);
            this.metroPanel5.Controls.Add(this.txtEPassword);
            this.metroPanel5.Controls.Add(this.ddlEDepartment);
            this.metroPanel5.Controls.Add(this.DtpEDob);
            this.metroPanel5.Controls.Add(this.lblEDepartment);
            this.metroPanel5.Controls.Add(this.lblEDob);
            this.metroPanel5.Controls.Add(this.txtEEmail);
            this.metroPanel5.Controls.Add(this.lblEEmail);
            this.metroPanel5.Controls.Add(this.lblEDesignation);
            this.metroPanel5.Controls.Add(this.txtEDesignation);
            this.metroPanel5.Controls.Add(this.lblEName);
            this.metroPanel5.Controls.Add(this.txtEName);
            this.metroPanel5.Controls.Add(this.txtEId);
            this.metroPanel5.Controls.Add(this.lblEId);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(3, 53);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(238, 281);
            this.metroPanel5.TabIndex = 1;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            this.metroPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel5_Paint);
            // 
            // lblEUserName
            // 
            this.lblEUserName.BackColor = System.Drawing.Color.White;
            this.lblEUserName.Location = new System.Drawing.Point(3, 102);
            this.lblEUserName.Name = "lblEUserName";
            this.lblEUserName.Size = new System.Drawing.Size(84, 23);
            this.lblEUserName.TabIndex = 20;
            this.lblEUserName.Text = "User Name :";
            this.lblEUserName.UseCustomBackColor = true;
            this.lblEUserName.UseCustomForeColor = true;
            this.lblEUserName.UseStyleColors = true;
            // 
            // txtEUserName
            // 
            // 
            // 
            // 
            this.txtEUserName.CustomButton.Image = null;
            this.txtEUserName.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtEUserName.CustomButton.Name = "";
            this.txtEUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEUserName.CustomButton.TabIndex = 1;
            this.txtEUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEUserName.CustomButton.UseSelectable = true;
            this.txtEUserName.CustomButton.Visible = false;
            this.txtEUserName.Lines = new string[0];
            this.txtEUserName.Location = new System.Drawing.Point(93, 102);
            this.txtEUserName.MaxLength = 32767;
            this.txtEUserName.Name = "txtEUserName";
            this.txtEUserName.PasswordChar = '\0';
            this.txtEUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEUserName.SelectedText = "";
            this.txtEUserName.SelectionLength = 0;
            this.txtEUserName.SelectionStart = 0;
            this.txtEUserName.ShortcutsEnabled = true;
            this.txtEUserName.Size = new System.Drawing.Size(127, 23);
            this.txtEUserName.TabIndex = 19;
            this.txtEUserName.UseSelectable = true;
            this.txtEUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEPassword
            // 
            this.lblEPassword.BackColor = System.Drawing.Color.White;
            this.lblEPassword.Location = new System.Drawing.Point(3, 69);
            this.lblEPassword.Name = "lblEPassword";
            this.lblEPassword.Size = new System.Drawing.Size(84, 23);
            this.lblEPassword.TabIndex = 18;
            this.lblEPassword.Text = "Password :";
            this.lblEPassword.UseCustomBackColor = true;
            this.lblEPassword.UseCustomForeColor = true;
            this.lblEPassword.UseStyleColors = true;
            // 
            // txtEPassword
            // 
            // 
            // 
            // 
            this.txtEPassword.CustomButton.Image = null;
            this.txtEPassword.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtEPassword.CustomButton.Name = "";
            this.txtEPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEPassword.CustomButton.TabIndex = 1;
            this.txtEPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEPassword.CustomButton.UseSelectable = true;
            this.txtEPassword.CustomButton.Visible = false;
            this.txtEPassword.Lines = new string[0];
            this.txtEPassword.Location = new System.Drawing.Point(93, 69);
            this.txtEPassword.MaxLength = 32767;
            this.txtEPassword.Name = "txtEPassword";
            this.txtEPassword.PasswordChar = '\0';
            this.txtEPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEPassword.SelectedText = "";
            this.txtEPassword.SelectionLength = 0;
            this.txtEPassword.SelectionStart = 0;
            this.txtEPassword.ShortcutsEnabled = true;
            this.txtEPassword.Size = new System.Drawing.Size(127, 23);
            this.txtEPassword.TabIndex = 17;
            this.txtEPassword.UseSelectable = true;
            this.txtEPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ddlEDepartment
            // 
            this.ddlEDepartment.FormattingEnabled = true;
            this.ddlEDepartment.ItemHeight = 23;
            this.ddlEDepartment.Location = new System.Drawing.Point(93, 241);
            this.ddlEDepartment.Name = "ddlEDepartment";
            this.ddlEDepartment.Size = new System.Drawing.Size(127, 29);
            this.ddlEDepartment.TabIndex = 16;
            this.ddlEDepartment.UseSelectable = true;
            this.ddlEDepartment.SelectedIndexChanged += new System.EventHandler(this.ddlEDepartment_SelectedIndexChanged);
            // 
            // DtpEDob
            // 
            this.DtpEDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEDob.Location = new System.Drawing.Point(93, 203);
            this.DtpEDob.MinimumSize = new System.Drawing.Size(4, 29);
            this.DtpEDob.Name = "DtpEDob";
            this.DtpEDob.Size = new System.Drawing.Size(127, 29);
            this.DtpEDob.TabIndex = 15;
            // 
            // lblEDepartment
            // 
            this.lblEDepartment.BackColor = System.Drawing.Color.White;
            this.lblEDepartment.Location = new System.Drawing.Point(3, 247);
            this.lblEDepartment.Name = "lblEDepartment";
            this.lblEDepartment.Size = new System.Drawing.Size(96, 23);
            this.lblEDepartment.TabIndex = 14;
            this.lblEDepartment.Text = "Department :";
            this.lblEDepartment.UseCustomBackColor = true;
            this.lblEDepartment.UseCustomForeColor = true;
            this.lblEDepartment.UseStyleColors = true;
            // 
            // lblEDob
            // 
            this.lblEDob.BackColor = System.Drawing.Color.White;
            this.lblEDob.Location = new System.Drawing.Point(3, 209);
            this.lblEDob.Name = "lblEDob";
            this.lblEDob.Size = new System.Drawing.Size(52, 23);
            this.lblEDob.TabIndex = 12;
            this.lblEDob.Text = "DOB :";
            this.lblEDob.UseCustomBackColor = true;
            this.lblEDob.UseCustomForeColor = true;
            this.lblEDob.UseStyleColors = true;
            // 
            // txtEEmail
            // 
            // 
            // 
            // 
            this.txtEEmail.CustomButton.Image = null;
            this.txtEEmail.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtEEmail.CustomButton.Name = "";
            this.txtEEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEEmail.CustomButton.TabIndex = 1;
            this.txtEEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEEmail.CustomButton.UseSelectable = true;
            this.txtEEmail.CustomButton.Visible = false;
            this.txtEEmail.Lines = new string[0];
            this.txtEEmail.Location = new System.Drawing.Point(93, 170);
            this.txtEEmail.MaxLength = 32767;
            this.txtEEmail.Name = "txtEEmail";
            this.txtEEmail.PasswordChar = '\0';
            this.txtEEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEEmail.SelectedText = "";
            this.txtEEmail.SelectionLength = 0;
            this.txtEEmail.SelectionStart = 0;
            this.txtEEmail.ShortcutsEnabled = true;
            this.txtEEmail.Size = new System.Drawing.Size(127, 23);
            this.txtEEmail.TabIndex = 10;
            this.txtEEmail.UseSelectable = true;
            this.txtEEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEEmail
            // 
            this.lblEEmail.BackColor = System.Drawing.Color.White;
            this.lblEEmail.Location = new System.Drawing.Point(3, 170);
            this.lblEEmail.Name = "lblEEmail";
            this.lblEEmail.Size = new System.Drawing.Size(55, 23);
            this.lblEEmail.TabIndex = 9;
            this.lblEEmail.Text = "E-mail :";
            this.lblEEmail.UseCustomBackColor = true;
            this.lblEEmail.UseCustomForeColor = true;
            this.lblEEmail.UseStyleColors = true;
            // 
            // lblEDesignation
            // 
            this.lblEDesignation.BackColor = System.Drawing.Color.White;
            this.lblEDesignation.Location = new System.Drawing.Point(3, 135);
            this.lblEDesignation.Name = "lblEDesignation";
            this.lblEDesignation.Size = new System.Drawing.Size(86, 23);
            this.lblEDesignation.TabIndex = 8;
            this.lblEDesignation.Text = "Designation :";
            this.lblEDesignation.UseCustomBackColor = true;
            this.lblEDesignation.UseCustomForeColor = true;
            this.lblEDesignation.UseStyleColors = true;
            // 
            // txtEDesignation
            // 
            // 
            // 
            // 
            this.txtEDesignation.CustomButton.Image = null;
            this.txtEDesignation.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtEDesignation.CustomButton.Name = "";
            this.txtEDesignation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEDesignation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEDesignation.CustomButton.TabIndex = 1;
            this.txtEDesignation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEDesignation.CustomButton.UseSelectable = true;
            this.txtEDesignation.CustomButton.Visible = false;
            this.txtEDesignation.Lines = new string[0];
            this.txtEDesignation.Location = new System.Drawing.Point(93, 135);
            this.txtEDesignation.MaxLength = 32767;
            this.txtEDesignation.Name = "txtEDesignation";
            this.txtEDesignation.PasswordChar = '\0';
            this.txtEDesignation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEDesignation.SelectedText = "";
            this.txtEDesignation.SelectionLength = 0;
            this.txtEDesignation.SelectionStart = 0;
            this.txtEDesignation.ShortcutsEnabled = true;
            this.txtEDesignation.Size = new System.Drawing.Size(127, 23);
            this.txtEDesignation.TabIndex = 7;
            this.txtEDesignation.UseSelectable = true;
            this.txtEDesignation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEDesignation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEName
            // 
            this.lblEName.BackColor = System.Drawing.Color.White;
            this.lblEName.Location = new System.Drawing.Point(3, 40);
            this.lblEName.Name = "lblEName";
            this.lblEName.Size = new System.Drawing.Size(52, 23);
            this.lblEName.TabIndex = 6;
            this.lblEName.Text = "Name :";
            this.lblEName.UseCustomBackColor = true;
            this.lblEName.UseCustomForeColor = true;
            this.lblEName.UseStyleColors = true;
            // 
            // txtEName
            // 
            // 
            // 
            // 
            this.txtEName.CustomButton.Image = null;
            this.txtEName.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtEName.CustomButton.Name = "";
            this.txtEName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEName.CustomButton.TabIndex = 1;
            this.txtEName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEName.CustomButton.UseSelectable = true;
            this.txtEName.CustomButton.Visible = false;
            this.txtEName.Lines = new string[0];
            this.txtEName.Location = new System.Drawing.Point(93, 40);
            this.txtEName.MaxLength = 32767;
            this.txtEName.Name = "txtEName";
            this.txtEName.PasswordChar = '\0';
            this.txtEName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEName.SelectedText = "";
            this.txtEName.SelectionLength = 0;
            this.txtEName.SelectionStart = 0;
            this.txtEName.ShortcutsEnabled = true;
            this.txtEName.Size = new System.Drawing.Size(127, 23);
            this.txtEName.TabIndex = 5;
            this.txtEName.UseSelectable = true;
            this.txtEName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEId
            // 
            // 
            // 
            // 
            this.txtEId.CustomButton.Image = null;
            this.txtEId.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtEId.CustomButton.Name = "";
            this.txtEId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEId.CustomButton.TabIndex = 1;
            this.txtEId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEId.CustomButton.UseSelectable = true;
            this.txtEId.CustomButton.Visible = false;
            this.txtEId.Lines = new string[0];
            this.txtEId.Location = new System.Drawing.Point(93, 11);
            this.txtEId.MaxLength = 32767;
            this.txtEId.Name = "txtEId";
            this.txtEId.PasswordChar = '\0';
            this.txtEId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEId.SelectedText = "";
            this.txtEId.SelectionLength = 0;
            this.txtEId.SelectionStart = 0;
            this.txtEId.ShortcutsEnabled = true;
            this.txtEId.Size = new System.Drawing.Size(127, 23);
            this.txtEId.TabIndex = 3;
            this.txtEId.UseSelectable = true;
            this.txtEId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEId
            // 
            this.lblEId.BackColor = System.Drawing.Color.White;
            this.lblEId.Location = new System.Drawing.Point(3, 11);
            this.lblEId.Name = "lblEId";
            this.lblEId.Size = new System.Drawing.Size(55, 23);
            this.lblEId.TabIndex = 2;
            this.lblEId.Text = "Id :";
            this.lblEId.UseCustomBackColor = true;
            this.lblEId.UseCustomForeColor = true;
            this.lblEId.UseStyleColors = true;
            this.lblEId.Click += new System.EventHandler(this.lblEId_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.metroPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel6, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(608, 337);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.btnERefresh);
            this.metroPanel3.Controls.Add(this.btnEAdd);
            this.metroPanel3.Controls.Add(this.btnEDelete);
            this.metroPanel3.Controls.Add(this.txtESearch);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(602, 44);
            this.metroPanel3.TabIndex = 1;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btnERefresh
            // 
            this.btnERefresh.BackColor = System.Drawing.Color.White;
            this.btnERefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnERefresh.BackgroundImage")));
            this.btnERefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnERefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnERefresh.Location = new System.Drawing.Point(450, 12);
            this.btnERefresh.Name = "btnERefresh";
            this.btnERefresh.Size = new System.Drawing.Size(85, 23);
            this.btnERefresh.TabIndex = 5;
            this.btnERefresh.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnERefresh.UseCustomBackColor = true;
            this.btnERefresh.UseCustomForeColor = true;
            this.btnERefresh.UseSelectable = true;
            this.btnERefresh.UseStyleColors = true;
            this.btnERefresh.Click += new System.EventHandler(this.btnERefresh_Click);
            // 
            // btnEAdd
            // 
            this.btnEAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEAdd.Location = new System.Drawing.Point(237, 12);
            this.btnEAdd.Name = "btnEAdd";
            this.btnEAdd.Size = new System.Drawing.Size(85, 23);
            this.btnEAdd.TabIndex = 4;
            this.btnEAdd.Text = "Add";
            this.btnEAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEAdd.UseCustomBackColor = true;
            this.btnEAdd.UseCustomForeColor = true;
            this.btnEAdd.UseSelectable = true;
            this.btnEAdd.UseStyleColors = true;
            this.btnEAdd.Click += new System.EventHandler(this.btnEAdd_Click);
            // 
            // btnEDelete
            // 
            this.btnEDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEDelete.Location = new System.Drawing.Point(343, 12);
            this.btnEDelete.Name = "btnEDelete";
            this.btnEDelete.Size = new System.Drawing.Size(85, 23);
            this.btnEDelete.TabIndex = 3;
            this.btnEDelete.Text = "Delete";
            this.btnEDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEDelete.UseCustomBackColor = true;
            this.btnEDelete.UseCustomForeColor = true;
            this.btnEDelete.UseSelectable = true;
            this.btnEDelete.UseStyleColors = true;
            this.btnEDelete.Click += new System.EventHandler(this.btnEDelete_Click);
            // 
            // txtESearch
            // 
            // 
            // 
            // 
            this.txtESearch.CustomButton.Image = null;
            this.txtESearch.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtESearch.CustomButton.Name = "";
            this.txtESearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtESearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtESearch.CustomButton.TabIndex = 1;
            this.txtESearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtESearch.CustomButton.UseSelectable = true;
            this.txtESearch.CustomButton.Visible = false;
            this.txtESearch.Lines = new string[0];
            this.txtESearch.Location = new System.Drawing.Point(8, 12);
            this.txtESearch.MaxLength = 32767;
            this.txtESearch.Name = "txtESearch";
            this.txtESearch.PasswordChar = '\0';
            this.txtESearch.PromptText = "Search Employees by Name";
            this.txtESearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtESearch.SelectedText = "";
            this.txtESearch.SelectionLength = 0;
            this.txtESearch.SelectionStart = 0;
            this.txtESearch.ShortcutsEnabled = true;
            this.txtESearch.Size = new System.Drawing.Size(178, 23);
            this.txtESearch.TabIndex = 2;
            this.txtESearch.UseSelectable = true;
            this.txtESearch.WaterMark = "Search Employees by Name";
            this.txtESearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtESearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtESearch.Click += new System.EventHandler(this.txtESearch_Click);
            this.txtESearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtESearch_KeyDown);
            // 
            // metroPanel6
            // 
            this.metroPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel6.Controls.Add(this.GridEmployee);
            this.metroPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(3, 53);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(602, 281);
            this.metroPanel6.TabIndex = 2;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // GridEmployee
            // 
            this.GridEmployee.AllowUserToAddRows = false;
            this.GridEmployee.AllowUserToDeleteRows = false;
            this.GridEmployee.AllowUserToResizeRows = false;
            this.GridEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EId,
            this.EName,
            this.EDesignation,
            this.EDepartment});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridEmployee.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEmployee.EnableHeadersVisualStyles = false;
            this.GridEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridEmployee.Location = new System.Drawing.Point(0, 0);
            this.GridEmployee.Name = "GridEmployee";
            this.GridEmployee.ReadOnly = true;
            this.GridEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEmployee.Size = new System.Drawing.Size(600, 279);
            this.GridEmployee.TabIndex = 2;
            this.GridEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEmployee_CellClick);
            // 
            // EId
            // 
            this.EId.DataPropertyName = "Id";
            this.EId.HeaderText = "ID";
            this.EId.Name = "EId";
            this.EId.ReadOnly = true;
            // 
            // EName
            // 
            this.EName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EName.DataPropertyName = "Name";
            this.EName.HeaderText = "Name";
            this.EName.Name = "EName";
            this.EName.ReadOnly = true;
            // 
            // EDesignation
            // 
            this.EDesignation.DataPropertyName = "Designation";
            this.EDesignation.HeaderText = "Designation";
            this.EDesignation.Name = "EDesignation";
            this.EDesignation.ReadOnly = true;
            this.EDesignation.Width = 150;
            // 
            // EDepartment
            // 
            this.EDepartment.DataPropertyName = "DepartmentName";
            this.EDepartment.HeaderText = "Department";
            this.EDepartment.Name = "EDepartment";
            this.EDepartment.ReadOnly = true;
            // 
            // MtDepartments
            // 
            this.MtDepartments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MtDepartments.Controls.Add(this.metroLabel1);
            this.MtDepartments.Controls.Add(this.txtDeptSearch);
            this.MtDepartments.Controls.Add(this.btnDelete);
            this.MtDepartments.Controls.Add(this.btnSave);
            this.MtDepartments.Controls.Add(this.btnNew);
            this.MtDepartments.Controls.Add(this.txtDeptName);
            this.MtDepartments.Controls.Add(this.txtDeptId);
            this.MtDepartments.Controls.Add(this.lblDeptName);
            this.MtDepartments.Controls.Add(this.lblDeptId);
            this.MtDepartments.Controls.Add(this.dgvDepartment);
            this.MtDepartments.Controls.Add(this.btnDeptRefresh);
            this.MtDepartments.HorizontalScrollbarBarColor = true;
            this.MtDepartments.HorizontalScrollbarHighlightOnWheel = false;
            this.MtDepartments.HorizontalScrollbarSize = 10;
            this.MtDepartments.Location = new System.Drawing.Point(4, 38);
            this.MtDepartments.Name = "MtDepartments";
            this.MtDepartments.Size = new System.Drawing.Size(864, 343);
            this.MtDepartments.TabIndex = 1;
            this.MtDepartments.Text = "Departments";
            this.MtDepartments.VerticalScrollbarBarColor = true;
            this.MtDepartments.VerticalScrollbarHighlightOnWheel = false;
            this.MtDepartments.VerticalScrollbarSize = 10;
            this.MtDepartments.Click += new System.EventHandler(this.MtEmployees_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(132, 33);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Departments ";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtDeptSearch
            // 
            // 
            // 
            // 
            this.txtDeptSearch.CustomButton.Image = null;
            this.txtDeptSearch.CustomButton.Location = new System.Drawing.Point(144, 2);
            this.txtDeptSearch.CustomButton.Name = "";
            this.txtDeptSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDeptSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeptSearch.CustomButton.TabIndex = 1;
            this.txtDeptSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeptSearch.CustomButton.UseSelectable = true;
            this.txtDeptSearch.CustomButton.Visible = false;
            this.txtDeptSearch.Lines = new string[0];
            this.txtDeptSearch.Location = new System.Drawing.Point(173, 12);
            this.txtDeptSearch.MaxLength = 32767;
            this.txtDeptSearch.Name = "txtDeptSearch";
            this.txtDeptSearch.PasswordChar = '\0';
            this.txtDeptSearch.PromptText = "Search Name";
            this.txtDeptSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeptSearch.SelectedText = "";
            this.txtDeptSearch.SelectionLength = 0;
            this.txtDeptSearch.SelectionStart = 0;
            this.txtDeptSearch.ShortcutsEnabled = true;
            this.txtDeptSearch.Size = new System.Drawing.Size(168, 26);
            this.txtDeptSearch.TabIndex = 11;
            this.txtDeptSearch.UseSelectable = true;
            this.txtDeptSearch.WaterMark = "Search Name";
            this.txtDeptSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeptSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeptSearch.TextChanged += new System.EventHandler(this.txtDeptSearch_TextChanged);
            this.txtDeptSearch.Click += new System.EventHandler(this.txtDeptSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(612, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseCustomForeColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseStyleColors = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(604, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(520, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNew.UseCustomBackColor = true;
            this.btnNew.UseCustomForeColor = true;
            this.btnNew.UseSelectable = true;
            this.btnNew.UseStyleColors = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDeptName
            // 
            // 
            // 
            // 
            this.txtDeptName.CustomButton.Image = null;
            this.txtDeptName.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtDeptName.CustomButton.Name = "";
            this.txtDeptName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDeptName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeptName.CustomButton.TabIndex = 1;
            this.txtDeptName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeptName.CustomButton.UseSelectable = true;
            this.txtDeptName.CustomButton.Visible = false;
            this.txtDeptName.Lines = new string[0];
            this.txtDeptName.Location = new System.Drawing.Point(562, 116);
            this.txtDeptName.MaxLength = 32767;
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.PasswordChar = '\0';
            this.txtDeptName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeptName.SelectedText = "";
            this.txtDeptName.SelectionLength = 0;
            this.txtDeptName.SelectionStart = 0;
            this.txtDeptName.ShortcutsEnabled = true;
            this.txtDeptName.Size = new System.Drawing.Size(138, 23);
            this.txtDeptName.TabIndex = 6;
            this.txtDeptName.UseSelectable = true;
            this.txtDeptName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeptName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDeptId
            // 
            // 
            // 
            // 
            this.txtDeptId.CustomButton.Image = null;
            this.txtDeptId.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtDeptId.CustomButton.Name = "";
            this.txtDeptId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDeptId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeptId.CustomButton.TabIndex = 1;
            this.txtDeptId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeptId.CustomButton.UseSelectable = true;
            this.txtDeptId.CustomButton.Visible = false;
            this.txtDeptId.Enabled = false;
            this.txtDeptId.Lines = new string[0];
            this.txtDeptId.Location = new System.Drawing.Point(562, 78);
            this.txtDeptId.MaxLength = 32767;
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.PasswordChar = '\0';
            this.txtDeptId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeptId.SelectedText = "";
            this.txtDeptId.SelectionLength = 0;
            this.txtDeptId.SelectionStart = 0;
            this.txtDeptId.ShortcutsEnabled = true;
            this.txtDeptId.Size = new System.Drawing.Size(138, 23);
            this.txtDeptId.TabIndex = 5;
            this.txtDeptId.UseSelectable = true;
            this.txtDeptId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeptId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(500, 120);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(56, 19);
            this.lblDeptName.TabIndex = 4;
            this.lblDeptName.Text = " Name :";
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.Location = new System.Drawing.Point(454, 78);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(102, 19);
            this.lblDeptId.TabIndex = 3;
            this.lblDeptId.Text = "Department Id :";
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToAddRows = false;
            this.dgvDepartment.AllowUserToDeleteRows = false;
            this.dgvDepartment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dName});
            this.dgvDepartment.Location = new System.Drawing.Point(3, 48);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.ReadOnly = true;
            this.dgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartment.Size = new System.Drawing.Size(338, 314);
            this.dgvDepartment.TabIndex = 2;
            this.dgvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellClick);
            this.dgvDepartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Department Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dName
            // 
            this.dName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dName.DataPropertyName = "Name";
            this.dName.HeaderText = "Department Name";
            this.dName.Name = "dName";
            this.dName.ReadOnly = true;
            // 
            // btnDeptRefresh
            // 
            this.btnDeptRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeptRefresh.BackgroundImage")));
            this.btnDeptRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeptRefresh.Location = new System.Drawing.Point(415, 12);
            this.btnDeptRefresh.Name = "btnDeptRefresh";
            this.btnDeptRefresh.Size = new System.Drawing.Size(86, 23);
            this.btnDeptRefresh.TabIndex = 12;
            this.btnDeptRefresh.UseCustomBackColor = true;
            this.btnDeptRefresh.UseCustomForeColor = true;
            this.btnDeptRefresh.UseSelectable = true;
            this.btnDeptRefresh.UseStyleColors = true;
            this.btnDeptRefresh.Click += new System.EventHandler(this.btnDeptRefresh_Click);
            // 
            // MtBill
            // 
            this.MtBill.Controls.Add(this.btnAddRates);
            this.MtBill.Controls.Add(this.txtDPEXRate);
            this.MtBill.Controls.Add(this.metroLabel7);
            this.MtBill.Controls.Add(this.txtTNTRate);
            this.MtBill.Controls.Add(this.txtDHLRate);
            this.MtBill.Controls.Add(this.metroLabel5);
            this.MtBill.Controls.Add(this.metroLabel6);
            this.MtBill.Controls.Add(this.metroLabel2);
            this.MtBill.Controls.Add(this.metroButton1);
            this.MtBill.Controls.Add(this.txtRateSearch);
            this.MtBill.Controls.Add(this.btnRateSave);
            this.MtBill.Controls.Add(this.txtCountryName);
            this.MtBill.Controls.Add(this.txtRateID);
            this.MtBill.Controls.Add(this.metroLabel3);
            this.MtBill.Controls.Add(this.metroLabel4);
            this.MtBill.Controls.Add(this.dgvRate);
            this.MtBill.HorizontalScrollbarBarColor = true;
            this.MtBill.HorizontalScrollbarHighlightOnWheel = false;
            this.MtBill.HorizontalScrollbarSize = 10;
            this.MtBill.Location = new System.Drawing.Point(4, 38);
            this.MtBill.Name = "MtBill";
            this.MtBill.Size = new System.Drawing.Size(864, 343);
            this.MtBill.TabIndex = 5;
            this.MtBill.Text = "Rates";
            this.MtBill.VerticalScrollbarBarColor = true;
            this.MtBill.VerticalScrollbarHighlightOnWheel = false;
            this.MtBill.VerticalScrollbarSize = 10;
            // 
            // btnAddRates
            // 
            this.btnAddRates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddRates.Location = new System.Drawing.Point(498, 9);
            this.btnAddRates.Name = "btnAddRates";
            this.btnAddRates.Size = new System.Drawing.Size(202, 23);
            this.btnAddRates.TabIndex = 31;
            this.btnAddRates.Text = "Add New Country and Rates";
            this.btnAddRates.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddRates.UseCustomBackColor = true;
            this.btnAddRates.UseCustomForeColor = true;
            this.btnAddRates.UseSelectable = true;
            this.btnAddRates.UseStyleColors = true;
            this.btnAddRates.Click += new System.EventHandler(this.btnAddRates_Click);
            // 
            // txtDPEXRate
            // 
            // 
            // 
            // 
            this.txtDPEXRate.CustomButton.Image = null;
            this.txtDPEXRate.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtDPEXRate.CustomButton.Name = "";
            this.txtDPEXRate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDPEXRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDPEXRate.CustomButton.TabIndex = 1;
            this.txtDPEXRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDPEXRate.CustomButton.UseSelectable = true;
            this.txtDPEXRate.CustomButton.Visible = false;
            this.txtDPEXRate.Lines = new string[0];
            this.txtDPEXRate.Location = new System.Drawing.Point(562, 228);
            this.txtDPEXRate.MaxLength = 32767;
            this.txtDPEXRate.Name = "txtDPEXRate";
            this.txtDPEXRate.PasswordChar = '\0';
            this.txtDPEXRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDPEXRate.SelectedText = "";
            this.txtDPEXRate.SelectionLength = 0;
            this.txtDPEXRate.SelectionStart = 0;
            this.txtDPEXRate.ShortcutsEnabled = true;
            this.txtDPEXRate.Size = new System.Drawing.Size(138, 23);
            this.txtDPEXRate.TabIndex = 30;
            this.txtDPEXRate.UseSelectable = true;
            this.txtDPEXRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDPEXRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(454, 228);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(78, 19);
            this.metroLabel7.TabIndex = 29;
            this.metroLabel7.Text = "DPEX Rate :";
            // 
            // txtTNTRate
            // 
            // 
            // 
            // 
            this.txtTNTRate.CustomButton.Image = null;
            this.txtTNTRate.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtTNTRate.CustomButton.Name = "";
            this.txtTNTRate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTNTRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTNTRate.CustomButton.TabIndex = 1;
            this.txtTNTRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTNTRate.CustomButton.UseSelectable = true;
            this.txtTNTRate.CustomButton.Visible = false;
            this.txtTNTRate.Lines = new string[0];
            this.txtTNTRate.Location = new System.Drawing.Point(562, 190);
            this.txtTNTRate.MaxLength = 32767;
            this.txtTNTRate.Name = "txtTNTRate";
            this.txtTNTRate.PasswordChar = '\0';
            this.txtTNTRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTNTRate.SelectedText = "";
            this.txtTNTRate.SelectionLength = 0;
            this.txtTNTRate.SelectionStart = 0;
            this.txtTNTRate.ShortcutsEnabled = true;
            this.txtTNTRate.Size = new System.Drawing.Size(138, 23);
            this.txtTNTRate.TabIndex = 28;
            this.txtTNTRate.UseSelectable = true;
            this.txtTNTRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTNTRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDHLRate
            // 
            // 
            // 
            // 
            this.txtDHLRate.CustomButton.Image = null;
            this.txtDHLRate.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtDHLRate.CustomButton.Name = "";
            this.txtDHLRate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDHLRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDHLRate.CustomButton.TabIndex = 1;
            this.txtDHLRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDHLRate.CustomButton.UseSelectable = true;
            this.txtDHLRate.CustomButton.Visible = false;
            this.txtDHLRate.Lines = new string[0];
            this.txtDHLRate.Location = new System.Drawing.Point(562, 152);
            this.txtDHLRate.MaxLength = 32767;
            this.txtDHLRate.Name = "txtDHLRate";
            this.txtDHLRate.PasswordChar = '\0';
            this.txtDHLRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDHLRate.SelectedText = "";
            this.txtDHLRate.SelectionLength = 0;
            this.txtDHLRate.SelectionStart = 0;
            this.txtDHLRate.ShortcutsEnabled = true;
            this.txtDHLRate.Size = new System.Drawing.Size(138, 23);
            this.txtDHLRate.TabIndex = 27;
            this.txtDHLRate.UseSelectable = true;
            this.txtDHLRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDHLRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(454, 190);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "TNT Rate :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(454, 152);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(70, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "DHL Rate :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(3, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(132, 33);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Rates";
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(360, 9);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(86, 23);
            this.metroButton1.TabIndex = 23;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtRateSearch
            // 
            // 
            // 
            // 
            this.txtRateSearch.CustomButton.Image = null;
            this.txtRateSearch.CustomButton.Location = new System.Drawing.Point(144, 2);
            this.txtRateSearch.CustomButton.Name = "";
            this.txtRateSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRateSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRateSearch.CustomButton.TabIndex = 1;
            this.txtRateSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRateSearch.CustomButton.UseSelectable = true;
            this.txtRateSearch.CustomButton.Visible = false;
            this.txtRateSearch.Lines = new string[0];
            this.txtRateSearch.Location = new System.Drawing.Point(173, 9);
            this.txtRateSearch.MaxLength = 32767;
            this.txtRateSearch.Name = "txtRateSearch";
            this.txtRateSearch.PasswordChar = '\0';
            this.txtRateSearch.PromptText = "Search by Country";
            this.txtRateSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRateSearch.SelectedText = "";
            this.txtRateSearch.SelectionLength = 0;
            this.txtRateSearch.SelectionStart = 0;
            this.txtRateSearch.ShortcutsEnabled = true;
            this.txtRateSearch.Size = new System.Drawing.Size(168, 26);
            this.txtRateSearch.TabIndex = 22;
            this.txtRateSearch.UseSelectable = true;
            this.txtRateSearch.WaterMark = "Search by Country";
            this.txtRateSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRateSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRateSearch.TextChanged += new System.EventHandler(this.txtRateSearch_TextChanged);
            // 
            // btnRateSave
            // 
            this.btnRateSave.Location = new System.Drawing.Point(604, 286);
            this.btnRateSave.Name = "btnRateSave";
            this.btnRateSave.Size = new System.Drawing.Size(96, 23);
            this.btnRateSave.TabIndex = 20;
            this.btnRateSave.Text = "Save";
            this.btnRateSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRateSave.UseCustomBackColor = true;
            this.btnRateSave.UseCustomForeColor = true;
            this.btnRateSave.UseSelectable = true;
            this.btnRateSave.UseStyleColors = true;
            this.btnRateSave.Click += new System.EventHandler(this.btnRateSave_Click);
            // 
            // txtCountryName
            // 
            // 
            // 
            // 
            this.txtCountryName.CustomButton.Image = null;
            this.txtCountryName.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtCountryName.CustomButton.Name = "";
            this.txtCountryName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCountryName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCountryName.CustomButton.TabIndex = 1;
            this.txtCountryName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCountryName.CustomButton.UseSelectable = true;
            this.txtCountryName.CustomButton.Visible = false;
            this.txtCountryName.Lines = new string[0];
            this.txtCountryName.Location = new System.Drawing.Point(562, 113);
            this.txtCountryName.MaxLength = 32767;
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.PasswordChar = '\0';
            this.txtCountryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCountryName.SelectedText = "";
            this.txtCountryName.SelectionLength = 0;
            this.txtCountryName.SelectionStart = 0;
            this.txtCountryName.ShortcutsEnabled = true;
            this.txtCountryName.Size = new System.Drawing.Size(138, 23);
            this.txtCountryName.TabIndex = 18;
            this.txtCountryName.UseSelectable = true;
            this.txtCountryName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCountryName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRateID
            // 
            // 
            // 
            // 
            this.txtRateID.CustomButton.Image = null;
            this.txtRateID.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtRateID.CustomButton.Name = "";
            this.txtRateID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRateID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRateID.CustomButton.TabIndex = 1;
            this.txtRateID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRateID.CustomButton.UseSelectable = true;
            this.txtRateID.CustomButton.Visible = false;
            this.txtRateID.Lines = new string[0];
            this.txtRateID.Location = new System.Drawing.Point(562, 75);
            this.txtRateID.MaxLength = 32767;
            this.txtRateID.Name = "txtRateID";
            this.txtRateID.PasswordChar = '\0';
            this.txtRateID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRateID.SelectedText = "";
            this.txtRateID.SelectionLength = 0;
            this.txtRateID.SelectionStart = 0;
            this.txtRateID.ShortcutsEnabled = true;
            this.txtRateID.Size = new System.Drawing.Size(138, 23);
            this.txtRateID.TabIndex = 17;
            this.txtRateID.UseSelectable = true;
            this.txtRateID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRateID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(454, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Country Name :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(454, 75);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(27, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Id :";
            // 
            // dgvRate
            // 
            this.dgvRate.AllowUserToAddRows = false;
            this.dgvRate.AllowUserToDeleteRows = false;
            this.dgvRate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvRate.Location = new System.Drawing.Point(3, 45);
            this.dgvRate.Name = "dgvRate";
            this.dgvRate.ReadOnly = true;
            this.dgvRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRate.Size = new System.Drawing.Size(338, 314);
            this.dgvRate.TabIndex = 14;
            this.dgvRate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRate_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RatesID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn2.HeaderText = "Country";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // MtExportDetail
            // 
            this.MtExportDetail.Controls.Add(this.tableLayoutPanel4);
            this.MtExportDetail.HorizontalScrollbarBarColor = true;
            this.MtExportDetail.HorizontalScrollbarHighlightOnWheel = false;
            this.MtExportDetail.HorizontalScrollbarSize = 10;
            this.MtExportDetail.Location = new System.Drawing.Point(4, 38);
            this.MtExportDetail.Name = "MtExportDetail";
            this.MtExportDetail.Size = new System.Drawing.Size(864, 343);
            this.MtExportDetail.TabIndex = 2;
            this.MtExportDetail.Text = "Export Details";
            this.MtExportDetail.VerticalScrollbarBarColor = true;
            this.MtExportDetail.VerticalScrollbarHighlightOnWheel = false;
            this.MtExportDetail.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel4.Controls.Add(this.panelExportDetailSearch, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dgvExport, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(864, 343);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // panelExportDetailSearch
            // 
            this.panelExportDetailSearch.Controls.Add(this.txtIdExport);
            this.panelExportDetailSearch.Controls.Add(this.btnDeleteReqExp);
            this.panelExportDetailSearch.Controls.Add(this.txtDetailAirwayBill);
            this.panelExportDetailSearch.Controls.Add(this.metroLabel61);
            this.panelExportDetailSearch.Controls.Add(this.txtExportSearch);
            this.panelExportDetailSearch.Controls.Add(this.btnExportRequestUpdate);
            this.panelExportDetailSearch.Controls.Add(this.txtDetailMedium);
            this.panelExportDetailSearch.Controls.Add(this.txtDetailParcelType);
            this.panelExportDetailSearch.Controls.Add(this.txtDetailSAddress);
            this.panelExportDetailSearch.Controls.Add(this.metroLabel30);
            this.panelExportDetailSearch.Controls.Add(this.txtDetailRAddress);
            this.panelExportDetailSearch.Controls.Add(this.metroLabel31);
            this.panelExportDetailSearch.Controls.Add(this.txtDetailSContactNo);
            this.panelExportDetailSearch.Controls.Add(this.txtDetailSName);
            this.panelExportDetailSearch.Controls.Add(this.txtDetailRContactNo);
            this.panelExportDetailSearch.Controls.Add(this.txtDetailRCountry);
            this.panelExportDetailSearch.Controls.Add(this.txtDetailRName);
            this.panelExportDetailSearch.Controls.Add(this.metroLabel32);
            this.panelExportDetailSearch.Controls.Add(this.metroLabel33);
            this.panelExportDetailSearch.Controls.Add(this.metroLabel34);
            this.panelExportDetailSearch.Controls.Add(this.metroLabel35);
            this.panelExportDetailSearch.Controls.Add(this.metroLabel36);
            this.panelExportDetailSearch.Controls.Add(this.metroLabel37);
            this.panelExportDetailSearch.Controls.Add(this.metroLabel38);
            this.panelExportDetailSearch.Controls.Add(this.metroLabel39);
            this.panelExportDetailSearch.Controls.Add(this.metroLabel40);
            this.panelExportDetailSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExportDetailSearch.HorizontalScrollbarBarColor = true;
            this.panelExportDetailSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.panelExportDetailSearch.HorizontalScrollbarSize = 10;
            this.panelExportDetailSearch.Location = new System.Drawing.Point(327, 3);
            this.panelExportDetailSearch.Name = "panelExportDetailSearch";
            this.panelExportDetailSearch.Size = new System.Drawing.Size(534, 337);
            this.panelExportDetailSearch.TabIndex = 10;
            this.panelExportDetailSearch.VerticalScrollbarBarColor = true;
            this.panelExportDetailSearch.VerticalScrollbarHighlightOnWheel = false;
            this.panelExportDetailSearch.VerticalScrollbarSize = 10;
            // 
            // txtIdExport
            // 
            // 
            // 
            // 
            this.txtIdExport.CustomButton.Image = null;
            this.txtIdExport.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.txtIdExport.CustomButton.Name = "";
            this.txtIdExport.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdExport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdExport.CustomButton.TabIndex = 1;
            this.txtIdExport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdExport.CustomButton.UseSelectable = true;
            this.txtIdExport.CustomButton.Visible = false;
            this.txtIdExport.Lines = new string[0];
            this.txtIdExport.Location = new System.Drawing.Point(20, 40);
            this.txtIdExport.MaxLength = 32767;
            this.txtIdExport.Name = "txtIdExport";
            this.txtIdExport.PasswordChar = '\0';
            this.txtIdExport.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdExport.SelectedText = "";
            this.txtIdExport.SelectionLength = 0;
            this.txtIdExport.SelectionStart = 0;
            this.txtIdExport.ShortcutsEnabled = true;
            this.txtIdExport.Size = new System.Drawing.Size(63, 23);
            this.txtIdExport.TabIndex = 32;
            this.txtIdExport.UseSelectable = true;
            this.txtIdExport.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdExport.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDeleteReqExp
            // 
            this.btnDeleteReqExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteReqExp.Location = new System.Drawing.Point(301, 11);
            this.btnDeleteReqExp.Name = "btnDeleteReqExp";
            this.btnDeleteReqExp.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteReqExp.TabIndex = 31;
            this.btnDeleteReqExp.Text = "Delete Request";
            this.btnDeleteReqExp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteReqExp.UseCustomBackColor = true;
            this.btnDeleteReqExp.UseCustomForeColor = true;
            this.btnDeleteReqExp.UseSelectable = true;
            this.btnDeleteReqExp.UseStyleColors = true;
            this.btnDeleteReqExp.Click += new System.EventHandler(this.btnDeleteReqExp_Click);
            // 
            // txtDetailAirwayBill
            // 
            // 
            // 
            // 
            this.txtDetailAirwayBill.CustomButton.Image = null;
            this.txtDetailAirwayBill.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtDetailAirwayBill.CustomButton.Name = "";
            this.txtDetailAirwayBill.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetailAirwayBill.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetailAirwayBill.CustomButton.TabIndex = 1;
            this.txtDetailAirwayBill.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetailAirwayBill.CustomButton.UseSelectable = true;
            this.txtDetailAirwayBill.CustomButton.Visible = false;
            this.txtDetailAirwayBill.Lines = new string[0];
            this.txtDetailAirwayBill.Location = new System.Drawing.Point(254, 314);
            this.txtDetailAirwayBill.MaxLength = 32767;
            this.txtDetailAirwayBill.Name = "txtDetailAirwayBill";
            this.txtDetailAirwayBill.PasswordChar = '\0';
            this.txtDetailAirwayBill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailAirwayBill.SelectedText = "";
            this.txtDetailAirwayBill.SelectionLength = 0;
            this.txtDetailAirwayBill.SelectionStart = 0;
            this.txtDetailAirwayBill.ShortcutsEnabled = true;
            this.txtDetailAirwayBill.Size = new System.Drawing.Size(142, 23);
            this.txtDetailAirwayBill.TabIndex = 30;
            this.txtDetailAirwayBill.UseSelectable = true;
            this.txtDetailAirwayBill.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetailAirwayBill.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel61
            // 
            this.metroLabel61.Location = new System.Drawing.Point(151, 314);
            this.metroLabel61.Name = "metroLabel61";
            this.metroLabel61.Size = new System.Drawing.Size(113, 23);
            this.metroLabel61.TabIndex = 29;
            this.metroLabel61.Text = "Airway Bill No. :";
            // 
            // txtExportSearch
            // 
            // 
            // 
            // 
            this.txtExportSearch.CustomButton.Image = null;
            this.txtExportSearch.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtExportSearch.CustomButton.Name = "";
            this.txtExportSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtExportSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExportSearch.CustomButton.TabIndex = 1;
            this.txtExportSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExportSearch.CustomButton.UseSelectable = true;
            this.txtExportSearch.CustomButton.Visible = false;
            this.txtExportSearch.Lines = new string[0];
            this.txtExportSearch.Location = new System.Drawing.Point(20, 11);
            this.txtExportSearch.MaxLength = 32767;
            this.txtExportSearch.Name = "txtExportSearch";
            this.txtExportSearch.PasswordChar = '\0';
            this.txtExportSearch.PromptText = "Search Parcel by Airway Bill No.";
            this.txtExportSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExportSearch.SelectedText = "";
            this.txtExportSearch.SelectionLength = 0;
            this.txtExportSearch.SelectionStart = 0;
            this.txtExportSearch.ShortcutsEnabled = true;
            this.txtExportSearch.Size = new System.Drawing.Size(245, 23);
            this.txtExportSearch.TabIndex = 28;
            this.txtExportSearch.UseSelectable = true;
            this.txtExportSearch.WaterMark = "Search Parcel by Airway Bill No.";
            this.txtExportSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExportSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtExportSearch.TextChanged += new System.EventHandler(this.txtExportSearch_TextChanged);
            this.txtExportSearch.Click += new System.EventHandler(this.txtExportSearch_Click);
            // 
            // btnExportRequestUpdate
            // 
            this.btnExportRequestUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExportRequestUpdate.Location = new System.Drawing.Point(416, 11);
            this.btnExportRequestUpdate.Name = "btnExportRequestUpdate";
            this.btnExportRequestUpdate.Size = new System.Drawing.Size(109, 23);
            this.btnExportRequestUpdate.TabIndex = 27;
            this.btnExportRequestUpdate.Text = "Update Request";
            this.btnExportRequestUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnExportRequestUpdate.UseCustomBackColor = true;
            this.btnExportRequestUpdate.UseCustomForeColor = true;
            this.btnExportRequestUpdate.UseSelectable = true;
            this.btnExportRequestUpdate.UseStyleColors = true;
            this.btnExportRequestUpdate.Click += new System.EventHandler(this.btnExportRequestUpdate_Click);
            // 
            // txtDetailMedium
            // 
            // 
            // 
            // 
            this.txtDetailMedium.CustomButton.Image = null;
            this.txtDetailMedium.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtDetailMedium.CustomButton.Name = "";
            this.txtDetailMedium.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetailMedium.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetailMedium.CustomButton.TabIndex = 1;
            this.txtDetailMedium.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetailMedium.CustomButton.UseSelectable = true;
            this.txtDetailMedium.CustomButton.Visible = false;
            this.txtDetailMedium.Lines = new string[0];
            this.txtDetailMedium.Location = new System.Drawing.Point(254, 277);
            this.txtDetailMedium.MaxLength = 32767;
            this.txtDetailMedium.Name = "txtDetailMedium";
            this.txtDetailMedium.PasswordChar = '\0';
            this.txtDetailMedium.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailMedium.SelectedText = "";
            this.txtDetailMedium.SelectionLength = 0;
            this.txtDetailMedium.SelectionStart = 0;
            this.txtDetailMedium.ShortcutsEnabled = true;
            this.txtDetailMedium.Size = new System.Drawing.Size(140, 23);
            this.txtDetailMedium.TabIndex = 25;
            this.txtDetailMedium.UseSelectable = true;
            this.txtDetailMedium.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetailMedium.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDetailParcelType
            // 
            // 
            // 
            // 
            this.txtDetailParcelType.CustomButton.Image = null;
            this.txtDetailParcelType.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtDetailParcelType.CustomButton.Name = "";
            this.txtDetailParcelType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetailParcelType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetailParcelType.CustomButton.TabIndex = 1;
            this.txtDetailParcelType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetailParcelType.CustomButton.UseSelectable = true;
            this.txtDetailParcelType.CustomButton.Visible = false;
            this.txtDetailParcelType.Lines = new string[0];
            this.txtDetailParcelType.Location = new System.Drawing.Point(254, 241);
            this.txtDetailParcelType.MaxLength = 32767;
            this.txtDetailParcelType.Name = "txtDetailParcelType";
            this.txtDetailParcelType.PasswordChar = '\0';
            this.txtDetailParcelType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailParcelType.SelectedText = "";
            this.txtDetailParcelType.SelectionLength = 0;
            this.txtDetailParcelType.SelectionStart = 0;
            this.txtDetailParcelType.ShortcutsEnabled = true;
            this.txtDetailParcelType.Size = new System.Drawing.Size(140, 23);
            this.txtDetailParcelType.TabIndex = 24;
            this.txtDetailParcelType.UseSelectable = true;
            this.txtDetailParcelType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetailParcelType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDetailSAddress
            // 
            // 
            // 
            // 
            this.txtDetailSAddress.CustomButton.Image = null;
            this.txtDetailSAddress.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtDetailSAddress.CustomButton.Name = "";
            this.txtDetailSAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetailSAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetailSAddress.CustomButton.TabIndex = 1;
            this.txtDetailSAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetailSAddress.CustomButton.UseSelectable = true;
            this.txtDetailSAddress.CustomButton.Visible = false;
            this.txtDetailSAddress.Lines = new string[0];
            this.txtDetailSAddress.Location = new System.Drawing.Point(364, 172);
            this.txtDetailSAddress.MaxLength = 32767;
            this.txtDetailSAddress.Name = "txtDetailSAddress";
            this.txtDetailSAddress.PasswordChar = '\0';
            this.txtDetailSAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailSAddress.SelectedText = "";
            this.txtDetailSAddress.SelectionLength = 0;
            this.txtDetailSAddress.SelectionStart = 0;
            this.txtDetailSAddress.ShortcutsEnabled = true;
            this.txtDetailSAddress.Size = new System.Drawing.Size(163, 23);
            this.txtDetailSAddress.TabIndex = 23;
            this.txtDetailSAddress.UseSelectable = true;
            this.txtDetailSAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetailSAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel30
            // 
            this.metroLabel30.AutoSize = true;
            this.metroLabel30.Location = new System.Drawing.Point(280, 172);
            this.metroLabel30.Name = "metroLabel30";
            this.metroLabel30.Size = new System.Drawing.Size(63, 19);
            this.metroLabel30.TabIndex = 22;
            this.metroLabel30.Text = "Address :";
            // 
            // txtDetailRAddress
            // 
            // 
            // 
            // 
            this.txtDetailRAddress.CustomButton.Image = null;
            this.txtDetailRAddress.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtDetailRAddress.CustomButton.Name = "";
            this.txtDetailRAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetailRAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetailRAddress.CustomButton.TabIndex = 1;
            this.txtDetailRAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetailRAddress.CustomButton.UseSelectable = true;
            this.txtDetailRAddress.CustomButton.Visible = false;
            this.txtDetailRAddress.Lines = new string[0];
            this.txtDetailRAddress.Location = new System.Drawing.Point(89, 208);
            this.txtDetailRAddress.MaxLength = 32767;
            this.txtDetailRAddress.Name = "txtDetailRAddress";
            this.txtDetailRAddress.PasswordChar = '\0';
            this.txtDetailRAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailRAddress.SelectedText = "";
            this.txtDetailRAddress.SelectionLength = 0;
            this.txtDetailRAddress.SelectionStart = 0;
            this.txtDetailRAddress.ShortcutsEnabled = true;
            this.txtDetailRAddress.Size = new System.Drawing.Size(163, 23);
            this.txtDetailRAddress.TabIndex = 21;
            this.txtDetailRAddress.UseSelectable = true;
            this.txtDetailRAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetailRAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel31
            // 
            this.metroLabel31.AutoSize = true;
            this.metroLabel31.Location = new System.Drawing.Point(20, 208);
            this.metroLabel31.Name = "metroLabel31";
            this.metroLabel31.Size = new System.Drawing.Size(63, 19);
            this.metroLabel31.TabIndex = 20;
            this.metroLabel31.Text = "Address :";
            // 
            // txtDetailSContactNo
            // 
            // 
            // 
            // 
            this.txtDetailSContactNo.CustomButton.Image = null;
            this.txtDetailSContactNo.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtDetailSContactNo.CustomButton.Name = "";
            this.txtDetailSContactNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetailSContactNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetailSContactNo.CustomButton.TabIndex = 1;
            this.txtDetailSContactNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetailSContactNo.CustomButton.UseSelectable = true;
            this.txtDetailSContactNo.CustomButton.Visible = false;
            this.txtDetailSContactNo.Lines = new string[0];
            this.txtDetailSContactNo.Location = new System.Drawing.Point(364, 136);
            this.txtDetailSContactNo.MaxLength = 32767;
            this.txtDetailSContactNo.Name = "txtDetailSContactNo";
            this.txtDetailSContactNo.PasswordChar = '\0';
            this.txtDetailSContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailSContactNo.SelectedText = "";
            this.txtDetailSContactNo.SelectionLength = 0;
            this.txtDetailSContactNo.SelectionStart = 0;
            this.txtDetailSContactNo.ShortcutsEnabled = true;
            this.txtDetailSContactNo.Size = new System.Drawing.Size(163, 23);
            this.txtDetailSContactNo.TabIndex = 19;
            this.txtDetailSContactNo.UseSelectable = true;
            this.txtDetailSContactNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetailSContactNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDetailSName
            // 
            // 
            // 
            // 
            this.txtDetailSName.CustomButton.Image = null;
            this.txtDetailSName.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtDetailSName.CustomButton.Name = "";
            this.txtDetailSName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetailSName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetailSName.CustomButton.TabIndex = 1;
            this.txtDetailSName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetailSName.CustomButton.UseSelectable = true;
            this.txtDetailSName.CustomButton.Visible = false;
            this.txtDetailSName.Lines = new string[0];
            this.txtDetailSName.Location = new System.Drawing.Point(364, 98);
            this.txtDetailSName.MaxLength = 32767;
            this.txtDetailSName.Name = "txtDetailSName";
            this.txtDetailSName.PasswordChar = '\0';
            this.txtDetailSName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailSName.SelectedText = "";
            this.txtDetailSName.SelectionLength = 0;
            this.txtDetailSName.SelectionStart = 0;
            this.txtDetailSName.ShortcutsEnabled = true;
            this.txtDetailSName.Size = new System.Drawing.Size(163, 23);
            this.txtDetailSName.TabIndex = 17;
            this.txtDetailSName.UseSelectable = true;
            this.txtDetailSName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetailSName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDetailRContactNo
            // 
            // 
            // 
            // 
            this.txtDetailRContactNo.CustomButton.Image = null;
            this.txtDetailRContactNo.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtDetailRContactNo.CustomButton.Name = "";
            this.txtDetailRContactNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetailRContactNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetailRContactNo.CustomButton.TabIndex = 1;
            this.txtDetailRContactNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetailRContactNo.CustomButton.UseSelectable = true;
            this.txtDetailRContactNo.CustomButton.Visible = false;
            this.txtDetailRContactNo.Lines = new string[0];
            this.txtDetailRContactNo.Location = new System.Drawing.Point(104, 172);
            this.txtDetailRContactNo.MaxLength = 32767;
            this.txtDetailRContactNo.Name = "txtDetailRContactNo";
            this.txtDetailRContactNo.PasswordChar = '\0';
            this.txtDetailRContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailRContactNo.SelectedText = "";
            this.txtDetailRContactNo.SelectionLength = 0;
            this.txtDetailRContactNo.SelectionStart = 0;
            this.txtDetailRContactNo.ShortcutsEnabled = true;
            this.txtDetailRContactNo.Size = new System.Drawing.Size(148, 23);
            this.txtDetailRContactNo.TabIndex = 16;
            this.txtDetailRContactNo.UseSelectable = true;
            this.txtDetailRContactNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetailRContactNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDetailRCountry
            // 
            // 
            // 
            // 
            this.txtDetailRCountry.CustomButton.Image = null;
            this.txtDetailRCountry.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtDetailRCountry.CustomButton.Name = "";
            this.txtDetailRCountry.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetailRCountry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetailRCountry.CustomButton.TabIndex = 1;
            this.txtDetailRCountry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetailRCountry.CustomButton.UseSelectable = true;
            this.txtDetailRCountry.CustomButton.Visible = false;
            this.txtDetailRCountry.Lines = new string[0];
            this.txtDetailRCountry.Location = new System.Drawing.Point(89, 136);
            this.txtDetailRCountry.MaxLength = 32767;
            this.txtDetailRCountry.Name = "txtDetailRCountry";
            this.txtDetailRCountry.PasswordChar = '\0';
            this.txtDetailRCountry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailRCountry.SelectedText = "";
            this.txtDetailRCountry.SelectionLength = 0;
            this.txtDetailRCountry.SelectionStart = 0;
            this.txtDetailRCountry.ShortcutsEnabled = true;
            this.txtDetailRCountry.Size = new System.Drawing.Size(163, 23);
            this.txtDetailRCountry.TabIndex = 14;
            this.txtDetailRCountry.UseSelectable = true;
            this.txtDetailRCountry.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetailRCountry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDetailRName
            // 
            // 
            // 
            // 
            this.txtDetailRName.CustomButton.Image = null;
            this.txtDetailRName.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtDetailRName.CustomButton.Name = "";
            this.txtDetailRName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetailRName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetailRName.CustomButton.TabIndex = 1;
            this.txtDetailRName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetailRName.CustomButton.UseSelectable = true;
            this.txtDetailRName.CustomButton.Visible = false;
            this.txtDetailRName.Lines = new string[0];
            this.txtDetailRName.Location = new System.Drawing.Point(89, 102);
            this.txtDetailRName.MaxLength = 32767;
            this.txtDetailRName.Name = "txtDetailRName";
            this.txtDetailRName.PasswordChar = '\0';
            this.txtDetailRName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailRName.SelectedText = "";
            this.txtDetailRName.SelectionLength = 0;
            this.txtDetailRName.SelectionStart = 0;
            this.txtDetailRName.ShortcutsEnabled = true;
            this.txtDetailRName.Size = new System.Drawing.Size(163, 23);
            this.txtDetailRName.TabIndex = 13;
            this.txtDetailRName.UseSelectable = true;
            this.txtDetailRName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetailRName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel32
            // 
            this.metroLabel32.Location = new System.Drawing.Point(151, 277);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(86, 23);
            this.metroLabel32.TabIndex = 12;
            this.metroLabel32.Text = "Medium :";
            // 
            // metroLabel33
            // 
            this.metroLabel33.Location = new System.Drawing.Point(151, 241);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(86, 23);
            this.metroLabel33.TabIndex = 11;
            this.metroLabel33.Text = "Parcel Type :";
            // 
            // metroLabel34
            // 
            this.metroLabel34.AutoSize = true;
            this.metroLabel34.Location = new System.Drawing.Point(280, 136);
            this.metroLabel34.Name = "metroLabel34";
            this.metroLabel34.Size = new System.Drawing.Size(86, 19);
            this.metroLabel34.TabIndex = 10;
            this.metroLabel34.Text = "Contact No. :";
            // 
            // metroLabel35
            // 
            this.metroLabel35.AutoSize = true;
            this.metroLabel35.Location = new System.Drawing.Point(280, 102);
            this.metroLabel35.Name = "metroLabel35";
            this.metroLabel35.Size = new System.Drawing.Size(52, 19);
            this.metroLabel35.TabIndex = 8;
            this.metroLabel35.Text = "Name :";
            // 
            // metroLabel36
            // 
            this.metroLabel36.Location = new System.Drawing.Point(20, 172);
            this.metroLabel36.Name = "metroLabel36";
            this.metroLabel36.Size = new System.Drawing.Size(86, 23);
            this.metroLabel36.TabIndex = 7;
            this.metroLabel36.Text = "Contact No. :";
            // 
            // metroLabel37
            // 
            this.metroLabel37.AutoSize = true;
            this.metroLabel37.Location = new System.Drawing.Point(20, 136);
            this.metroLabel37.Name = "metroLabel37";
            this.metroLabel37.Size = new System.Drawing.Size(63, 19);
            this.metroLabel37.TabIndex = 5;
            this.metroLabel37.Text = "Country :";
            // 
            // metroLabel38
            // 
            this.metroLabel38.Location = new System.Drawing.Point(20, 102);
            this.metroLabel38.Name = "metroLabel38";
            this.metroLabel38.Size = new System.Drawing.Size(52, 23);
            this.metroLabel38.TabIndex = 4;
            this.metroLabel38.Text = "Name :";
            // 
            // metroLabel39
            // 
            this.metroLabel39.AutoSize = true;
            this.metroLabel39.Location = new System.Drawing.Point(271, 64);
            this.metroLabel39.Name = "metroLabel39";
            this.metroLabel39.Size = new System.Drawing.Size(125, 19);
            this.metroLabel39.TabIndex = 3;
            this.metroLabel39.Text = "Sender Information,";
            // 
            // metroLabel40
            // 
            this.metroLabel40.AutoSize = true;
            this.metroLabel40.Location = new System.Drawing.Point(20, 64);
            this.metroLabel40.Name = "metroLabel40";
            this.metroLabel40.Size = new System.Drawing.Size(133, 19);
            this.metroLabel40.TabIndex = 2;
            this.metroLabel40.Text = "Receiver Information,";
            // 
            // dgvExport
            // 
            this.dgvExport.AllowUserToAddRows = false;
            this.dgvExport.AllowUserToDeleteRows = false;
            this.dgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExport.Location = new System.Drawing.Point(3, 3);
            this.dgvExport.Name = "dgvExport";
            this.dgvExport.ReadOnly = true;
            this.dgvExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExport.Size = new System.Drawing.Size(318, 337);
            this.dgvExport.TabIndex = 2;
            this.dgvExport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExport_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = " Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ParcelType";
            this.dataGridViewTextBoxColumn4.HeaderText = "Parcel Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Medium";
            this.dataGridViewTextBoxColumn5.HeaderText = "Medium";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // MtImportDetail
            // 
            this.MtImportDetail.Controls.Add(this.tableLayoutPanel5);
            this.MtImportDetail.HorizontalScrollbarBarColor = true;
            this.MtImportDetail.HorizontalScrollbarHighlightOnWheel = false;
            this.MtImportDetail.HorizontalScrollbarSize = 10;
            this.MtImportDetail.Location = new System.Drawing.Point(4, 38);
            this.MtImportDetail.Name = "MtImportDetail";
            this.MtImportDetail.Size = new System.Drawing.Size(864, 343);
            this.MtImportDetail.TabIndex = 3;
            this.MtImportDetail.Text = "Import Details";
            this.MtImportDetail.VerticalScrollbarBarColor = true;
            this.MtImportDetail.VerticalScrollbarHighlightOnWheel = false;
            this.MtImportDetail.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel5.Controls.Add(this.metroPanel7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dgvImport, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(864, 343);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // metroPanel7
            // 
            this.metroPanel7.Controls.Add(this.lblIsArrived);
            this.metroPanel7.Controls.Add(this.txtIdImport);
            this.metroPanel7.Controls.Add(this.txtDetailArrived);
            this.metroPanel7.Controls.Add(this.lblArrived);
            this.metroPanel7.Controls.Add(this.btnDeleteImp);
            this.metroPanel7.Controls.Add(this.txtSDetailAirwayBill2I);
            this.metroPanel7.Controls.Add(this.metroLabel41);
            this.metroPanel7.Controls.Add(this.txtSDetailMedium2I);
            this.metroPanel7.Controls.Add(this.txtDetailParcelType2I);
            this.metroPanel7.Controls.Add(this.txtRDetailAddress2I);
            this.metroPanel7.Controls.Add(this.metroLabel52);
            this.metroPanel7.Controls.Add(this.txtSDetailContact2I);
            this.metroPanel7.Controls.Add(this.txtSDetailName2I);
            this.metroPanel7.Controls.Add(this.txtRDetailContact2I);
            this.metroPanel7.Controls.Add(this.txtRDetailName2I);
            this.metroPanel7.Controls.Add(this.metroLabel53);
            this.metroPanel7.Controls.Add(this.metroLabel54);
            this.metroPanel7.Controls.Add(this.metroLabel55);
            this.metroPanel7.Controls.Add(this.metroLabel56);
            this.metroPanel7.Controls.Add(this.metroLabel57);
            this.metroPanel7.Controls.Add(this.metroLabel58);
            this.metroPanel7.Controls.Add(this.metroLabel59);
            this.metroPanel7.Controls.Add(this.metroLabel60);
            this.metroPanel7.Controls.Add(this.txtSearchImport);
            this.metroPanel7.Controls.Add(this.btnUpdateReqImport);
            this.metroPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(327, 3);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(534, 337);
            this.metroPanel7.TabIndex = 11;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            this.metroPanel7.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel7_Paint);
            // 
            // txtIdImport
            // 
            // 
            // 
            // 
            this.txtIdImport.CustomButton.Image = null;
            this.txtIdImport.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.txtIdImport.CustomButton.Name = "";
            this.txtIdImport.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdImport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdImport.CustomButton.TabIndex = 1;
            this.txtIdImport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdImport.CustomButton.UseSelectable = true;
            this.txtIdImport.CustomButton.Visible = false;
            this.txtIdImport.Lines = new string[0];
            this.txtIdImport.Location = new System.Drawing.Point(20, 40);
            this.txtIdImport.MaxLength = 32767;
            this.txtIdImport.Name = "txtIdImport";
            this.txtIdImport.PasswordChar = '\0';
            this.txtIdImport.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdImport.SelectedText = "";
            this.txtIdImport.SelectionLength = 0;
            this.txtIdImport.SelectionStart = 0;
            this.txtIdImport.ShortcutsEnabled = true;
            this.txtIdImport.Size = new System.Drawing.Size(63, 23);
            this.txtIdImport.TabIndex = 52;
            this.txtIdImport.UseSelectable = true;
            this.txtIdImport.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdImport.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDetailArrived
            // 
            // 
            // 
            // 
            this.txtDetailArrived.CustomButton.Image = null;
            this.txtDetailArrived.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtDetailArrived.CustomButton.Name = "";
            this.txtDetailArrived.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetailArrived.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetailArrived.CustomButton.TabIndex = 1;
            this.txtDetailArrived.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetailArrived.CustomButton.UseSelectable = true;
            this.txtDetailArrived.CustomButton.Visible = false;
            this.txtDetailArrived.Lines = new string[0];
            this.txtDetailArrived.Location = new System.Drawing.Point(104, 297);
            this.txtDetailArrived.MaxLength = 32767;
            this.txtDetailArrived.Name = "txtDetailArrived";
            this.txtDetailArrived.PasswordChar = '\0';
            this.txtDetailArrived.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailArrived.SelectedText = "";
            this.txtDetailArrived.SelectionLength = 0;
            this.txtDetailArrived.SelectionStart = 0;
            this.txtDetailArrived.ShortcutsEnabled = true;
            this.txtDetailArrived.Size = new System.Drawing.Size(140, 23);
            this.txtDetailArrived.TabIndex = 51;
            this.txtDetailArrived.UseSelectable = true;
            this.txtDetailArrived.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetailArrived.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblArrived
            // 
            this.lblArrived.Location = new System.Drawing.Point(12, 297);
            this.lblArrived.Name = "lblArrived";
            this.lblArrived.Size = new System.Drawing.Size(86, 23);
            this.lblArrived.TabIndex = 50;
            this.lblArrived.Text = "Arrived :";
            // 
            // btnDeleteImp
            // 
            this.btnDeleteImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteImp.Location = new System.Drawing.Point(311, 11);
            this.btnDeleteImp.Name = "btnDeleteImp";
            this.btnDeleteImp.Size = new System.Drawing.Size(104, 23);
            this.btnDeleteImp.TabIndex = 49;
            this.btnDeleteImp.Text = "Delete Request";
            this.btnDeleteImp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteImp.UseCustomBackColor = true;
            this.btnDeleteImp.UseCustomForeColor = true;
            this.btnDeleteImp.UseSelectable = true;
            this.btnDeleteImp.UseStyleColors = true;
            this.btnDeleteImp.Click += new System.EventHandler(this.btnDeleteImp_Click);
            // 
            // txtSDetailAirwayBill2I
            // 
            // 
            // 
            // 
            this.txtSDetailAirwayBill2I.CustomButton.Image = null;
            this.txtSDetailAirwayBill2I.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtSDetailAirwayBill2I.CustomButton.Name = "";
            this.txtSDetailAirwayBill2I.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSDetailAirwayBill2I.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSDetailAirwayBill2I.CustomButton.TabIndex = 1;
            this.txtSDetailAirwayBill2I.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSDetailAirwayBill2I.CustomButton.UseSelectable = true;
            this.txtSDetailAirwayBill2I.CustomButton.Visible = false;
            this.txtSDetailAirwayBill2I.Lines = new string[0];
            this.txtSDetailAirwayBill2I.Location = new System.Drawing.Point(120, 219);
            this.txtSDetailAirwayBill2I.MaxLength = 32767;
            this.txtSDetailAirwayBill2I.Name = "txtSDetailAirwayBill2I";
            this.txtSDetailAirwayBill2I.PasswordChar = '\0';
            this.txtSDetailAirwayBill2I.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSDetailAirwayBill2I.SelectedText = "";
            this.txtSDetailAirwayBill2I.SelectionLength = 0;
            this.txtSDetailAirwayBill2I.SelectionStart = 0;
            this.txtSDetailAirwayBill2I.ShortcutsEnabled = true;
            this.txtSDetailAirwayBill2I.Size = new System.Drawing.Size(164, 23);
            this.txtSDetailAirwayBill2I.TabIndex = 48;
            this.txtSDetailAirwayBill2I.UseSelectable = true;
            this.txtSDetailAirwayBill2I.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSDetailAirwayBill2I.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel41
            // 
            this.metroLabel41.AutoSize = true;
            this.metroLabel41.Location = new System.Drawing.Point(12, 219);
            this.metroLabel41.Name = "metroLabel41";
            this.metroLabel41.Size = new System.Drawing.Size(102, 19);
            this.metroLabel41.TabIndex = 47;
            this.metroLabel41.Text = "Airway Bill No. :";
            // 
            // txtSDetailMedium2I
            // 
            // 
            // 
            // 
            this.txtSDetailMedium2I.CustomButton.Image = null;
            this.txtSDetailMedium2I.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtSDetailMedium2I.CustomButton.Name = "";
            this.txtSDetailMedium2I.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSDetailMedium2I.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSDetailMedium2I.CustomButton.TabIndex = 1;
            this.txtSDetailMedium2I.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSDetailMedium2I.CustomButton.UseSelectable = true;
            this.txtSDetailMedium2I.CustomButton.Visible = false;
            this.txtSDetailMedium2I.Lines = new string[0];
            this.txtSDetailMedium2I.Location = new System.Drawing.Point(96, 182);
            this.txtSDetailMedium2I.MaxLength = 32767;
            this.txtSDetailMedium2I.Name = "txtSDetailMedium2I";
            this.txtSDetailMedium2I.PasswordChar = '\0';
            this.txtSDetailMedium2I.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSDetailMedium2I.SelectedText = "";
            this.txtSDetailMedium2I.SelectionLength = 0;
            this.txtSDetailMedium2I.SelectionStart = 0;
            this.txtSDetailMedium2I.ShortcutsEnabled = true;
            this.txtSDetailMedium2I.Size = new System.Drawing.Size(140, 23);
            this.txtSDetailMedium2I.TabIndex = 46;
            this.txtSDetailMedium2I.UseSelectable = true;
            this.txtSDetailMedium2I.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSDetailMedium2I.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDetailParcelType2I
            // 
            // 
            // 
            // 
            this.txtDetailParcelType2I.CustomButton.Image = null;
            this.txtDetailParcelType2I.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtDetailParcelType2I.CustomButton.Name = "";
            this.txtDetailParcelType2I.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetailParcelType2I.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetailParcelType2I.CustomButton.TabIndex = 1;
            this.txtDetailParcelType2I.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetailParcelType2I.CustomButton.UseSelectable = true;
            this.txtDetailParcelType2I.CustomButton.Visible = false;
            this.txtDetailParcelType2I.Lines = new string[0];
            this.txtDetailParcelType2I.Location = new System.Drawing.Point(104, 261);
            this.txtDetailParcelType2I.MaxLength = 32767;
            this.txtDetailParcelType2I.Name = "txtDetailParcelType2I";
            this.txtDetailParcelType2I.PasswordChar = '\0';
            this.txtDetailParcelType2I.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailParcelType2I.SelectedText = "";
            this.txtDetailParcelType2I.SelectionLength = 0;
            this.txtDetailParcelType2I.SelectionStart = 0;
            this.txtDetailParcelType2I.ShortcutsEnabled = true;
            this.txtDetailParcelType2I.Size = new System.Drawing.Size(140, 23);
            this.txtDetailParcelType2I.TabIndex = 45;
            this.txtDetailParcelType2I.UseSelectable = true;
            this.txtDetailParcelType2I.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetailParcelType2I.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRDetailAddress2I
            // 
            // 
            // 
            // 
            this.txtRDetailAddress2I.CustomButton.Image = null;
            this.txtRDetailAddress2I.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtRDetailAddress2I.CustomButton.Name = "";
            this.txtRDetailAddress2I.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRDetailAddress2I.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRDetailAddress2I.CustomButton.TabIndex = 1;
            this.txtRDetailAddress2I.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRDetailAddress2I.CustomButton.UseSelectable = true;
            this.txtRDetailAddress2I.CustomButton.Visible = false;
            this.txtRDetailAddress2I.Lines = new string[0];
            this.txtRDetailAddress2I.Location = new System.Drawing.Point(369, 182);
            this.txtRDetailAddress2I.MaxLength = 32767;
            this.txtRDetailAddress2I.Name = "txtRDetailAddress2I";
            this.txtRDetailAddress2I.PasswordChar = '\0';
            this.txtRDetailAddress2I.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRDetailAddress2I.SelectedText = "";
            this.txtRDetailAddress2I.SelectionLength = 0;
            this.txtRDetailAddress2I.SelectionStart = 0;
            this.txtRDetailAddress2I.ShortcutsEnabled = true;
            this.txtRDetailAddress2I.Size = new System.Drawing.Size(162, 23);
            this.txtRDetailAddress2I.TabIndex = 42;
            this.txtRDetailAddress2I.UseSelectable = true;
            this.txtRDetailAddress2I.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRDetailAddress2I.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel52
            // 
            this.metroLabel52.AutoSize = true;
            this.metroLabel52.Location = new System.Drawing.Point(300, 182);
            this.metroLabel52.Name = "metroLabel52";
            this.metroLabel52.Size = new System.Drawing.Size(63, 19);
            this.metroLabel52.TabIndex = 41;
            this.metroLabel52.Text = "Address :";
            // 
            // txtSDetailContact2I
            // 
            // 
            // 
            // 
            this.txtSDetailContact2I.CustomButton.Image = null;
            this.txtSDetailContact2I.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtSDetailContact2I.CustomButton.Name = "";
            this.txtSDetailContact2I.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSDetailContact2I.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSDetailContact2I.CustomButton.TabIndex = 1;
            this.txtSDetailContact2I.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSDetailContact2I.CustomButton.UseSelectable = true;
            this.txtSDetailContact2I.CustomButton.Visible = false;
            this.txtSDetailContact2I.Lines = new string[0];
            this.txtSDetailContact2I.Location = new System.Drawing.Point(96, 146);
            this.txtSDetailContact2I.MaxLength = 32767;
            this.txtSDetailContact2I.Name = "txtSDetailContact2I";
            this.txtSDetailContact2I.PasswordChar = '\0';
            this.txtSDetailContact2I.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSDetailContact2I.SelectedText = "";
            this.txtSDetailContact2I.SelectionLength = 0;
            this.txtSDetailContact2I.SelectionStart = 0;
            this.txtSDetailContact2I.ShortcutsEnabled = true;
            this.txtSDetailContact2I.Size = new System.Drawing.Size(163, 23);
            this.txtSDetailContact2I.TabIndex = 40;
            this.txtSDetailContact2I.UseSelectable = true;
            this.txtSDetailContact2I.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSDetailContact2I.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSDetailName2I
            // 
            // 
            // 
            // 
            this.txtSDetailName2I.CustomButton.Image = null;
            this.txtSDetailName2I.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtSDetailName2I.CustomButton.Name = "";
            this.txtSDetailName2I.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSDetailName2I.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSDetailName2I.CustomButton.TabIndex = 1;
            this.txtSDetailName2I.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSDetailName2I.CustomButton.UseSelectable = true;
            this.txtSDetailName2I.CustomButton.Visible = false;
            this.txtSDetailName2I.Lines = new string[0];
            this.txtSDetailName2I.Location = new System.Drawing.Point(96, 108);
            this.txtSDetailName2I.MaxLength = 32767;
            this.txtSDetailName2I.Name = "txtSDetailName2I";
            this.txtSDetailName2I.PasswordChar = '\0';
            this.txtSDetailName2I.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSDetailName2I.SelectedText = "";
            this.txtSDetailName2I.SelectionLength = 0;
            this.txtSDetailName2I.SelectionStart = 0;
            this.txtSDetailName2I.ShortcutsEnabled = true;
            this.txtSDetailName2I.Size = new System.Drawing.Size(163, 23);
            this.txtSDetailName2I.TabIndex = 39;
            this.txtSDetailName2I.UseSelectable = true;
            this.txtSDetailName2I.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSDetailName2I.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRDetailContact2I
            // 
            // 
            // 
            // 
            this.txtRDetailContact2I.CustomButton.Image = null;
            this.txtRDetailContact2I.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtRDetailContact2I.CustomButton.Name = "";
            this.txtRDetailContact2I.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRDetailContact2I.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRDetailContact2I.CustomButton.TabIndex = 1;
            this.txtRDetailContact2I.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRDetailContact2I.CustomButton.UseSelectable = true;
            this.txtRDetailContact2I.CustomButton.Visible = false;
            this.txtRDetailContact2I.Lines = new string[0];
            this.txtRDetailContact2I.Location = new System.Drawing.Point(382, 146);
            this.txtRDetailContact2I.MaxLength = 32767;
            this.txtRDetailContact2I.Name = "txtRDetailContact2I";
            this.txtRDetailContact2I.PasswordChar = '\0';
            this.txtRDetailContact2I.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRDetailContact2I.SelectedText = "";
            this.txtRDetailContact2I.SelectionLength = 0;
            this.txtRDetailContact2I.SelectionStart = 0;
            this.txtRDetailContact2I.ShortcutsEnabled = true;
            this.txtRDetailContact2I.Size = new System.Drawing.Size(149, 23);
            this.txtRDetailContact2I.TabIndex = 38;
            this.txtRDetailContact2I.UseSelectable = true;
            this.txtRDetailContact2I.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRDetailContact2I.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRDetailName2I
            // 
            // 
            // 
            // 
            this.txtRDetailName2I.CustomButton.Image = null;
            this.txtRDetailName2I.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtRDetailName2I.CustomButton.Name = "";
            this.txtRDetailName2I.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRDetailName2I.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRDetailName2I.CustomButton.TabIndex = 1;
            this.txtRDetailName2I.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRDetailName2I.CustomButton.UseSelectable = true;
            this.txtRDetailName2I.CustomButton.Visible = false;
            this.txtRDetailName2I.Lines = new string[0];
            this.txtRDetailName2I.Location = new System.Drawing.Point(369, 108);
            this.txtRDetailName2I.MaxLength = 32767;
            this.txtRDetailName2I.Name = "txtRDetailName2I";
            this.txtRDetailName2I.PasswordChar = '\0';
            this.txtRDetailName2I.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRDetailName2I.SelectedText = "";
            this.txtRDetailName2I.SelectionLength = 0;
            this.txtRDetailName2I.SelectionStart = 0;
            this.txtRDetailName2I.ShortcutsEnabled = true;
            this.txtRDetailName2I.Size = new System.Drawing.Size(162, 23);
            this.txtRDetailName2I.TabIndex = 37;
            this.txtRDetailName2I.UseSelectable = true;
            this.txtRDetailName2I.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRDetailName2I.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel53
            // 
            this.metroLabel53.Location = new System.Drawing.Point(12, 182);
            this.metroLabel53.Name = "metroLabel53";
            this.metroLabel53.Size = new System.Drawing.Size(86, 23);
            this.metroLabel53.TabIndex = 36;
            this.metroLabel53.Text = "Medium :";
            // 
            // metroLabel54
            // 
            this.metroLabel54.Location = new System.Drawing.Point(12, 261);
            this.metroLabel54.Name = "metroLabel54";
            this.metroLabel54.Size = new System.Drawing.Size(86, 23);
            this.metroLabel54.TabIndex = 35;
            this.metroLabel54.Text = "Parcel Type :";
            // 
            // metroLabel55
            // 
            this.metroLabel55.AutoSize = true;
            this.metroLabel55.Location = new System.Drawing.Point(12, 146);
            this.metroLabel55.Name = "metroLabel55";
            this.metroLabel55.Size = new System.Drawing.Size(86, 19);
            this.metroLabel55.TabIndex = 34;
            this.metroLabel55.Text = "Contact No. :";
            // 
            // metroLabel56
            // 
            this.metroLabel56.AutoSize = true;
            this.metroLabel56.Location = new System.Drawing.Point(12, 112);
            this.metroLabel56.Name = "metroLabel56";
            this.metroLabel56.Size = new System.Drawing.Size(52, 19);
            this.metroLabel56.TabIndex = 33;
            this.metroLabel56.Text = "Name :";
            // 
            // metroLabel57
            // 
            this.metroLabel57.Location = new System.Drawing.Point(300, 146);
            this.metroLabel57.Name = "metroLabel57";
            this.metroLabel57.Size = new System.Drawing.Size(86, 23);
            this.metroLabel57.TabIndex = 32;
            this.metroLabel57.Text = "Contact No. :";
            // 
            // metroLabel58
            // 
            this.metroLabel58.Location = new System.Drawing.Point(300, 112);
            this.metroLabel58.Name = "metroLabel58";
            this.metroLabel58.Size = new System.Drawing.Size(52, 23);
            this.metroLabel58.TabIndex = 31;
            this.metroLabel58.Text = "Name :";
            // 
            // metroLabel59
            // 
            this.metroLabel59.AutoSize = true;
            this.metroLabel59.Location = new System.Drawing.Point(3, 74);
            this.metroLabel59.Name = "metroLabel59";
            this.metroLabel59.Size = new System.Drawing.Size(125, 19);
            this.metroLabel59.TabIndex = 30;
            this.metroLabel59.Text = "Sender Information,";
            // 
            // metroLabel60
            // 
            this.metroLabel60.AutoSize = true;
            this.metroLabel60.Location = new System.Drawing.Point(300, 74);
            this.metroLabel60.Name = "metroLabel60";
            this.metroLabel60.Size = new System.Drawing.Size(133, 19);
            this.metroLabel60.TabIndex = 29;
            this.metroLabel60.Text = "Receiver Information,";
            // 
            // txtSearchImport
            // 
            // 
            // 
            // 
            this.txtSearchImport.CustomButton.Image = null;
            this.txtSearchImport.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtSearchImport.CustomButton.Name = "";
            this.txtSearchImport.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchImport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchImport.CustomButton.TabIndex = 1;
            this.txtSearchImport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchImport.CustomButton.UseSelectable = true;
            this.txtSearchImport.CustomButton.Visible = false;
            this.txtSearchImport.Lines = new string[0];
            this.txtSearchImport.Location = new System.Drawing.Point(20, 11);
            this.txtSearchImport.MaxLength = 32767;
            this.txtSearchImport.Name = "txtSearchImport";
            this.txtSearchImport.PasswordChar = '\0';
            this.txtSearchImport.PromptText = "Search Parcel by Airway Bill No.";
            this.txtSearchImport.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchImport.SelectedText = "";
            this.txtSearchImport.SelectionLength = 0;
            this.txtSearchImport.SelectionStart = 0;
            this.txtSearchImport.ShortcutsEnabled = true;
            this.txtSearchImport.Size = new System.Drawing.Size(245, 23);
            this.txtSearchImport.TabIndex = 28;
            this.txtSearchImport.UseSelectable = true;
            this.txtSearchImport.WaterMark = "Search Parcel by Airway Bill No.";
            this.txtSearchImport.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchImport.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchImport.TextChanged += new System.EventHandler(this.txtSearchImport_TextChanged);
            // 
            // btnUpdateReqImport
            // 
            this.btnUpdateReqImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdateReqImport.Location = new System.Drawing.Point(421, 11);
            this.btnUpdateReqImport.Name = "btnUpdateReqImport";
            this.btnUpdateReqImport.Size = new System.Drawing.Size(104, 23);
            this.btnUpdateReqImport.TabIndex = 27;
            this.btnUpdateReqImport.Text = "Update Request";
            this.btnUpdateReqImport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUpdateReqImport.UseCustomBackColor = true;
            this.btnUpdateReqImport.UseCustomForeColor = true;
            this.btnUpdateReqImport.UseSelectable = true;
            this.btnUpdateReqImport.UseStyleColors = true;
            this.btnUpdateReqImport.Click += new System.EventHandler(this.btnUpdateReqImport_Click);
            // 
            // dgvImport
            // 
            this.dgvImport.AllowUserToAddRows = false;
            this.dgvImport.AllowUserToDeleteRows = false;
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImport.Location = new System.Drawing.Point(3, 3);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.ReadOnly = true;
            this.dgvImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImport.Size = new System.Drawing.Size(318, 337);
            this.dgvImport.TabIndex = 3;
            this.dgvImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImport_CellClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = " Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ParcelType";
            this.dataGridViewTextBoxColumn7.HeaderText = "Parcel Type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Medium";
            this.dataGridViewTextBoxColumn8.HeaderText = "Medium";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // MtCommunicate
            // 
            this.MtCommunicate.HorizontalScrollbarBarColor = true;
            this.MtCommunicate.HorizontalScrollbarHighlightOnWheel = false;
            this.MtCommunicate.HorizontalScrollbarSize = 10;
            this.MtCommunicate.Location = new System.Drawing.Point(4, 38);
            this.MtCommunicate.Name = "MtCommunicate";
            this.MtCommunicate.Size = new System.Drawing.Size(864, 343);
            this.MtCommunicate.TabIndex = 4;
            this.MtCommunicate.Text = "Communicate";
            this.MtCommunicate.VerticalScrollbarBarColor = true;
            this.MtCommunicate.VerticalScrollbarHighlightOnWheel = false;
            this.MtCommunicate.VerticalScrollbarSize = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(177, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 29);
            this.lblTitle.TabIndex = 38;
            this.lblTitle.Text = "Chief Executive Officer";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = global::Airlink.Properties.Resources.IPvt1Irv1_l9O4W1zIYVyhJVaQILgWSKUjAlna4Dc3Ru1WeJ;
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(5, 8);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(59, 59);
            this.metroPanel2.TabIndex = 37;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(770, 63);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(103, 19);
            this.metroButton2.TabIndex = 39;
            this.metroButton2.Text = "Logout";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // lblIsArrived
            // 
            this.lblIsArrived.AutoSize = true;
            this.lblIsArrived.Location = new System.Drawing.Point(117, 50);
            this.lblIsArrived.Name = "lblIsArrived";
            this.lblIsArrived.Size = new System.Drawing.Size(73, 13);
            this.lblIsArrived.TabIndex = 53;
            this.lblIsArrived.Text = "Parcel Arrived";
            // 
            // EmpPageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTab);
            this.Name = "EmpPageAdmin";
            this.Text = "Airlink International Courier";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpPageAdmin_FormClosing);
            this.Load += new System.EventHandler(this.EmpPageAdmin_Load);
            this.metroTab.ResumeLayout(false);
            this.MtBasicInfo.ResumeLayout(false);
            this.MtBasicInfo.PerformLayout();
            this.groupBoxPassChng.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPP)).EndInit();
            this.MTEmployees.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).EndInit();
            this.MtDepartments.ResumeLayout(false);
            this.MtDepartments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.MtBill.ResumeLayout(false);
            this.MtBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRate)).EndInit();
            this.MtExportDetail.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panelExportDetailSearch.ResumeLayout(false);
            this.panelExportDetailSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).EndInit();
            this.MtImportDetail.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.ResumeLayout(false);

        } 

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTab;
        private MetroFramework.Controls.MetroTabPage MtBasicInfo;
        private MetroFramework.Controls.MetroTabPage MtDepartments;
        private MetroFramework.Controls.MetroTabPage MtExportDetail;
        private MetroFramework.Controls.MetroTabPage MtImportDetail;
        private MetroFramework.Controls.MetroTabPage MtCommunicate;
        private System.Windows.Forms.GroupBox groupBoxPassChng;
        private MetroFramework.Controls.MetroTextBox txtConfirmNewPassword;
        private MetroFramework.Controls.MetroTextBox txtNewPassword;
        private MetroFramework.Controls.MetroTextBox txtOldPassword;
        private MetroFramework.Controls.MetroTextBox txtUserId;
        private MetroFramework.Controls.MetroTextBox txtMail;
        private MetroFramework.Controls.MetroTextBox txtDesignation;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBoxPP;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl1;
        private MetroFramework.Controls.MetroTabPage MtBill;
        private MetroFramework.Controls.MetroButton btnSavePass;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHideChar;
        private System.Windows.Forms.Button btnShowChar;
        private DataGridView dgvDepartment;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn dName;
        private MetroFramework.Controls.MetroTextBox txtDeptName;
        private MetroFramework.Controls.MetroTextBox txtDeptId;
        private MetroFramework.Controls.MetroLabel lblDeptName;
        private MetroFramework.Controls.MetroLabel lblDeptId;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroTextBox txtDeptSearch;
        private MetroFramework.Controls.MetroButton btnDeptRefresh;
        private MetroFramework.Controls.MetroDateTime dtDob;
        private Label lbl5;
        private MetroFramework.Controls.MetroTextBox txtDept;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage MTEmployees;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroButton btnESave;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroLabel lblEDepartment;
        private MetroFramework.Controls.MetroLabel lblEDob;
        private MetroFramework.Controls.MetroTextBox txtEEmail;
        private MetroFramework.Controls.MetroLabel lblEEmail;
        private MetroFramework.Controls.MetroLabel lblEDesignation;
        private MetroFramework.Controls.MetroTextBox txtEDesignation;
        private MetroFramework.Controls.MetroLabel lblEName;
        private MetroFramework.Controls.MetroTextBox txtEName;
        private MetroFramework.Controls.MetroTextBox txtEId;
        private MetroFramework.Controls.MetroLabel lblEId;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton btnERefresh;
        private MetroFramework.Controls.MetroButton btnEAdd;
        private MetroFramework.Controls.MetroButton btnEDelete;
        private MetroFramework.Controls.MetroTextBox txtESearch;
        private MetroFramework.Controls.MetroDateTime DtpEDob;
        private MetroFramework.Controls.MetroComboBox ddlEDepartment;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroGrid GridEmployee;
        private DataGridViewTextBoxColumn EId;
        private DataGridViewTextBoxColumn EName;
        private DataGridViewTextBoxColumn EDesignation;
        private DataGridViewTextBoxColumn EDepartment;
        private MetroFramework.Controls.MetroLabel lblEPassword;
        private MetroFramework.Controls.MetroTextBox txtEPassword;
        private MetroFramework.Controls.MetroLabel lblEUserName;
        private MetroFramework.Controls.MetroTextBox txtEUserName;
        private MetroFramework.Controls.MetroButton btnPicAdd;
        private MetroFramework.Controls.MetroTextBox txtDPEXRate;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtTNTRate;
        private MetroFramework.Controls.MetroTextBox txtDHLRate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtRateSearch;
        private MetroFramework.Controls.MetroButton btnRateSave;
        private MetroFramework.Controls.MetroTextBox txtCountryName;
        private MetroFramework.Controls.MetroTextBox txtRateID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private DataGridView dgvRate;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MetroFramework.Controls.MetroButton btnAddRates;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dgvExport;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MetroFramework.Controls.MetroPanel panelExportDetailSearch;
        private MetroFramework.Controls.MetroTextBox txtDetailAirwayBill;
        private MetroFramework.Controls.MetroLabel metroLabel61;
        private MetroFramework.Controls.MetroTextBox txtExportSearch;
        private MetroFramework.Controls.MetroButton btnExportRequestUpdate;
        private MetroFramework.Controls.MetroTextBox txtDetailMedium;
        private MetroFramework.Controls.MetroTextBox txtDetailParcelType;
        private MetroFramework.Controls.MetroTextBox txtDetailSAddress;
        private MetroFramework.Controls.MetroLabel metroLabel30;
        private MetroFramework.Controls.MetroTextBox txtDetailRAddress;
        private MetroFramework.Controls.MetroLabel metroLabel31;
        private MetroFramework.Controls.MetroTextBox txtDetailSContactNo;
        private MetroFramework.Controls.MetroTextBox txtDetailSName;
        private MetroFramework.Controls.MetroTextBox txtDetailRContactNo;
        private MetroFramework.Controls.MetroTextBox txtDetailRCountry;
        private MetroFramework.Controls.MetroTextBox txtDetailRName;
        private MetroFramework.Controls.MetroLabel metroLabel32;
        private MetroFramework.Controls.MetroLabel metroLabel33;
        private MetroFramework.Controls.MetroLabel metroLabel34;
        private MetroFramework.Controls.MetroLabel metroLabel35;
        private MetroFramework.Controls.MetroLabel metroLabel36;
        private MetroFramework.Controls.MetroLabel metroLabel37;
        private MetroFramework.Controls.MetroLabel metroLabel38;
        private MetroFramework.Controls.MetroLabel metroLabel39;
        private MetroFramework.Controls.MetroLabel metroLabel40;
        private MetroFramework.Controls.MetroButton btnDeleteReqExp;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView dgvImport;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroButton btnDeleteImp;
        private MetroFramework.Controls.MetroTextBox txtSDetailAirwayBill2I;
        private MetroFramework.Controls.MetroLabel metroLabel41;
        private MetroFramework.Controls.MetroTextBox txtSDetailMedium2I;
        private MetroFramework.Controls.MetroTextBox txtDetailParcelType2I;
        private MetroFramework.Controls.MetroTextBox txtRDetailAddress2I;
        private MetroFramework.Controls.MetroLabel metroLabel52;
        private MetroFramework.Controls.MetroTextBox txtSDetailContact2I;
        private MetroFramework.Controls.MetroTextBox txtSDetailName2I;
        private MetroFramework.Controls.MetroTextBox txtRDetailContact2I;
        private MetroFramework.Controls.MetroTextBox txtRDetailName2I;
        private MetroFramework.Controls.MetroLabel metroLabel53;
        private MetroFramework.Controls.MetroLabel metroLabel54;
        private MetroFramework.Controls.MetroLabel metroLabel55;
        private MetroFramework.Controls.MetroLabel metroLabel56;
        private MetroFramework.Controls.MetroLabel metroLabel57;
        private MetroFramework.Controls.MetroLabel metroLabel58;
        private MetroFramework.Controls.MetroLabel metroLabel59;
        private MetroFramework.Controls.MetroLabel metroLabel60;
        private MetroFramework.Controls.MetroTextBox txtSearchImport;
        private MetroFramework.Controls.MetroButton btnUpdateReqImport;
        private MetroFramework.Controls.MetroTextBox txtDetailArrived;
        private MetroFramework.Controls.MetroLabel lblArrived;
        private MetroFramework.Controls.MetroTextBox txtIdExport;
        private MetroFramework.Controls.MetroTextBox txtIdImport;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private OpenFileDialog openFileDialog1;
        private TextBox txtPic;
        private MetroFramework.Controls.MetroButton metroButton2;
        private Label lblIsArrived;
    } 
            
}