using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    internal class notification
    {
        public class notifi
        {
            
            public void sent_email_forget_pass(string pass,string email,string name)
            {
                MailAddress to = new MailAddress(email);
                MailAddress from = new MailAddress("mh798641@gmail.com");
                MailMessage message = new MailMessage(from, to);
                message.Subject =  "password";
                message.Body = "Dear " +name + "," + "\n" + "Your password is:" + pass+"\n" + "Best regards.";
                message.Priority = MailPriority.High;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("mh798641@gmail.com", password: "mlhsdjxwmcjeopbv");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.Send(message);

            }
            public void sent_email_delete(string email,string name)
            {
                MailAddress to = new MailAddress(email);
                MailAddress from = new MailAddress("mh798641@gmail.com");
                MailMessage message = new MailMessage(from, to);
                message.Subject = "Delete";
                message.Body = "Dear " + name + "," + "\n" + "Your account has been deleted!" + "\n" + " We hope you enjoyed your time here with us!! " +"Best regards.";
                message.Priority = MailPriority.High;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("mh798641@gmail.com", password: "mlhsdjxwmcjeopbv");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
            public void sent_email_signup(string email, string name)
            {
                MailAddress to = new MailAddress(email);
                MailAddress from = new MailAddress("mh798641@gmail.com");
                MailMessage message = new MailMessage(from, to);
                message.Subject = "Signup ";
                message.Body = "Dear " + name + ","+ "\n" + "Welcome to your time mangement Place where nothing is missed to be done! " + "\n" + "Best regards.";
                message.Priority = MailPriority.High;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("mh798641@gmail.com", password: "mlhsdjxwmcjeopbv");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
        }
    }
}
