using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airlink.BusinessLogic;
using Airlink.Data;
using Airlink.Framework;
using MetroFramework;

namespace Airlink
{
    public partial class EmpPage2 : MetroFramework.Forms.MetroForm
    {



        private EmployeeTableBL employeeBl = new EmployeeTableBL();
        private List<EmployeeTable> employees = new List<EmployeeTable>();

        private ExportRequestBL exportBL = new ExportRequestBL();
        private List<ExportRequest> exports = new List<ExportRequest>();
        private List<ExportRequest> exports2 = new List<ExportRequest>();

        private ImportRequestBL importBL = new ImportRequestBL();
        private List<ImportRequest> imports = new List<ImportRequest>();
        private List<ImportRequest> imports2 = new List<ImportRequest>();

        private bool isNew = false;
        private int i=20;
        private int j = 5;


        public EmpPage2()
        {
            InitializeComponent();
        }

        private void EmpPage2_Load(object sender, EventArgs e)
        {
            groupBoxPassChng.Visible = false;

            EmployeeTableBL empBL = new EmployeeTableBL();
            var loggedID = empBL.GetEmployeeTableById(LoggedInId.LogId.Id);

            txtName.Text = loggedID.Data.Name;
            txtUserId.Text = loggedID.Data.Username;
            txtMail.Text = loggedID.Data.Email;
            txtDesignation.Text = loggedID.Data.Designation;
            txtDept.Text = loggedID.Data.DepartmentName;
            dtDob.Text = loggedID.Data.DOB.ToShortDateString();
            txtpasss.Text = loggedID.Data.Password;
            txtPP.Text = loggedID.Data.ProfilePic;

            string path = Directory.GetCurrentDirectory() + "\\Image\\";
            string imageName = path + LoggedInId.LogId.Id + ".jpg";
            pictureBoxPP.Image = Image.FromFile(imageName);


            init();
           // MtBasicInfo.Show();

            timerTrack.Start();
            timerIn.Start();
        }

        private void timerIn_Tick(object sender, EventArgs e)
        {
            j++;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmpPage2_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginPage lp = new loginPage();

            lp.Show();
            this.Hide();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            groupBoxPassChng.Visible = true;
        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Password Does not matched with Confirm password");
                return;
            }

            if (MetroFramework.MetroMessageBox.Show(this, "Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) ==
                DialogResult.No)
                return;

            var result = employeeBl.ChangePassword(txtUserId.Text, txtOldPassword.Text, txtNewPassword.Text);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }
            else
            {
                MetroMessageBox.Show(this, "Operation Successful", "Password Changed");
            }

            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmNewPassword.Text = "";
        }

        private void btnHideChar_Click(object sender, EventArgs e)
        {
            btnHideChar.Visible = false;
            btnShowChar.Visible = true;
            txtOldPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmNewPassword.UseSystemPasswordChar = true;
        }

        private void btnShowChar_Click(object sender, EventArgs e)
        {
            btnShowChar.Visible = false;
            btnHideChar.Visible = true;

            txtOldPassword.UseSystemPasswordChar = false;
            txtNewPassword.UseSystemPasswordChar = false;
            txtConfirmNewPassword.UseSystemPasswordChar = false;
        }

        private void txtRCountry2I_Click(object sender, EventArgs e)
        {

        }



        private void init()
        {
            LoadExports();
            LoadImports();
            txtSearchImport.Text = "";
            txtExportRequestSearch.Text = "";

        }


        private void NewExport()
        {
            isNew = true;
            dgvExport2.ClearSelection();
            var request = new ExportRequest { Id = -1 };
            this.PopulateExportData(request);
        }

        private void NewImport()
        {
            isNew = true;
            dgvImport2.ClearSelection();
            var request = new ImportRequest { Id = -1 };
            this.PopulateImportData(request);
        }









