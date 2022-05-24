using System;

namespace KampIntro2
{
    internal class Program
    {
        //do not speat yourself(keNdini tekrar etme)
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
                Console.WriteLine("Azalış");
            }
            else if(dolarDun < dolarBugun)
             {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }
            if (sistemeGirişYapmısmi==true)
            {
                Console.WriteLine("Kullanııcı Ayarlama butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butunu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
