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

            for (int i = 0; i <kurslar.Length; i++) //kuslar dinamik yapı yaptık kurslar 
            {
                Console.WriteLine(kurslar[i]);//dizideki döngüde yazarız
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)//dizi yapk tek dolaş fore dizleruısını te
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu footer");

        }
    }
}
