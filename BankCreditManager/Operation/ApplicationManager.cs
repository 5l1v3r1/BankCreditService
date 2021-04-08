using BankCrediService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCrediService
{
    class ApplicationManager
    {
        public void MakeAnApplication(ICreditService crediManager, List<ILoggerService> loggerService)
        {
            crediManager.Calculate();

            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }

        public void CreditPreInformation(List<ICreditService> credit)
        {
            foreach (var credi in credit)
            {
                credi.Calculate();
            }
        }

    }
}
