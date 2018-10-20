using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LodungaWebsite
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("sitholeknows@gmail.com");
                mail.To.Add("sitholeknows@outlook.com");
                mail.ReplyToList.Add(Email.Text);
                mail.Subject = Subject.Text;
                mail.Body = Massage.Text + "<br/><br/><br/>" + Name.Text;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("sitholeknows@gmail.com", "211227630");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                // MessageBox.Show("mail Send");
                Massage.Text = "";
                Name.Text = "";
                Subject.Text = "";
                Email.Text = "";
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
        }
    }
}