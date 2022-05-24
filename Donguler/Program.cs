using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array dizilerde tutarız 
            string[] kurslar = new string[] {"yazılım geliştirme","java",
            "programlama giriş"};

            for (int i = 0; i <kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu Footer");

        }
    }
}
