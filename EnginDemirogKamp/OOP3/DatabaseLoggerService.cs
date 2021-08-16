using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_Polymorphism_Injection
{
    class DatabaseLoggerService:ILoggerService
    {

        public void Log()
        {
            Console.WriteLine("Logged in to the database.");
        }
    }
}
