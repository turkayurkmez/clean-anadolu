using CleanCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Application
{
    public class PaymentService : IPaymentService
    {
        public double CalculateExtraPayment(List<TimeSheetEntry> timeSheetEntries, double maxHourInAWeek = 40, double extraPrice = 15, double standardPrice = 10)
        {
            double totalHours = timeSheetEntries.Sum(x => x.HoursWorked);
            double billAmount = 0;

            if (totalHours > maxHourInAWeek)
            {
                var extraTime = totalHours - maxHourInAWeek;
                var extra = extraTime * extraPrice;
                var standard = maxHourInAWeek * standardPrice;

                billAmount = extra + standard;
            }
            else
            {
                billAmount = totalHours * standardPrice;

            }

            return billAmount;
        }

        public double GetTotalBillForCompany(List<TimeSheetEntry> timeSheetEntries, CompanyInfo companyInfo)
        {
          var totalHours = timeSheetEntries.Where(x=>isThatCompany(x,companyInfo.Name))
                                           .Sum(x => x.HoursWorked);

            return totalHours * companyInfo.HourlyRate;
          
        }

        private bool isThatCompany(TimeSheetEntry timeSheetEntry, string companyName)
        {
            var completedWork = timeSheetEntry.WorkDone.ToLower();
            var company = companyName.ToLower();
            return completedWork.Contains(company);
            //return timeSheetEntry.WorkDone.ToLower() == companyName.ToLower();
        }
    }
}
