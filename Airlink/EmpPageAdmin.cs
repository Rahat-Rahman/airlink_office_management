using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airlink.BusinessLogic;
using Airlink.Data;
using Airlink.Framework;
using LoggedInId;
using MetroFramework;

namespace Airlink
{
    public partial class EmpPageAdmin : MetroFramework.Forms.MetroForm
    {
        private DepartmentBL departmentBl=new DepartmentBL();
        private List<Department> departments =new List<Department>();
        private AirlinkDbEntities context = DataAccess.Context;

        private EmployeeTableBL employeeBl = new EmployeeTableBL();
        private List<EmployeeTable> employees = new List<EmployeeTable>();

        private RatesBL ratesBl = new RatesBL();
        private List<Rate> rates = new List<Rate>();

        private ExportRequestBL exportBL = new ExportRequestBL();
        private List<ExportRequest> exports = new List<ExportRequest>();

        private ImportRequestBL importBL = new ImportRequestBL();
        private List<ImportRequest> imports = new List<ImportRequest>();

        private string FileName = "";


      

        private bool isNew = false;
        private int type = 2;
        public EmpPageAdmin()
        {
            InitializeComponent();
        }


        private void EmpPageAdmin_Load(object sender, EventArgs e)
        {
            EmployeeTableBL bl = new EmployeeTableBL();
            
            groupBoxPassChng.Visible = false;
            btnShowChar.Visible = false;
            this.Init();

            EmployeeTableBL empBL = new EmployeeTableBL();
            var loggedID = empBL.GetEmployeeTableById(LoggedInId.LogId.Id);

            txtName.Text = loggedID.Data.Name;
            txtUserId.Text = loggedID.Data.Username;
            txtMail.Text = loggedID.Data.Email;
            txtDesignation.Text = loggedID.Data.Designation;
            txtDept.Text = loggedID.Data.DepartmentName;
            dtDob.Text = loggedID.Data.DOB.ToShortDateString();
            if (bl.GetEmployeeTableById(loggedID.Data.Id.ToString()).Data.ProfilePic != null)
            {
                pictureBoxPP.Load(bl.GetEmployeeTableById(loggedID.Data.Id.ToString()).Data.ProfilePic);
            }

            lblIsArrived.Hide( );





        }

        private void MtEmployees_Click(object sender, EventArgs e)
        {
            this.Init();//        retrive all data here;

        }

        private void Init()
        {
            txtDeptSearch.Text = "";
            txtESearch.Text = "";
            ddlEDepartment.DataSource = departmentBl.GetAllDepartments("",null,null).Data;
            ddlEDepartment.DisplayMember = "Name";
            ddlEDepartment.ValueMember = "Id";
           
            this.LoadDepartments();
            this.LoadEmployees();
            this.LoadRates();
            LoadExports();
            LoadImports();

        }












        private void LoadDepartments()
        {
            var result = departmentBl.GetAllDepartments(txtDeptSearch.Text, null, null);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            departments = result.Data;

            if (departments.Count > 0)
            {
                this.PopulateData(departments[0]);
            }
            else
            {
                this.New();
            }

            this.RefreshDataGrid();

        }
        private void LoadEmployees()
        {
            var result = employeeBl.GetAllEmployeeTables(txtESearch.Text, null, null);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

           // var query = from d in result.Data where Id.ToString().Trim().EndsWith()
                   // select d;

            employees = result.Data;


            if (employees.Count > 0)
            {
                this.PopulateEData(employees[0]);
            }
            else
            {
                this.NewE();
            }

            this.RefreshEDataGrid();

        }
        private void LoadRates()
        {
            var result = ratesBl.GetAllRates(txtRateSearch.Text, null, null);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

             rates=result.Data;

            if (rates.Count > 0)
            {
                this.PopulateRData(rates[0]);
            }
            else
            {
                this.NewRate();
            }

            this.RefreshRDataGrid();

        }

