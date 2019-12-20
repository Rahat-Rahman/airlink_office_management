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

namespace Airlink
{
    public partial class HomePage : MetroFramework.Forms.MetroForm
    {
        private RatesBL ratesBl = new RatesBL();
        private int i = 1;

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            //pictureBox1.Load();

            comboCountry.DataSource = ratesBl.GetAllRates("", null, null).Data;
            comboCountry.DisplayMember = "Country";
            comboCountry.ValueMember = "RatesID";

            timer1.Start();
            hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 5)
            {
                i = 1;
            }

            pictureBox1.Load(i + ".jpg");

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }



        private void btnExportTitle_Click(object sender, EventArgs e)
        {
            ExportReqInfo ei = new ExportReqInfo();
            ei.Visible = true;
            this.Visible = false;
        }

        private void lblRates_Click(object sender, EventArgs e)
        {

        }

        private void hide()
        {
            PanelExport.Enabled = false;
            PanelImport.Enabled = false;
            PanelExportServices.Visible = false;
            panelImportS.Visible = false;
            PanelHeadOffice.Visible = false;
            panelContact.Visible = false;
            PanelCareer.Visible = false;
            PanelMission.Visible = false;
            panelSectorOverview.Visible = false;

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            PanelExport.Enabled = true;
            PanelImport.Enabled = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            PanelImport.Enabled = true;
            PanelExport.Enabled = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            loginPage lp = new loginPage();
            lp.Visible = true;
            this.Visible = false;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ImportReqInfo ii = new ImportReqInfo();
            ii.Visible = true;
            this.Visible = false;
        }

        private void btnExpCross_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void btnCrossImp_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void btnCrossCareer_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void btnCrossMission_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void btnCrossOverview_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void exportServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelExportServices.Visible = true;

            panelImportS.Visible = false;
            PanelHeadOffice.Visible = false;
            panelContact.Visible = false;
            PanelCareer.Visible = false;
            PanelMission.Visible = false;
            panelSectorOverview.Visible = false;

        }

        private void importServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panelImportS.Visible = true;


            PanelExportServices.Visible = false;
            PanelHeadOffice.Visible = false;
            panelContact.Visible = false;
            PanelCareer.Visible = false;
            PanelMission.Visible = false;
            panelSectorOverview.Visible = false;

        }

        private void headOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelHeadOffice.Visible = true;

            PanelExportServices.Visible = false;
            panelImportS.Visible = false;
            panelContact.Visible = false;
            PanelCareer.Visible = false;
            PanelMission.Visible = false;
            panelSectorOverview.Visible = false;
        }

        private void contactDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContact.Visible = true;

            PanelHeadOffice.Visible = false;
            panelImportS.Visible = false;
            PanelExportServices.Visible = false;
            PanelCareer.Visible = false;
            PanelMission.Visible = false;
            panelSectorOverview.Visible = false;
        }

        private void careerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelCareer.Visible = true;

            panelContact.Visible = false;
            PanelHeadOffice.Visible = false;
            panelImportS.Visible = false;
            PanelExportServices.Visible = false;
            PanelMission.Visible = false;
            panelSectorOverview.Visible = false;
        }

        private void missionAndVisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelMission.Visible = true;

            PanelCareer.Visible = false;
            panelContact.Visible = false;
            PanelHeadOffice.Visible = false;
            panelImportS.Visible = false;
            PanelExportServices.Visible = false;
            panelSectorOverview.Visible = false;
        }

        private void sectorOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSectorOverview.Visible = true;

            PanelMission.Visible = false;
            PanelCareer.Visible = false;
            panelContact.Visible = false;
            PanelHeadOffice.Visible = false;
            panelImportS.Visible = false;
            PanelExportServices.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }








        private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            // emp.departmentId = Int32.Parse(ddlEDepartment.SelectedValue.ToString());
            //RatesBL rate=new RatesBL();
            //var rates=rate.GetAllRates()


        }

        private void btnDhlLogo_Click(object sender, EventArgs e)
        {
            if (comboCountry.SelectedItem == null)
                return;

            var rate = comboCountry.SelectedItem as Rate;

            if (rate == null)
                return;

            lblRate2.Text = rate.DHLRate + "";
        }

        private void btnTntLogo_Click(object sender, EventArgs e)
        {
            if (comboCountry.SelectedItem == null)
                return;

            var rate = comboCountry.SelectedItem as Rate;

            if (rate == null)
                return;

            lblRate2.Text = rate.TNTRate + "";
        }

        private void btnDepxLogo_Click(object sender, EventArgs e)
        {
            if (comboCountry.SelectedItem == null)
                return;

            var rate = comboCountry.SelectedItem as Rate;

            if (rate == null)
                return;

            lblRate2.Text = rate.DPEXRate + "";
        }

        private void lblRate2_Click(object sender, EventArgs e)
        {

        }

        private void btnDhlLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dhl.com/en.html");
        }

        private void btnTntLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tnt.com/express/en_gb/site/home.html");
        }

        private void btnDpexLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dpex.com/Tools-And-Applications/Track-And-Trace");
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            TrackingForm tf = new TrackingForm(txtTrack.Text);
            tf.Show();
            this.Hide();
            
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
        }

        private void btnTNTTrack_Click(object sender, EventArgs e)
        {
            TrackingFormTNT tf = new TrackingFormTNT(txtTrack.Text);
            tf.Show();
            this.Hide();
        }

        private void btnDPEXTrack_Click(object sender, EventArgs e)
        {
            trackingFormDpex td = new trackingFormDpex(txtTrack.Text);
            td.Show();
            this.Hide();
        }


    }

}

