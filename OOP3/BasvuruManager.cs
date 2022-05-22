using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
     class BasvuruManager
    {
        public void BasvuruYap(IKrediManeger krediManeger) //hangi kredi başvuracıgız seçeriz.
                                                           //interface bütün kredileri refans tutar
        {
            //başvuru bilgileri degerlendirme 
            //kredi haesaplaygız 

            krediManeger.Hesapla();
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
