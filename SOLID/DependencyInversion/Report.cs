using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
    public  class ReportSender
    {
        private ISender sender;

        public ReportSender(ISender sender)
        {
            this.sender = sender;
        }

        public Report Report { get; set; }

        //public EmailSender emailSender { get; set; }
        public void Send(string to)
        {
            //EmailSender emailSender = new EmailSender();
            sender.Send(to);
        }
    }


    public interface ISender
    {
        void Send(string to);
    }

    public class EmailSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Email gönderildi.");
        }
    }

    public class SmsSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Sms gönderildi.");
        }
    }

    public class WhatsappSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Whatsapp gönderildi.");
        }
    }
}
