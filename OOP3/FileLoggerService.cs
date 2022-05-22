using System;

namespace OOP3
{
    class FileLoggerService : ILoggersService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya  Loglandı");  
        }
    }
}
