using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Notifications
    {
        /// <summary>
        /// Send email with attachment
        /// </summary>
        /// <param name="toAddresses">To address</param>
        /// <param name="subject">Subject</param>
        /// <param name="body">Body text</param>
        /// <param name="attachmentPath">Attachment paths</param>
        public static void SendEmail(string[] toAddresses, string subject, string body)
        {
            try
            {
                var basicCredential = new NetworkCredential("M3Output@Patties.com.au", "");

                string from = "M3Output@Patties.com.au";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                foreach (string item in toAddresses)
                {
                    mail.To.Add(item);
                }

                mail.Subject = subject;
                mail.Body = body;

                //Attachment attachment = new System.Net.Mail.Attachment(attachmentPath);
                //mail.Attachments.Add(attachment);

                SmtpClient smtpClient = new SmtpClient("smtp.office365.com");
                smtpClient.Port = Convert.ToInt16("567");
                //smtpClient.UseDefaultCredentials = false;
                //smtpClient.Credentials = basicCredential;
                smtpClient.Credentials = CredentialCache.DefaultNetworkCredentials;
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SendEmail1()
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("M3Output@Patties.com.au", "");
                MailAddress from = new MailAddress("M3Output@Patties.com.au", String.Empty, System.Text.Encoding.UTF8);
                MailAddress to = new MailAddress("MohamedAk@fortude.co");
                MailMessage message = new MailMessage(from, to);
                message.Body = "This is your body message";
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.Subject = "Test GL Process email";
                message.SubjectEncoding = System.Text.Encoding.UTF8;

                client.Send(message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
