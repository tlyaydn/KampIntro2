using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product urun = new Product();
            urun.Adi = "elma";
            urun.Fiyati = 15;
            urun.Aciklama = "amasya elma";
            Product urun2 = new Product();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 25;
            urun2.Aciklama = "adana karpuuz";
            Product[] urunler = new Product[] { urun, urun2 };//veri kaynagından gelicek ileri syfalarda
            foreach  (Product urun1 in urunler)//product sınııfın adı urun1 takma adı urunler dizi ismi 
            {
                Console.WriteLine(urun1.Adi);
                Console.WriteLine(urun1.Fiyati);
                Console.WriteLine(urun1.Aciklama);
                Console.WriteLine("--------");
            }
            Console.WriteLine("-------metotlar");

            //encapsulation kapsülleme ayrı ayrı yazacgın bir yapıyı bir düzenin içine sokarız 

            SepetManager sepetManager = new SepetManager(); //ınstance örnekleme class tanımlma
            sepetManager.Ekle(urun);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("armut", "yeşil", 12.5);

        }
    }
}