        private void LoadExports()
        {
            var result = exportBL.GetAllRequests(txtExportSearch.Text, 2,null, null);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            exports = result.Data;

            if (exports.Count > 0)
            {
                this.PopulateExportData(exports[0]);
            }
            else
            {
                this.NewExport();
            }

            this.RefreshExportDataGrid();

        }
        private void LoadImports()
        {
            var result = importBL.GetAllRequests(txtSearchImport.Text,2, null, null);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            imports = result.Data;

            if (imports.Count > 0)
            {
                this.PopulateImportData(imports[0]);
            }
            else
            {
                this.NewImport();
            }

            this.RefreshImportDataGrid();

        }












        private void RefreshDataGrid()
        {
            dgvDepartment.AutoGenerateColumns = false;
            dgvDepartment.DataSource = departments.ToList();
            dgvDepartment.Refresh();
            dgvDepartment.ClearSelection();

            for (int i = 0; i < dgvDepartment.Rows.Count; i++)
            {
                if (dgvDepartment.Rows[i].Cells[0].Value.ToString() == txtDeptId.Text)
                {
                    dgvDepartment.Rows[i].Selected = true;
                }

            }
        }
        private void RefreshEDataGrid()
        {
            GridEmployee.AutoGenerateColumns = false;
            GridEmployee.DataSource = employees.ToList();
            GridEmployee.Refresh();
            GridEmployee.ClearSelection();

            for (int i = 0; i < GridEmployee.Rows.Count; i++)
            {
                if (GridEmployee.Rows[i].Cells[0].Value.ToString() == txtEId.Text)
                {
                    GridEmployee.Rows[i].Selected = true;
                }

            }
        }

        private void RefreshRDataGrid()
        {
            dgvRate.AutoGenerateColumns = false;
            dgvRate.DataSource = rates.ToList();
            dgvRate.Refresh();
            dgvRate.ClearSelection();

            for (int i = 0; i < dgvRate.Rows.Count; i++)
            {
                if (dgvRate.Rows[i].Cells[0].Value.ToString() == txtRateID.Text)
                {
                    dgvRate.Rows[i].Selected = true;
                }

            }
        }

        private void RefreshExportDataGrid()
        {
            dgvExport.AutoGenerateColumns = false;
            dgvExport.DataSource = exports.ToList();
            dgvExport.Refresh();
            dgvExport.ClearSelection();

            for (int i = 0; i < dgvExport.Rows.Count; i++)
            {
                if (dgvExport.Rows[i].Cells[0].Value.ToString() == txtIdExport.Text)
                {
                    dgvExport.Rows[i].Selected = true;
                }

            }
            
        }
        private void RefreshImportDataGrid()
        {
            dgvImport.AutoGenerateColumns = false;
            dgvImport.DataSource = imports.ToList();
            dgvImport.Refresh();
            dgvImport.ClearSelection();

            for (int i = 0; i < dgvImport.Rows.Count; i++)
            {
                if (dgvImport.Rows[i].Cells[0].Value.ToString() == txtIdImport.Text)
                {
                    dgvImport.Rows[i].Selected = true;
                }

            }
        }











        private void PopulateData(Department department)
        {
            txtDeptId.Text = department.Id == -1 ? "Auto Generate" : department.Id.ToString();
            txtDeptName.Text = department.Name;
        }

