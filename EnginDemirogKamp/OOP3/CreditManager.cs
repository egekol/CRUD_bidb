using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager
    {
        //kod içerikleri birbirinin alternatifi olmasına rağmen içerikleri farklı olan durumlar içindir.
        //polymorphism.
        void Calculate();
        void DoSmth();
    }
}
