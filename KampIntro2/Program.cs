using System;

namespace KampIntro2
{
    internal class Program
    {
        //do not speat yourself(kebdini tekrar etme)
        static void Main(string[] args)
        {
            
            
            string kategoriEtiketi = "Kategoriler";
            int ogrencisayısı = 3200;
            double faizoranı = 1.45;
            bool sistemeGirişYapmısmi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış");
            }
            else if(dolarDun < dolarBugun)
             {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }
            if (sistemeGirişYapmısmi==true)
            {
                Console.WriteLine("Kullanııcı Ayarlatı butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butuno");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