        private void PopulateExportData(ExportRequest exp)
        {
            txtId2.Text = exp.Id == -1 ? "Auto Generate" : exp.Id + "";

            txtRName2.Text = exp.ReceiverName;

            txtSName2.Text = exp.SenderName;

            txtRCountry2.Text = exp.ReceiverCountry;

            txtRContact2.Text = exp.ReceiverContactNo;

            txtSConatct2.Text = exp.SenderContactNo;

            txtRAddress2.Text = exp.ReceiverAddress;

            txtSAddress2.Text = exp.SenderAddress;

            txtParcelType2.Text = exp.ParcelType;

                txtMedium2.Text = exp.Medium;

                txtAirwayBill2I.Text = exp.AirbillNo;



        }
        private void PopulateExportData2(ExportRequest exp)
        {
            txtId_DetailExp.Text = exp.Id == -1 ? "Auto Generate" : exp.Id + "";

            txtDetailRName.Text = exp.ReceiverName;

            txtDetailSName.Text = exp.SenderName;

            txtDetailRCountry.Text = exp.ReceiverCountry;

            txtDetailRContactNo.Text = exp.ReceiverContactNo;

            txtDetailSContactNo.Text = exp.SenderContactNo;

            txtDetailRAddress.Text = exp.ReceiverAddress;

            txtDetailSAddress.Text = exp.SenderAddress;

            txtDetailParcelType.Text = exp.ParcelType;


             txtDetailMedium.Text = exp.Medium;


            txtDetailAirwayBill.Text = exp.AirbillNo;




        }

        private void PopulateImportData(ImportRequest imp)
        {

            txtId2I.Text = imp.Id == -1 ? "Auto Generate" : imp.Id + "";

            txtRName2I.Text = imp.ReceiverName;

            txtSName2I.Text = imp.SenderName;

            txtSContactNo2I.Text = imp.SenderContactNo;

            txtRContactNo2I.Text = imp.ReceiverContact;

            txtRAddress2I.Text = imp.ReceiverAddress;

            txtParcelType2I.Text = imp.ParcelType;

             txtMedium2I.Text = imp.Medium;


            txtAirwayBill2I.Text = imp.AirbillNo;




        }
        private void PopulateImportData2(ImportRequest imp)
        {

            txtDetailId2I.Text = imp.Id == -1 ? "Auto Generate" : imp.Id + "";

            txtRDetailName2I.Text = imp.ReceiverName;

            txtSDetailName2I.Text = imp.SenderName;

            txtSDetailContact2I.Text = imp.SenderContactNo;

            txtRDetailContact2I.Text = imp.ReceiverContact;

            txtRDetailAddress2I.Text = imp.ReceiverAddress;

            txtDetailParcelType2I.Text = imp.ParcelType;

            txtSDetailMedium2I.Text = imp.Medium;

            txtSDetailAirwayBill2I.Text = imp.AirbillNo;

            




        }
        private void PopulateEmpData(EmployeeTable employee)
        {
            //txtId.Text = employee.Id == -1 + "" ? "Auto Generate" : employee.Id.ToString(); // Problem
            txtName.Text = employee.Name;
            txtpasss.Text = employee.Password;
            txtDesignation.Text = employee.Designation;
            txtMail.Text = employee.Email;
            dtDob.Text = employee.DOB.ToShortDateString();
            txtUserId.Text = employee.Username;
            



        }















        private void RefreshExportDataGrid()
        {
            dgvExport1.AutoGenerateColumns = false;
            dgvExport1.DataSource = exports.ToList();
            dgvExport1.Refresh();
            dgvExport1.ClearSelection();

            dgvExport2.AutoGenerateColumns = false;
            dgvExport2.DataSource = exports2.ToList();
            dgvExport2.Refresh();
            dgvExport2.ClearSelection();

            for (int i = 0; i < dgvExport1.Rows.Count; i++)
            {
                if (dgvExport1.Rows[i].Cells[0].Value.ToString() == txtId2.Text)
                {
                    dgvExport1.Rows[i].Selected = true;
                }

            }
            for (int i = 0; i < dgvExport2.Rows.Count; i++)
            {
                if (dgvExport2.Rows[i].Cells[0].Value.ToString() == txtId_DetailExp.Text)
                {
                    dgvExport2.Rows[i].Selected = true;
                }

            }
        }









