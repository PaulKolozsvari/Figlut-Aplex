namespace Figlut.Web.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Net.Mail;
    using System.Net;
    using System.IO;
    using System.Net.Mime;

    #endregion //Using Directives

    public class EmailSender
    {
        #region Constructors



        #endregion //Constructors

        #region Methods

        public static void SendMail(
            string subject,
            string body,
            List<EmailAttachment> attachments,
            List<string> recipients)
        {
            SmtpClient smtpClient = GetSMTPClient();
            MailMessage email = GetMailMessage(subject, body);
            recipients.ForEach(p => email.To.Add(p));
            if (attachments != null)
            {
                foreach(EmailAttachment a in attachments)
                {
                    using (MemoryStream ms = new MemoryStream(a.AttachmentBytes))
                    {
                        email.Attachments.Add(new Attachment(ms, a.AttachmentFileName, MediaTypeNames.Text.Plain));
                    }
                }
            }
            smtpClient.Send(email);
        }

        private static SmtpClient GetSMTPClient()
        {
            SmtpClient result = new SmtpClient();
            result.Host = Options.Instance.Settings.GMailSMTPServer;
            result.Port = Options.Instance.Settings.GMailSMTPPort;
            result.Credentials = new NetworkCredential(
                Options.Instance.Settings.GMailUserName,
                Options.Instance.Settings.GMailPassword);
            result.EnableSsl = true;
            return result;
        }

        private static MailMessage GetMailMessage(string subject, string body)
        {
            return new MailMessage()
            {
                Sender = new MailAddress(Options.Instance.Settings.FromEmailAddress, Options.Instance.Settings.FromName),
                From = new MailAddress(Options.Instance.Settings.FromEmailAddress, Options.Instance.Settings.FromName),
                Subject = subject,
                Body = body,
                IsBodyHtml = false
            };
        }

        #endregion //Methods
    }
}