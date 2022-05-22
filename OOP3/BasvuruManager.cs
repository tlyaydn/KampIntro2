using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
     class BasvuruManager
    {
        //METHOD İNJECTİON 
        public void BasvuruYap(IKrediManeger krediManeger, List<ILoggersService> loggerServices) //hangi kredi başvuracıgız seçeriz.
                                                           //interface bütün kredileri refans tutar
        {
            //başvuru bilgileri degerlendirme 
            //kredi haesaplaygız  

            krediManeger.Hesapla();
            foreach (var loggersService in loggerServices)
            {
                loggersService.Log();
            }
            
        }
        public void KrediOnBilgilendirmeYap(List<IKrediManeger>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