        private void RefreshImportDataGrid()
        {
            dgvImport1.AutoGenerateColumns = false;
            dgvImport1.DataSource = imports.ToList();
            dgvImport1.Refresh();
            dgvImport1.ClearSelection();

            dgvImport2.AutoGenerateColumns = false;
            dgvImport2.DataSource = imports2.ToList();
            dgvImport2.Refresh();
            dgvImport2.ClearSelection();

            for (int i = 0; i < dgvImport1.Rows.Count; i++)
            {
                if (dgvImport1.Rows[i].Cells[0].Value.ToString() == txtId2I.Text)
                {
                    dgvImport1.Rows[i].Selected = true;
                }

            }

            for (int i = 0; i < dgvImport2.Rows.Count; i++)
            {
                if (dgvImport2.Rows[i].Cells[0].Value.ToString() == txtDetailId2I.Text)
                {
                    dgvImport2.Rows[i].Selected = true;
                }

            }
        }










        private void FillExport()
        {
            ExportRequest exp = new ExportRequest();



            if (!isNew)
            {
                exp.Id = Int32.Parse(txtId_DetailExp.Text);

            }

            exp.ReceiverName = txtDetailRName.Text;
            exp.ReceiverCountry = txtDetailRCountry.Text;
            exp.ReceiverAddress = txtDetailRAddress.Text;
            exp.ReceiverContactNo = txtDetailRContactNo.Text;
            exp.ReceiverContactNo = txtDetailRContactNo.Text;
            exp.SenderName = txtDetailSName.Text;
            exp.SenderAddress = txtDetailSAddress.Text;
            exp.SenderContactNo = txtDetailSContactNo.Text;
            exp.ParcelType = txtDetailParcelType.Text;
            exp.Medium = txtDetailMedium.Text;
            exp.AirbillNo = txtDetailAirwayBill.Text;
            exp.Status = 2;



            var result = exportBL.SaveExportTable(exp);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }


            var export = exports2.FirstOrDefault(ev => ev.Id.Equals(Int32.Parse(txtId_DetailExp.Text)));
            if (export != null)
            {
                export.ReceiverName = result.Data.ReceiverName;
                export.ReceiverCountry = result.Data.ReceiverCountry;
                export.ReceiverAddress = result.Data.ReceiverAddress;
                export.ReceiverContactNo = result.Data.ReceiverContactNo;

                export.SenderName = result.Data.SenderName;
                export.SenderAddress = result.Data.SenderAddress;
                export.SenderContactNo = result.Data.SenderContactNo;
                export.ParcelType = result.Data.ParcelType;
                export.Medium = result.Data.Medium;
                export.AirbillNo = result.Data.AirbillNo;
            }

