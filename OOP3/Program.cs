using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManeger ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManeger tasitKrediManager = new TasitKrediManager();
            IKrediManeger konutKrediManager = new KonutKrediManager();
            

            ILoggersService databaseLoggerService= new DatabaseLoggerService();
            ILoggersService fileLoggerService = new FileLoggerService();

            List<ILoggersService> loggers = new List<ILoggersService> { new DatabaseLoggerService(), new FileLoggerService() };
            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(konutKrediManager,loggers);
           
            basvuruManager.BasvuruYap(tasitKrediManager,loggers);  
            List<IKrediManeger> krediler = new List<IKrediManeger>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };

           // basvuruManager.KrediOnBilgilendirmeYap(krediler);
            
        }
    }
}
