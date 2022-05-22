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
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager);
            basvuruManager.BasvuruYap(tasitKrediManager);
            basvuruManager.BasvuruYap(ihtiyacKrediManager);
            List<IKrediManeger> krediler = new List<IKrediManeger>() {ihtiyacKrediManager };

            basvuruManager.KrediOnBilgilendirmeYap(krediler);
            
        }
    }
}
