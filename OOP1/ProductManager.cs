using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
   class ProductManager // ürün ile irlgili  operasyonlar var silme ekleme
    {
        //encapsulaciton tek tek belirtmeyip class içinde 
     public void Add(Product product)// product sınııfna içinde ürün ver
        {
         Console.WriteLine(product.ProductName+"Eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "GÜNCELLENDİ");
        }
         
    }
}
