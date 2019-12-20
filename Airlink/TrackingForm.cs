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
    public partial class TrackingForm : MetroFramework.Forms.MetroForm
    {
        public TrackingForm(string track)
        {
            InitializeComponent();
            txtTrack.Text = track;
            Navigate(track);
        }

        private void TrackingForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            Navigate(txtTrack.Text);
        }

        private void Navigate(string trackNo)
        {
            if (true)
            {
                string dhl = "http://www.dhl.com/en/express/tracking.html?AWB=" + trackNo + "&brand=DHL";
                webBrowser1.Navigate(dhl);
            }
            else
            {
                string tnt = "http://www.tnt.com/express/en_gb/site/home/applications/tracking.html?cons="+trackNo+"&searchType=REF";
                webBrowser1.Navigate(tnt);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void TrackingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomePage hp=new HomePage();
            hp.Show();
            this.Hide();
        }
    }
}
