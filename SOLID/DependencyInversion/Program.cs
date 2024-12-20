// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");


ReportSender reportSender = new ReportSender(new EmailSender());
ReportSender reportSender2 = new ReportSender(new SmsSender());
ReportSender reportSender3 = new ReportSender(new WhatsappSender());

reportSender.Send("sample");
reportSender2.Send("sample");
reportSender3.Send("sample");



