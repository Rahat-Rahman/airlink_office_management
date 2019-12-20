using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airlink.BusinessLogic;
using Airlink.Data;
using MetroFramework;

namespace Airlink
{
    public partial class ImportReqInfo : MetroFramework.Forms.MetroForm
    {
        private ImportRequestBL importBl = new ImportRequestBL();
        private List<ImportRequest> imports= new List<ImportRequest>();

        private RatesBL ratesBl = new RatesBL();
        private List<Rate> rates = new List<Rate>();

        private bool isNew = false;
        public ImportReqInfo()
        {
            InitializeComponent();
        }

        private void ImportReqInfo_Load(object sender, EventArgs e)
        {
            this.Init();
        }



        private void NewImp()
        {
            isNew = true;
            // dgvExport.ClearSelection();
            var imp = new ImportRequest() { Id = -1 };
            this.PopulateImportData(imp);
        }

        private void PopulateImportData(ImportRequest expReq)
        {
            // txtEId.Text = expReq.Id == -1 + "" ? "Auto Generate" : expReq.Id.ToString();
            txtRName.Text = expReq.ReceiverName;
            txtRAddress.Text = expReq.ReceiverAddress;
            txtRContact.Text = expReq.ReceiverContact;
            txtSName.Text = expReq.SenderName;
            txtSContact.Text = expReq.SenderContactNo;
            txtSMedium.Text = expReq.Medium;
            txtParcelType.Text = expReq.ParcelType;
            txtAirBill.Text = expReq.AirbillNo;





        }

        private void Init()
        {
            this.NewImp();
        }
       









        private void ImportReqInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomePage h1 = new HomePage();
            h1.Show();
            this.Hide();
          
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            this.Fill_Import();
            MetroMessageBox.Show(this, "Request Sent");
            HomePage h = new HomePage();
            h.Show();
            this.Hide();
        }

        private void Fill_Import()
        {
            
            ImportRequest exp = new ImportRequest();


           
            exp.ReceiverName = txtRName.Text;
            exp.ReceiverAddress = txtRAddress.Text;
            exp.ReceiverContact = txtRContact.Text;
            exp.SenderName = txtSName.Text;
            exp.SenderContactNo = txtSContact.Text;
            exp.AirbillNo = txtAirBill.Text;
            exp.ParcelType = txtParcelType.Text;
            exp.Medium = txtSMedium.Text;
            exp.Status = 1;
            
          


            var result = importBl.SaveImportTable(exp);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }
              imports.Add(result.Data);
           
            
           
            this.PopulateImportData(result.Data);
           
            }
        }
    }

