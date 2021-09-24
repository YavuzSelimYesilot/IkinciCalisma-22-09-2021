using System;

namespace OOP3
{
    class MsmLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Müşteriye SMS yollandı.");
        }
    }
}
