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
    public partial class trackingFormDpex : MetroFramework.Forms.MetroForm
    {
        public trackingFormDpex(string trackID)
        {
            InitializeComponent();
            txtDPEXTrack.Text = trackID;
            Navigate(trackID);
        }


        private void Navigate(string trackNo)
        {

            string tnt = " https://dpex.com/Tools-And-Applications/Track-And-Trace?cn=" + trackNo;
            webBrowser3.Navigate(tnt);
            

        }

        private void trackingFormDpex_Load(object sender, EventArgs e)
        {

        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            Navigate(txtDPEXTrack.Text);
        }

        private void trackingFormDpex_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }
    }
}
