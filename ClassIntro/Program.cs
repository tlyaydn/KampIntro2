using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "tülay";
            int yas = 31;

            Kurs kurs1 =new Kurs();
            kurs1.KursAdı = "c#";
            kurs1.Egitmen = "Tülay aydın";
            kurs1.İzlenmeOranı = 70;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "JAVA";
            kurs2.Egitmen = "yAVUZ aydın";
            kurs2.İzlenmeOranı = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "c#";
            kurs3.Egitmen = "Yağmur aydın";
            kurs3.İzlenmeOranı = 80;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach(var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı+ ":"+ kurs.Egitmen+kurs.İzlenmeOranı);
               
            }
          
           //Console.WriteLine(kurs1.Egitmen + "" + kurs1.KursAdı + "" + kurs1.İzlenmeOranı);
        }

        class Kurs
        {
            public string KursAdı { get; set; }
            public  string Egitmen { get; set; }
            public int İzlenmeOranı { get; set; }
        }
    }
}
