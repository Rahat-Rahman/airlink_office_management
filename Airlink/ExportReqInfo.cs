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
    public partial class ExportReqInfo : MetroFramework.Forms.MetroForm
    {
        private ExportRequestBL exportBl = new ExportRequestBL();
        private List<ExportRequest> exports = new List<ExportRequest>();

        private RatesBL ratesBl = new RatesBL();
        private List<Rate> rates = new List<Rate>();


        private int i=11;
        private bool isNew = false;
        public ExportReqInfo()
        {
            InitializeComponent();
        }

        private void ExportReqInfo_Load(object sender, EventArgs e)
        {
            timerExpReqPage.Start();
            this.Init();
        }

        private void timerExpReqPage_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 14)
            {
                i = 11;
            }

            pictureBox1.Load(i + ".jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }







        private void ExportReqInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            HomePage h1=new HomePage();
            h1.Show();
            this.Hide();
        }

        private void lblRTitle_Click(object sender, EventArgs e)
        {

        }








        private void NewExp()
        {
            isNew = true;
           // dgvExport.ClearSelection();
            var exp = new ExportRequest() { Id = -1  };
            this.PopulateExportData(exp);
        }

        private void PopulateExportData(ExportRequest expReq)
        {
           // txtEId.Text = expReq.Id == -1 + "" ? "Auto Generate" : expReq.Id.ToString();
            txtRName.Text = expReq.ReceiverName;
            txtRAddress.Text = expReq.ReceiverAddress;
            txtRCountry.Text = expReq.ReceiverCountry;
            txtRContact.Text = expReq.ReceiverContactNo;
            txtSName.Text = expReq.SenderName;
            txtSAddress.Text = expReq.SenderAddress;
            txtSContact.Text = expReq.SenderContactNo;
            txtParcelType.Text = expReq.ParcelType;
            comboMedium.SelectedValue = expReq.Medium ?? "";





        }

        private void Init()
        {

            //comboMedium.DataSource = ratesBl.GetAllRates("", null, null).Data;
            //comboMedium.DisplayMember = "Country";
            //comboMedium.ValueMember = "RatesID";
            
            

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            
            //this.NewExp();
            this.Fill_Export();

            makeEmpty();

            


          
           
        }

        private void Fill_Export()
        {
            ExportRequest exp = new ExportRequest();



           
            exp.ReceiverName = txtRName.Text;
            exp.ReceiverCountry = txtRCountry.Text;
            exp.ReceiverAddress = txtRAddress.Text;
            exp.ReceiverContactNo = txtRContact.Text;
            exp.SenderName = txtSName.Text;
            exp.SenderAddress = txtSAddress.Text;
            exp.SenderContactNo = txtSContact.Text;
            exp.ParcelType = txtParcelType.Text;
            exp.Medium = comboMedium.Text;
            exp.Status = 1;

            

            var result = exportBl.SaveExportTable(exp);
            //makeEmpty();
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }
            
             MetroMessageBox.Show(this, "Request Sent");
             
           
             exports.Add(result.Data);


            this.PopulateExportData(result.Data);
           
            }

        private void makeEmpty()
        {
            txtRName.Text="";
            txtRCountry.Text="";
            txtRAddress.Text="";
            txtRContact.Text="";
            txtSName.Text="";
            txtSAddress.Text="";
            txtSContact.Text="";
            txtParcelType.Text="";
            comboMedium.Text="";
            
        }
        
            
            
        }
    }

