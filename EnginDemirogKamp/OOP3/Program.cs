using System;
using System.Collections.Generic;
using OOP3_Polymorphism;
using OOP3_Polymorphism_Injection;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            //ihtiyacCreditManager.Calculate();
            //IhtiyacCreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            //------Yerine------
            AuthorizeManager authorizeManager = new AuthorizeManager();

            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            //authorizeManager.Authorize(ihtiyacCreditManager);
            
            ICreditManager tasitCreditManager = new TasitCreditManager();
            //tasitCreditManager.Calculate();
            ICreditManager konutCreditManager = new KonutCreditManager();
            //konutCreditManager.Calculate();

            Console.WriteLine("-------------------------");
            List<ICreditManager> creditList = new List<ICreditManager>(){ihtiyacCreditManager, konutCreditManager};
            authorizeManager.KrediOnBilgilendirmesiYap(creditList);

            Console.WriteLine("-------------------------");

            //authorizeManager.Authorize(ihtiyacCreditManager, new DatabaseLoggerService());
            
            Console.WriteLine("-------------------------");
            //authorizeManager.LogAfterAuthorizing(new List<ILoggerService>()
            //{
            //    new DatabaseLoggerService(),new FileLoggerService()

            //}); YERİNE:

            authorizeManager.Authorize(ihtiyacCreditManager, new List<ILoggerService>()
            {
                new DatabaseLoggerService(), new FileLoggerService()
            });


        }
    }
}
