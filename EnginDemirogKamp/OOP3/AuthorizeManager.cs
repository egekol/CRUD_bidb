using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP3;

namespace OOP3_Polymorphism
{
    class AuthorizeManager
    {

        public void Authorize(ICreditManager creditManager)
        {
            creditManager.Calculate();
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> creditManager)
        {
            foreach (var manager in creditManager)
            {
                manager.Calculate();
            }
        }

    }
}
