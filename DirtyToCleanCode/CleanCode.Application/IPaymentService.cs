using CleanCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Application
{
    public interface IPaymentService
    {
        public double CalculateExtraPayment(List<TimeSheetEntry> timeSheetEntries, double maxHourInAWeek = 40, double extraPrice = 15, double standardPrice = 10);

        public double GetTotalBillForCompany(List<TimeSheetEntry> timeSheetEntries, CompanyInfo companyInfo);

    }
}
