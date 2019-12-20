using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airlink.BusinessLogic;
using Airlink.Data;
using Airlink.Framework;
using LoggedInId;

namespace Airlink
{
    class MailSender
    {
        private EmployeeTableBL empBl =new EmployeeTableBL();

        public MailSender()
        {
            this.LoadEmployee();
        }

        private void LoadEmployee()
        {
            var result = empBl.GetEmployeeTableById(LogId.LoginUserInfo.Id.ToString());
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }
            this.Sender(result);
        }

        private void Sender(Result<EmployeeTable> result)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com",587);
                MailMessage message = new MailMessage();
                client.EnableSsl = true;
                //client.Timeout = 100;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("rahatrm13@gmail.com","whyalwyzme!!");
                message.From = new MailAddress("rahatrm13@gmail.com");
                message.To.Add(result.Data.Email.ToString());
                message.Body = result.Data.Password.ToString();
                message.Subject = "Your Account Password";



                //if (txtAttachment.Text != "")
                //{
                //    message.Attachments.Add(new Attachment(txtAttachment.Text));
                //}
                client.Send(message);

                MessageBox.Show("Email Sent");
                message = null;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
