using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
namespace UMS.BAL
{
    class EmailHandler
    {
        public static Boolean SendEmail(String toEmailAddress, String subject, String body)
        {
            try
            {
                String fromDisplayEmail = "EAD.SEMorning@gmail.com";
                String fromPassword = "SEMorning2017";
                String fromDisplayName = "User Management System";
                MailAddress fromAddress = new MailAddress(fromDisplayEmail, fromDisplayName); System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                MailAddress toAddress = new MailAddress(toEmailAddress);
                System.Net.Mail.SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                }
                )
                {
                    smtp.Send(message);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
