using CleanCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Application
{
    public class CompanyService
    {
        public List<CompanyInfo> GetCompanies()
        {
            return new List<CompanyInfo>
            {
                new CompanyInfo
                {
                    Name = "Acme",
                    HourlyRate = 150
                },
                new CompanyInfo
                {
                    Name = "ABC",
                    HourlyRate = 125
                }
            };
        }
    }
}
