using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.Id = 1;
            musteri1.MusteriNo = "1234";
            musteri1.Ad = "Tülay";
            musteri1.Soyadi = "Aydın";
            musteri1.TcNo = "4566897895";
            
            
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "2345";
            musteri2.SirketAdi = "Tülay.com";
            musteri2.VergiNo = "2345673549";



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager mustegriManager=new MusteriManager();
            mustegriManager.Ekle(musteri1);
            mustegriManager.Ekle(musteri2);
          
           
            

        }
    }
}
