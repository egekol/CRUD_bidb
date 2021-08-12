using System;
using System.Collections.Generic;
using OOP3_Polymorphism;

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
            authorizeManager.Authorize(ihtiyacCreditManager);
            
            ICreditManager tasitCreditManager = new TasitCreditManager();
            //tasitCreditManager.Calculate();
            ICreditManager konutCreditManager = new KonutCreditManager();
            //konutCreditManager.Calculate();

            Console.WriteLine("-------------------------");
            List<ICreditManager> creditList = new List<ICreditManager>(){ihtiyacCreditManager, konutCreditManager};
            authorizeManager.KrediOnBilgilendirmesiYap(creditList);


        }
    }
}