        private void PopulateEData(EmployeeTable employee)
        {
            txtEId.Text = employee.Id == -1+"" ? "Auto Generate" : employee.Id.ToString(); // Problem
            txtEName.Text = employee.Name;
            txtEPassword.Text = employee.Password;
            txtEDesignation.Text = employee.Designation;
            txtEEmail.Text = employee.Email;
            if (employee.Id.Equals("-1"))
            {
                DtpEDob.Text = "";
            }
            else
            {
                DtpEDob.Text = employee.DOB.ToShortDateString();
            }
            
            ddlEDepartment.SelectedValue = employee.departmentId;
            txtEUserName.Text= employee.Username;



        }
        private void PopulateRData(Rate rate)
        {
            txtRateID.Text = rate.RatesID == -1 ? "Auto Generate" : rate.RatesID.ToString();
            txtCountryName.Text = rate.Country;
            txtDHLRate.Text = rate.DHLRate + "";
            txtTNTRate.Text = rate.TNTRate + "";
            txtDPEXRate.Text = rate.DPEXRate + "";


        }
        private void PopulateExportData(ExportRequest exp)
        {
            txtIdExport.Text = exp.Id == -1 ? "Auto Generate" : exp.Id + "";
            txtDetailRName.Text = exp.ReceiverName;
            txtDetailRCountry.Text = exp.ReceiverCountry;
            txtDetailRContactNo.Text = exp.ReceiverContactNo;
            txtDetailRContactNo.Text = exp.ReceiverContactNo;

            txtDetailSName.Text = exp.SenderName;          
            txtDetailSContactNo.Text = exp.SenderContactNo;
            txtDetailSAddress.Text = exp.SenderAddress;

            txtDetailParcelType.Text = exp.ParcelType;
            txtDetailMedium.Text = exp.Medium;
            txtDetailAirwayBill.Text = exp.AirbillNo;




        }
        private void PopulateImportData(ImportRequest imp)
        {

            txtIdImport.Text = imp.Id == -1 ? "Auto Generate" : imp.Id + "";
            txtRDetailName2I.Text = imp.ReceiverName;
            txtRDetailContact2I.Text = imp.ReceiverContact;
            txtRDetailAddress2I.Text = imp.ReceiverAddress;
            txtSDetailName2I.Text = imp.SenderName;
            txtSDetailContact2I.Text = imp.SenderContactNo;
            
            
            txtDetailParcelType2I.Text = imp.ParcelType;
            //txtDetailArrived.Text=
            txtSDetailMedium2I.Text = imp.Medium;
            txtSDetailAirwayBill2I.Text = imp.AirbillNo;
            if (imp.IsArrived == true)
            {
                lblIsArrived.Show();
            }

            


        }
















        private void New()
        {
            isNew = true;
            dgvDepartment.ClearSelection();
            var department = new Department() { Id = -1 };
            this.PopulateData(department);
        }

        private void NewE()
        {
            isNew = true;
            GridEmployee.ClearSelection();
            var employee = new EmployeeTable() { Id = -1 + "" };
            this.PopulateEData(employee);
        }

        private void NewRate()
        {
            isNew = true;
            dgvRate.ClearSelection();
            var rate = new Rate() { RatesID = -1 };
           
             this.PopulateRData(rate);
        }

        private void NewExport()
        {
            isNew = true;
            dgvExport.ClearSelection();
            var request = new ExportRequest { Id = -1 };
            this.PopulateExportData(request);
        }
        private void NewImport()
        {
            isNew = true;
            dgvImport.ClearSelection();
            var request = new ImportRequest { Id = -1 };
            this.PopulateImportData(request);
        }










      






        

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Int32.Parse(dgvDepartment.Rows[e.RowIndex].Cells[0].Value.ToString());
                var department = departments.FirstOrDefault(dept => dept.Id == id);

                if (department == null)
                {
                    MessageBox.Show("Something went wrong");
                    this.New();
                    return;
                }

                isNew = false;

