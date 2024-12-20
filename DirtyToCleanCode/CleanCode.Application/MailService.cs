using CleanCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Application
{

    public class MailService
    {
        private readonly IPaymentService paymentService;

        public MailService(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        public List<string> SendMailToCompanies(List<TimeSheetEntry> timeSheetEntries, List<CompanyInfo> companies)
        {
            List<string> mailBodies = new List<string>();
            foreach (var company in companies)
            {
                double totalPriceForCompany = paymentService.GetTotalBillForCompany(timeSheetEntries, company);
                string mailBody = $"Simulating sending mail to {company.Name}\nYour bill is ${totalPriceForCompany} for the hours worked" ;
                mailBodies.Add(mailBody);
            }

            return mailBodies;


        }

    }
}
