using System;

namespace OOP3_Polymorphism_Injection
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged in to the file.");
        }
    }
}