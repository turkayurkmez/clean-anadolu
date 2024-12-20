using CleanCode;
using CleanCode.Application;
using CleanCode.Entities;

namespace DirtyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSheetEntries = loadEntriesFromUser();
            PaymentService paymentService = new PaymentService();

            sendEmails(timeSheetEntries, paymentService);
            double extraPayment =  paymentService.CalculateExtraPayment(timeSheetEntries);      

            Console.WriteLine($"You will get paid ${extraPayment}  for your work.");
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }


        #region local functions


        /// <summary>
        /// Tüm haftalık çalışma bilgilerini kullanıcıdan alır.
        /// </summary>
        /// <returns></returns>
        private static List<TimeSheetEntry> loadEntriesFromUser()
        {
            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
            string answer = string.Empty;
            do
            {
                var timeSheetEntry = getInfoFromUser();
                timeSheetEntries.Add(timeSheetEntry);
                Console.Write("Do you want to enter more time (yes/no): ");
                answer = Console.ReadLine();

            } while (answer.ToLower() == UserAnswer.YES);

            return timeSheetEntries;
        }

        /// <summary>
        /// Kullanıcıdan bir şirket için gereken bilgileri alır.
        /// </summary>
        /// <param name="timeSheetEntries"></param>
        /// <returns></returns>
        private static TimeSheetEntry getInfoFromUser()
        {
            Console.Write("Enter what you did: ");
            string workDescription = Console.ReadLine();
            double timeByHour;
            timeByHour = getDoubleValueFromUserString();

            TimeSheetEntry timeSheetEntry = new TimeSheetEntry
            {
                HoursWorked = timeByHour,
                WorkDone = workDescription
            };

            return timeSheetEntry;
        }

        /// <summary>
        /// Kullanıcıdan alınan string değeri double'a çevirir.
        /// </summary>
        /// <returns>double</returns>
        private static double getDoubleValueFromUserString()
        {
            Console.Write("How long did you do it for: ");
            string rawTimeWorkedByHours = Console.ReadLine();
            double timeByHour;
            while (!double.TryParse(rawTimeWorkedByHours, out timeByHour))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number given");
                Console.Write("How long did you do it for: ");
                rawTimeWorkedByHours = Console.ReadLine();
            }

            return timeByHour;
        }



        private static void sendEmails(List<TimeSheetEntry> timeSheetEntries, PaymentService paymentService)
        {
            MailService mailService = new MailService(paymentService);
            var companies = new CompanyService().GetCompanies();
            var mailOutput =  mailService.SendMailToCompanies(timeSheetEntries, companies);
            foreach (var output in mailOutput)
            {
                Console.WriteLine(output);
            }
        } 

        #endregion

     
    }
}

