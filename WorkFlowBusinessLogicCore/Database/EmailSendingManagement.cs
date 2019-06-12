using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Mail;
using System.Text;

namespace WorkFlowBusinessLogicCore.Database
{
    public class EmailSendingManagement
    {
        public void SendEmail(string To, string subject, string template)
        {
            string fromAddress = "e.v.e.r.e.s.tt.1551@gmail.com";
            MailAddress from = new MailAddress(fromAddress);
            MailAddress to = new MailAddress(To);
            MailMessage mail = new MailMessage(from, to);
            mail.Subject = subject;
            mail.Body = template;
            mail.IsBodyHtml = true;
            using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
            {
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("e.v.e.r.e.s.tt.1551@gmail.com", "852963741951");
                client.EnableSsl = true;
                client.Send(mail);
            }                 
        }
    }
}
