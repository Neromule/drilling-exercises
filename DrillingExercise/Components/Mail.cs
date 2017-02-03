using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Drilling
{
    public class Mail
    {
        public static bool Send(string adress, string subject, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                //ajouter les destinataires
                mail.To.Add(adress);

                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = message;
                //définir l'expéditeur
                mail.From = new MailAddress("drilling.exercises@gmail.com", "Drilling Exercises");
                //définir les paramètres smtp pour l'envoi
                SmtpClient smtpServer = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("drilling.exercises@gmail.com", "projettutore")
                };
                //envoi du mail
                smtpServer.Send(mail);
                return true;
            }
            catch
            {
                //Console.WriteLine(e.Message);
                return false;
            }

        }
    }
}
