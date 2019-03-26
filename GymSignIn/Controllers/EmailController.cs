using GymSignIn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSignIn.Controllers
{
    class EmailController
    {

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
       public  void SendEmailTo(Client User)
        {
            login = new NetworkCredential("est.juanpablotorres@gmail.com", "jp84704tt");
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress("est.juanpablotorres" + "@gmail.com", "Juan Pablo Torres ", Encoding.UTF8) };
            msg.To.Add(new MailAddress(User.Email));

            msg.Subject = User.Name + " Sing in";
            msg.Body += Environment.NewLine + "========Receipt========";
            msg.Body += Environment.NewLine + "Name:" + User.Name;
            msg.Body += Environment.NewLine + "Phone:" + User.Phone;
            msg.Body += Environment.NewLine + "ID:" + User.ID.ToString();
            msg.Body += Environment.NewLine + "Payment Status:" + User.PayStatus;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = false;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompleteCallback);
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);
        }
        private static void SendCompleteCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public EmailController()
        {

        }
    }
}
