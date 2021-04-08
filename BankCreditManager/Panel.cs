using BankCrediService.Abstract;
using System;
using System.Collections.Generic;

namespace BankCrediService
{
    class Panel
    {
        static void Main(string[] args)
        {
            ICreditService ihtiyacCrediManager = new IhtiyacCreditManager();
            ICreditService tasitCrediManager = new TasitCreditManager();
            ICreditService konutCrediManager = new KonutCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            List<ILoggerService> loggerService = new List<ILoggerService>()
            {
                databaseLoggerService,
                fileloggerService
            };


            List<ICreditService> credits = new List<ICreditService>()
            {
                tasitCrediManager,
                konutCrediManager
            };

            ApplicationManager applicationManager = new ApplicationManager();
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" ");
            applicationManager.MakeAnApplication(ihtiyacCrediManager,loggerService);
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" ");
            applicationManager.CreditPreInformation(credits);
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" ");
        }
    }
}
