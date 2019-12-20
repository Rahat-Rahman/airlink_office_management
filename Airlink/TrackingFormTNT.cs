using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlink
{
    public partial class TrackingFormTNT : MetroFramework.Forms.MetroForm
    {
        

        public TrackingFormTNT(string trackTNT)
        {
            InitializeComponent();
            txtTNTTrack.Text = trackTNT;
            Navigate(trackTNT);
            
        }



        private void Navigate(string trackNo)
        {
            
           string tnt = "http://www.tnt.com/express/en_gb/site/home/applications/tracking.html?cons=" + trackNo + "&searchType=REF";
           webBrowser2.Navigate(tnt);
            
          }

 

        private void TrackingFormTNT_Load(object sender, EventArgs e)
        {

        }

        private void btnTNTTrack_Click(object sender, EventArgs e)
        {
            Navigate(txtTNTTrack.Text);
        }

        private void TrackingFormTNT_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomePage hp=new HomePage();
            hp.Show();
            this.Hide();
        }
    }
}