            this.PopulateExportData2(result.Data);
            RefreshExportDataGrid();

        }

        private void FillImport()
        {
            ImportRequest imp = new ImportRequest();



            if (!isNew)
            {
                imp.Id = Int32.Parse(txtDetailId2I.Text);

            }

            imp.ReceiverName = txtRDetailName2I.Text;
            imp.ReceiverAddress = txtRDetailAddress2I.Text;
            imp.ReceiverContact = txtRDetailContact2I.Text;
            imp.SenderName = txtSDetailName2I.Text;
            imp.SenderContactNo = txtSDetailContact2I.Text;
            imp.ParcelType = txtDetailParcelType2I.Text;
            imp.Medium = txtSDetailMedium2I.Text;
            imp.AirbillNo = txtSDetailAirwayBill2I.Text;
            imp.Status = 2;
            imp.IsArrived = CBisArrived.Checked;


            var result = importBL.SaveImportTable(imp);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }


                var import = imports2.FirstOrDefault(e => e.Id.Equals(Int32.Parse(txtDetailId2I.Text)));
                if (import != null)
                {
                    import.ReceiverName = result.Data.ReceiverName;
                    import.ReceiverAddress = result.Data.ReceiverAddress;
                    import.ReceiverContact = result.Data.ReceiverContact;
                    import.SenderName = result.Data.SenderName;
                    import.SenderContactNo = result.Data.SenderContactNo;
                    import.ParcelType = result.Data.ParcelType;
                    import.Medium = result.Data.Medium;
                    import.AirbillNo = result.Data.AirbillNo;
                    import.IsArrived = result.Data.IsArrived;


                }

            this.PopulateImportData2(result.Data);
            RefreshImportDataGrid();

        }


        private void FillEmp()
        {
            EmployeeTable imp = new EmployeeTable();



            imp.Id = LoggedInId.LogId.Id;

            imp.Name = txtName.Text;
            imp.Designation = txtDesignation.Text;
            imp.Email = txtMail.Text;
            imp.Username= txtUserId.Text;
            imp.departmentId = 2;
            imp.DOB = Convert.ToDateTime(dtDob.Text);
            imp.Password = txtpasss.Text;
            imp.ProfilePic = txtPP.Text;


            var result = employeeBl.SaveEmployeeTable(imp);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }


            var employee=employees.FirstOrDefault(e => e.Id.Equals(LoggedInId.LogId.Id));
            if (employee!= null)
            {
                employee.Name  = result.Data.Name;
                employee.Designation = result.Data.Designation;
                employee.Email = result.Data.Email;
                employee.Username = result.Data.Username;
               employee.DOB = result.Data.DOB;

            }

            this.PopulateEmpData(result.Data);
           

        }









        private void LoadExports()
        {
            var result = exportBL.GetAllRequests(txtExportRequestSearch.Text, 1, null, null);
            var result2 = exportBL.GetAllRequests(txtExportRequestSearch.Text, 2, null, null);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            exports = result.Data;

            if (result2.HasError)
            {
                MessageBox.Show(result2.Messages[0]);
                return;
            }

            exports2 = result2.Data;



            if (exports.Count > 0)
            {
                this.PopulateExportData(exports[0]);
            }
            else
            {
                this.NewExport();
            }


            if (exports2.Count > 0)
            {
                this.PopulateExportData2(exports2[0]);
            }
            else
            {
                this.NewExport();
            }


            this.RefreshExportDataGrid();

        }

        private void LoadImports()
        {
            var result = importBL.GetAllRequests(txtSearchImport.Text, 1, null, null);
            var result2 = importBL.GetAllRequests(txtSearchImport.Text, 2, null, null);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            imports = result.Data;

            if (result2.HasError)
            {
                MessageBox.Show(result2.Messages[0]);
                return;
            }

            imports2 = result2.Data;



            if (imports.Count > 0)
            {
                this.PopulateImportData(imports[0]);
            }
            else
            {
                this.NewImport();
            }



            if (imports2.Count > 0)
            {
                this.PopulateImportData2(imports2[0]);
            }
            else
            {
                this.NewImport();
            }

            this.RefreshImportDataGrid();

        }





        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.FillEmp();
 

          MetroFramework.MetroMessageBox.Show(this, "Account Updated");

        }



        private void btnCancelReqExport_Click(object sender, EventArgs ev)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure ?", "Delete Confirmation",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                return;

            if (!ValidationHelper.IsIntValid(txtId2.Text))
            {
                MessageBox.Show("Please select a row first");
                return;

            }


            var id = Int32.Parse(txtId2.Text);
            var export = exports.FirstOrDefault(e => e.Id == id);

            if (export == null)
                return;

            export.Status = 3;

            var result = exportBL.SaveExportTable(export);

            if (result.HasError)
            {
                MetroFramework.MetroMessageBox.Show(this, result.Messages[0]);
                return;
            }

            this.LoadExports();
        }

        private void btnCancelReqImport_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure ?", "Delete Confirmation",
               MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                return;

            if (!ValidationHelper.IsIntValid(txtId2I.Text))
            {
                MessageBox.Show("Please select a row first");
                return;

            }


            var id = Int32.Parse(txtId2I.Text);
            var import = imports.FirstOrDefault(er => er.Id == id);

            if (import == null)
                return;

            import.Status = 3;

            var result = importBL.SaveImportTable(import);

            if (result.HasError)
            {
                MetroFramework.MetroMessageBox.Show(this, result.Messages[0]);
                return;
            }

            this.LoadImports();
        }

        private void dgvExport1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //string id = dgvExport1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(dgvExport1.Rows[e.RowIndex].Cells[0].Value.ToString());
                var export = exports.FirstOrDefault(exp => exp.Id == id);

                if (export == null)
                {
                    MessageBox.Show("Something went wrong");
                    this.NewExport();
                    return;
                }

                isNew = false;

                this.PopulateExportData(export);
            }
        }

        private void dgvExport2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //string id = dgvExport1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(dgvExport2.Rows[e.RowIndex].Cells[0].Value.ToString());
                var export = exports2.FirstOrDefault(exp => exp.Id == id);

                if (export == null)
                {
                    MessageBox.Show("Something went wrong");
                    this.NewExport();
                    return;
                }

                isNew = false;

                this.PopulateExportData2(export);
            }
        }

        private void dgvImport1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //string id = dgvExport1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(dgvImport1.Rows[e.RowIndex].Cells[0].Value.ToString());
                var import = imports.FirstOrDefault(imp => imp.Id == id);

                if (import == null)
                {
                    MessageBox.Show("Something went wrong");
                    this.NewImport();
                    return;
                }

                isNew = false;

                this.PopulateImportData(import);
            }
        }

        private void dgvImport2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //string id = dgvExport1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(dgvImport2.Rows[e.RowIndex].Cells[0].Value.ToString());
                var import = imports2.FirstOrDefault(exp => exp.Id == id);

                if (import == null)
                {
                    MessageBox.Show("Something went wrong");
                    this.NewImport();
                    return;
                }

                isNew = false;

                this.PopulateImportData2(import);
            }
        }




        private void btnAcceptExport_Click(object sender, EventArgs ev)
        {
            var id = Int32.Parse(txtId2.Text);
            var export = exports.FirstOrDefault(e => e.Id == id);

            if (export == null)
                return;

            export.Status = 2;

            var result = exportBL.SaveExportTable(export);

            if (result.HasError)
            {
                MetroFramework.MetroMessageBox.Show(this, result.Messages[0]);
                return;
            }

            this.LoadExports();
        }

        private void btnAcceptReqImport_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(txtId2I.Text);
            var import = imports.FirstOrDefault(ev => ev.Id == id);

            if (import == null)
                return;

            import.Status = 2;

            var result = importBL.SaveImportTable(import);

            if (result.HasError)
            {
                MetroFramework.MetroMessageBox.Show(this, result.Messages[0]);
                return;
            }

            this.LoadImports();
        }

        private void btnExportRequestUpdate_Click(object sender, EventArgs e)
        {
            FillExport();
            MetroFramework.MetroMessageBox.Show(this, " Information Updated");
        }

        private void btnUpdateReqImport_Click(object sender, EventArgs e)
        {
            FillImport();
            MetroFramework.MetroMessageBox.Show(this, " Information Updated");
        }


        private void txtExportRequestSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtExportRequestSearch_TextChanged(object sender, EventArgs e)
        {
            LoadExports();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            init();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            init();
        }

        private void txtSearchImport_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchImport_TextChanged(object sender, EventArgs e)
        {
            LoadImports();
        }

        private string FileName = "";

        

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPP.Image = Image.FromFile(openFileDialog1.FileName);
                FileName = openFileDialog1.FileName;
            }
            else
            {
                FileName = "";
            }

            string path = Directory.GetCurrentDirectory() + "\\Image\\";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string imageName = path + LoggedInId.LogId.Id+ j + ".jpg";
            File.Copy(FileName, imageName, true);


            //txtPic.Text = "";
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            loginPage lp = new loginPage();
            lp.Show();
            this.Hide();
        }

        private void timerTrack_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 25)
            {
                i = 20;
            }

            pictureBoxTrackPage.Load(i+".jpg");
        }

        private void btnDHLTrack_Click(object sender, EventArgs e)
        {
            TrackingForm tf = new TrackingForm(txtTrack.Text);
            tf.Show();
           // this.Hide();
            
        }

        private void btnTNTTrack_Click(object sender, EventArgs e)
        {
            TrackingFormTNT tf = new TrackingFormTNT(txtTrack.Text);
            tf.Show();
            //this.Hide();
        }

        private void btnDPEXTrack_Click(object sender, EventArgs e)
        {
            trackingFormDpex td = new trackingFormDpex(txtTrack.Text);
            td.Show();
            //this.Hide();
        }

        private void pictureBoxTrackPage_Click(object sender, EventArgs e)
        {

        }

        private void CBisArrived_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        
        //private void btnAcceptReqImport_Click(object sender, EventArgs e)
        //{

        //}







    }
}
