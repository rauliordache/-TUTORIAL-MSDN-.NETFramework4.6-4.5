using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Windows_Service_Application
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            MailAddress to = new MailAddress("windowsservicesapp@gmail.com");
            MailAddress from = new MailAddress("windowsservicesapp@gmail.com");
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Titlul.";
            message.Body = @"Serviciul a pornit!";
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = Convert.ToInt16("587");
            client.Credentials = new System.Net.NetworkCredential("windowsservicesapp@gmail.com", "appserviceswindows");
            client.EnableSsl = true;      
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex.ToString());
            }
        }

        protected override void OnStop()
        {
            MailAddress to = new MailAddress("windowsservicesapp@gmail.com");
            MailAddress from = new MailAddress("windowsservicesapp@gmail.com");
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Titlul.";
            message.Body = @"Serviciul s-a oprit!";
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = Convert.ToInt16("587");
            client.Credentials = new System.Net.NetworkCredential("windowsservicesapp@gmail.com", "appserviceswindows");
            client.EnableSsl = true;
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex.ToString());
            }
        }
    }
}
