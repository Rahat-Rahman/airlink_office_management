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
using LoggedInId;

namespace Airlink
{
    public partial class loginPage : MetroFramework.Forms.MetroForm
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
                checkBoxShow.Enabled = false;

        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBoxShow.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage hp=new HomePage();
            this.Visible = false;
            hp.Visible = true;
        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void loginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomePage h1 = new HomePage();
            h1.Show();
            this.Hide();
           
            
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
                checkBoxShow.Enabled = true;

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            EmployeeTableBL employee=new EmployeeTableBL();

            var emp = employee.GetEmployeeTableById(txtId.Text).Data.Password.Trim().Equals(txtPass.Text.Trim());

            if (emp)
            {
                LoggedInId.LogId.Id = txtId.Text.Trim();
                if (txtId.Text.Trim().EndsWith("1"))
                {
                    LoggedInId.LogId.isAdmin = true;
                    
                }
                else
                {
                    LoggedInId.LogId.isAdmin = false;
                }

                if (Equals(LoggedInId.LogId.isAdmin, true))
                {
                    EmpPageAdmin Ea = new EmpPageAdmin();


                    Ea.Show();
                    this.Hide();
                }

                if (txtId.Text.Trim().EndsWith("2"))
                {
                    EmpPage2 emp2=new EmpPage2();
                    emp2.Show();
                    this.Hide();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid Id or Password");
            }


            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeTableBL bl = new EmployeeTableBL();
            var result = bl.GetEmployeeTableById(txtId.Text);

            if (result.HasError)
            {
                MetroFramework.MetroMessageBox.Show(this, result.Messages[0]);
                return;
            }
            if (result.Data == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid ID");
                return;
            }
           LogId.LoginUserInfo= result.Data;
           MailSender ms = new MailSender();
        }

        
    }
}