                this.PopulateData(department);
            }
        }

        private void GridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = GridEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                //int id = Int32.Parse(GridEmployee.Rows[e.RowIndex].Cells[0].Value.ToString());
                var employee = employees.FirstOrDefault(emp => emp.Id == id);

                if (employee == null)
                {
                    MessageBox.Show("Something went wrong");
                    this.New();
                    return;
                }

                isNew = false;

                this.PopulateEData(employee);
            }
        }

        private void dgvRate_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int id = Int32.Parse(dgvRate.Rows[e.RowIndex].Cells[0].Value.ToString());
                var rate = rates.FirstOrDefault(rr => rr.RatesID == id);

                if (rate == null)
                {
                    MessageBox.Show("Something went wrong");
                    this.NewRate();
                    return;
                }

                isNew = false;

                this.PopulateRData(rate);
            }

        }

        private void dgvImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Int32.Parse(dgvImport.Rows[e.RowIndex].Cells[0].Value.ToString());
                var import = imports.FirstOrDefault(rr => rr.Id == id);

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
        private void dgvExport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Int32.Parse(dgvExport.Rows[e.RowIndex].Cells[0].Value.ToString());
                var export = exports.FirstOrDefault(ex => ex.Id == id);

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











        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsIntValid(txtDeptId.Text))
            {
                MessageBox.Show("Please select a row first");
                return;

            }

            var result = departmentBl.Delete(Int32.Parse(txtDeptId.Text));
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            var dept = departments.FirstOrDefault(d => d.Id == result.Data.Id);
            if (dept != null)
                departments.Remove(dept);

            this.RefreshDataGrid();
            this.New();
            MetroMessageBox.Show(this, "Operation Successful", "Delete");

        }
        private void btnEDelete_Click(object sender, EventArgs e)
        {

            DialogResult dr= MetroFramework.MetroMessageBox.Show(this, "Are You Sure ?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if(dr==DialogResult.No)
                return;

            if (!ValidationHelper.IsIntValid(txtDeptId.Text))
            {
                MessageBox.Show("Please select a row first");
                return;

            }

           // var result = employeeBl.Delete(Int32.Parse(txtEId.Text));
            var result = employeeBl.Delete(txtEId.Text);

            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            var emp = employees.FirstOrDefault(d => d.Id == result.Data.Id);
            if (emp != null)
                employees.Remove(emp);

            this.RefreshEDataGrid();
            this.NewE();
            MetroMessageBox.Show(this, "Operation Successful", "Delete");
        }














        

        private void btnNew_Click(object sender, EventArgs e)
        {
           this.New();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Fill();
        }

        private void Fill()
        {
            Department dept=new Department();
            if (!isNew)
            {
                dept.Id = Int32.Parse(txtDeptId.Text);
            }


            dept.Name = txtDeptName.Text;

            var result = departmentBl.SaveDepartment(dept);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            if(isNew)
                departments.Add(result.Data);
            else
            {
                foreach (var department in departments)
                {
                    if (department.Id == dept.Id)
                    {
                        department.Name = dept.Name;

                    }
                }
            }
            isNew = false;
            this.PopulateData(result.Data);
            RefreshDataGrid();

        }




        private void btnRateSave_Click(object sender, EventArgs e)
        {
            this.Fill_Rates();
        }


        private void Fill_Rates()
        {
            Rate rr = new Rate();

            if (!isNew)
            {
                rr.RatesID = Int32.Parse(txtRateID.Text);
                
            }
           


            rr.Country = txtCountryName.Text;
            rr.DHLRate = Int32.Parse(txtDHLRate.Text);
            rr.TNTRate = Int32.Parse(txtTNTRate.Text);
            rr.DPEXRate = Int32.Parse(txtDPEXRate.Text);

            var result = ratesBl.SaveRate(rr);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            if (isNew)
                rates.Add(result.Data);
            else
            {
                foreach (var rate in rates)
                {
                    if (rate.RatesID == rr.RatesID)
                    {
                        rate.Country = rr.Country;
                        rate.DHLRate = rr.DHLRate;
                        rate.TNTRate = rr.TNTRate;
                        rate.DPEXRate = rr.DPEXRate;

                    }
                }
            }
            isNew = false;
            this.PopulateRData(result.Data);
            RefreshRDataGrid();

        }



        private void btnESave_Click(object sender, EventArgs e)
        {
            this.FillE();
        }

        private void FillE()
        {
            EmployeeTable emp = new EmployeeTable();
            
            string testId = "";


            foreach (EmployeeTable e1 in employees )
            {
                if (e1.Id.Trim().EndsWith(type +""))
                {
                    testId = e1.Id;
                    break;
                }
            }
            if (type == 2 && testId.Trim().Equals(""))
            {
                testId = "1-2";
            }
            string[] arr = testId.Trim().Split('-');
            int id = Int32.Parse(arr[0]);
            foreach (EmployeeTable e2 in employees)
            {
                if (e2.Id.Trim().EndsWith(type + ""))
                {
                    id++;
                }
            }

            if (!isNew)
            {
                //emp.Id = Int32.Parse(txtEId.Text);
                emp.Id = txtEId.Text;

            }
            else
            {
                emp.Id = id + "-" + type;
            }

            //emp.Id = Id + "-" + type;
            emp.Name = txtEName.Text;
            emp.Designation = txtEDesignation.Text;
            emp.Email = txtEEmail.Text;
            emp.DOB = Convert.ToDateTime(DtpEDob.Text);
            emp.departmentId = Int32.Parse(ddlEDepartment.SelectedValue.ToString());
            emp.Username = txtEUserName.Text;
            emp.Password = txtEPassword.Text.Trim();
            if(emp.Password.Equals("") || emp.Password == null)
                emp.Password = "11111";

            var result = employeeBl.SaveEmployeeTable(emp);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            if (isNew)
                employees.Add(result.Data);
            else
            {
                var employee = employees.FirstOrDefault(e => e.Id.Trim().Equals(txtEId.Text.Trim()));
                if (employee == null)
                {
                    employee.Name = result.Data.Name;
                    employee.Designation = result.Data.Designation;
                    employee.Email = result.Data.Email;
                    employee.departmentId = result.Data.departmentId;
                    employee.Department = result.Data.Department;
                    employee.Username = result.Data.Username;
                    employee.Password = result.Data.Password;
                    employee.DOB = result.Data.DOB;


                }
            }
            isNew = false;
            this.PopulateEData(result.Data);
            RefreshEDataGrid();




        }

        private void FillExport()
        {
            ExportRequest exp = new ExportRequest();



           
           
             exp.Id = Int32.Parse(txtIdExport.Text);

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



            var result = exportBL.SaveExportTable(exp);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

                var export = exports.FirstOrDefault(e => e.Id.Equals(Int32.Parse(txtIdExport.Text)));
                if (export != null)
                {
                    export.ReceiverName = result.Data.ReceiverName;          ////////////////
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

            this.PopulateExportData(result.Data);
            RefreshExportDataGrid();

        }

        private void FillImport()
        {
            ImportRequest imp = new ImportRequest();


            imp.Id = Int32.Parse(txtIdImport.Text);
            imp.ReceiverName = txtRDetailName2I.Text;
            imp.ReceiverAddress = txtRDetailAddress2I.Text;
            imp.ReceiverContact = txtRDetailContact2I.Text;
            imp.SenderName = txtSDetailName2I.Text;
            imp.SenderContactNo = txtSDetailContact2I.Text;
            imp.ParcelType = txtDetailParcelType2I.Text;
           // imp.IsArrived=

            imp.Medium = txtSDetailMedium2I.Text;
            imp.AirbillNo = txtSDetailAirwayBill2I.Text;


            var result = importBL.SaveImportTable(imp);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

                var import = imports.FirstOrDefault(e => e.Id.Equals(Int32.Parse(txtIdImport.Text)));
                if (import == null)
                {
                    import.ReceiverName = result.Data.ReceiverName;          //////////////
                    import.ReceiverAddress = result.Data.ReceiverAddress;
                    import.ReceiverContact = result.Data.ReceiverContact;
                    import.SenderName = result.Data.SenderName;
                    import.SenderContactNo = result.Data.SenderContactNo;
                    import.ParcelType = result.Data.ParcelType;
                    import.Medium = result.Data.Medium;
                    import.AirbillNo = result.Data.AirbillNo;
                }

            this.PopulateImportData(result.Data);
            RefreshImportDataGrid();

        }


       
















        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MtBasicInfo_Click(object sender, EventArgs e)
        {
            // groupBoxPassChng.Enabled = false;


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBoxPassChng.Visible = true;
        }

        private void btnShowChar_Click(object sender, EventArgs e)
        {
            btnShowChar.Visible = false;
            btnHideChar.Visible = true;

            txtOldPassword.UseSystemPasswordChar = false;
            txtNewPassword.UseSystemPasswordChar = false;
            txtConfirmNewPassword.UseSystemPasswordChar = false;
        }

        private void btnHideChar_Click(object sender, EventArgs e)
        {
            btnHideChar.Visible = false;
            btnShowChar.Visible = true;
            txtOldPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmNewPassword.UseSystemPasswordChar = true;

        }

        private void btnEAdd_Click(object sender, EventArgs e)
        {
            this.NewE();
        }








        private void txtDeptSearch_TextChanged(object sender, EventArgs e)
        {
            this.LoadDepartments();
        }

        private void btnDeptRefresh_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MTEmployees_Click_1(object sender, EventArgs e)
        {

        }

        private void metroPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void txtESearch_Click(object sender, EventArgs e)
        {

        }

        private void txtESearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.LoadEmployees();
            }
        }

       

        private void btnERefresh_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void EmpPageAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginPage lp=new loginPage();
            lp.Show();

            this.Hide();
        }

        private void lblEId_Click(object sender, EventArgs e)
        {

        }

        private void ddlEDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtDeptSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Password Does not matched with Confirm password");
                return;
            }

            if(MetroFramework.MetroMessageBox.Show(this,"Are You Sure?","Confirmation",MessageBoxButtons.YesNo)==DialogResult.No)
                return;

            var result = employeeBl.ChangePassword(txtUserId.Text,txtOldPassword.Text,txtNewPassword.Text);
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

        
        private void txtRateSearch_TextChanged(object sender, EventArgs e)
        {
            this.LoadRates();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void btnAddRates_Click(object sender, EventArgs e)
        {
            this.NewRate();
        }

        private void btnExportRequestUpdate_Click(object sender, EventArgs e)
        {
            this.FillExport();
            MetroFramework.MetroMessageBox.Show(this, " Information Updated");
        }

        private void btnDeleteReqExp_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure ?", "Delete Confirmation",
               MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                return;

            if (!ValidationHelper.IsIntValid(txtIdExport.Text))
            {
                MessageBox.Show("Please select a row first");
                return;

            }


            var result = exportBL.Delete(Int32.Parse(txtIdExport.Text));

            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            var exp = exports.FirstOrDefault(d => d.Id == result.Data.Id);
            if (exp != null)
                exports.Remove(exp);

            this.RefreshExportDataGrid();
            this.NewExport();
            MetroMessageBox.Show(this, "Operation Successful", "Delete");
        }

        private void txtExportSearch_TextChanged(object sender, EventArgs e)
        {
           this.LoadExports();
        }

        private void btnDeleteImp_Click(object sender, EventArgs e)
        {
            

            if (!ValidationHelper.IsIntValid(txtIdImport.Text))
            {
                MessageBox.Show("Please select a row first");
                return;

            }
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are You Sure ?", "Delete Confirmation",
               MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                return;


            var result = importBL.Delete(Int32.Parse(txtIdImport.Text));

            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            var imp = imports.FirstOrDefault(d => d.Id == result.Data.Id);
            if (imp != null)
                imports.Remove(imp);

            this.RefreshImportDataGrid();

            this.NewImport();

            MetroMessageBox.Show(this, "Operation Successful", "Delete");
        }

        private void btnUpdateReqImport_Click(object sender, EventArgs e)
        {
            this.FillImport();
            MetroFramework.MetroMessageBox.Show(this, " Information Updated");
        }

        private void txtExportSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchImport_TextChanged(object sender, EventArgs e)
        {
            this.LoadImports();
        }

        private void btnPicAdd_Click(object sender, EventArgs e)
        {
            if (txtPic.Text.Equals(""))
            {
                MetroFramework.MetroMessageBox.Show(this, "Input a name of your picture first ");
                return;
                
            }
            if (txtPic.Text.Trim().Equals(""))
            {
                MetroFramework.MetroMessageBox.Show(this, "Input a name of your picture first ");
                return;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPP.Image = Image.FromFile(openFileDialog1.FileName);
                FileName = openFileDialog1.FileName;
            }
            else
            {
                FileName = "";
            }

            string path = Directory.GetCurrentDirectory();

            string imageName = path + "\\" + txtPic.Text + ".jpg";

            if (FileName.Equals(""))
            {
                MetroFramework.MetroMessageBox.Show(this, "Picture Is Not Set");
                txtPic.Text = "";
                return;
            }
            File.Copy(FileName, imageName, true);

            var user = employeeBl.GetEmployeeTableById(LoggedInId.LogId.Id);
            user.Data.ProfilePic = txtPic.Text.Trim() + ".jpg";
            employeeBl.SaveEmployeeTable(user.Data);


            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            imageName = path + txtUserId.Text + ".jpg";
            File.Copy(FileName, imageName, true);


            txtPic.Text = "";
        }

        private void btnChangePic_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // EmployeeTable imp = new EmployeeTable();


           // imp.Id = LoggedInId.LogId.Id.ToString();
           // imp.Name = txtName.Text;
           // imp.Designation = txtDesignation.Text;
           // imp.Email = txtMail.Text;
           // imp.Username = txtUserId.Text;
           // imp.DOB = Convert.ToDateTime(dtDob.Text);
           // imp.departmentId = 1;
           
           // //imp.departmentId = Int32.Parse(ddlEDepartment.SelectedValue.ToString());
           //// imp.IsArrived=



           //var result = employeeBl.SaveEmp(imp);
           // if (result.HasError)
           // {
           //     MessageBox.Show(result.Messages[0]);
           //     return;
           // }

           // var employee = employees.FirstOrDefault(ev => ev.Id.Trim().Equals(LoggedInId.LogId.Id.ToString()));
           //   if (employee != null)
           //     {
           //         employee.Name = result.Data.Name;
           //         employee.Designation = result.Data.Designation;
           //         employee.Email = result.Data.Email;
           //        // employee.departmentId = result.Data.departmentId;
                   
           //         employee.Username = result.Data.Username;
           //         employee.Password = result.Data.Password;
           //         employee.DOB = result.Data.DOB;


           //     }

           // this.PopulateEmpData(result.Data);


            //EmployeeTableBL empBL = new EmployeeTableBL();
            //var loggedID = empBL.GetEmployeeTableById(LoggedInId.LogId.Id);

            // loggedID.Data.Name = txtName.Text;
            // loggedID.Data.Username = txtUserId.Text;
            // loggedID.Data.Email = txtMail.Text;
            // loggedID.Data.Designation = txtDesignation.Text;
            
            //loggedID.Data.DOB = Convert.ToDateTime(dtDob.Text);

            //EmployeeTable imp = new EmployeeTable();

            //imp.Name = loggedID.Data.Name;
            //imp.Username = loggedID.Data.Username;
            //imp.Designation = loggedID.Data.Designation;
            //imp.Email = loggedID.Data.Email;
            //imp.DOB = Convert.ToDateTime(loggedID.Data.DOB);
            //var result = employeeBl.SaveEmp(imp);

            var employeeTable = context.EmployeeTables.FirstOrDefault(d => d.Id == LoggedInId.LogId.Id);
            employeeTable.Name = txtName.Text;
            employeeTable.Username = txtUserId.Text;
            employeeTable.Email = txtMail.Text;
            employeeTable.Designation = txtDesignation.Text;
            employeeTable.DOB = Convert.ToDateTime(dtDob.Text);

            context.SaveChanges();
            PopulateEmpData(employeeTable);

            MetroFramework.MetroMessageBox.Show(this, "Admin Information Updated");
        }

        private void PopulateEmpData(EmployeeTable employee)
        {
            //txtId.Text = employee.Id == -1 + "" ? "Auto Generate" : employee.Id.ToString(); // Problem
            txtName.Text = employee.Name;
            txtDesignation.Text = employee.Designation;
            txtMail.Text = employee.Email;

            txtUserId.Text = employee.Username;
 
            dtDob.Text = employee.DOB.ToShortDateString();





        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            loginPage lp=new loginPage();
            lp.Show();
            this.Hide();
        }

        }

        

      





        }

  
        

       
    

