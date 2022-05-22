using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggersService
    {
        public void Log()
        {
            Console.WriteLine("veri tabanına Loglandı");
        }
    }
}
