using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;//mobilya katagori
            product1.ProductName = "AKILLI MASA";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 4;
            //sınıfı iki türlüde bilgi girebiliriz.
            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitPrice = 52,
                ProductName = "SİLGİ",
                UnitsInStock=4
            };
            //passalcase   //camelpase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
        }
    }
}//int ,double deger tipi atama deger üzerinden olur bütün bağlantı kopap
//diziler ,class,abstract class ,interface refarns tipi bellketeki adresiyle yapılır 
//adresdeki degeri okuruz 101 bellek
