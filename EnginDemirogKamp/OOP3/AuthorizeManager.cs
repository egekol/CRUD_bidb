using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP3;
using OOP3_Polymorphism_Injection;

namespace OOP3_Polymorphism
{
    class AuthorizeManager
    {
        //Method Injection
        public void Authorize(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> creditManager)
        {
            foreach (var manager in creditManager)
            {
                manager.Calculate();
            }
        }

        //public void LogAfterAuthorizing(List<ILoggerService> loggerServices)
        //{
        //    foreach (var loggerService in loggerServices)
        //    {
        //        loggerService.Log();
                
        //    }
        //}

    }
}
