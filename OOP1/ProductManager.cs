using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
   class ProductManager // ürün ile operasyonlar var silme eklme
    {
        //encapsulaciton tek tek belirmeyip clasa içinde hepsine vere
     public void Add(Product product)//nasıl çegırcagını anlatım product sınııfna içinde ürün vaer
        {
         Console.WriteLine(product.ProductName+"eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "GÜNCELLENDİ");
        }
         
    }
}
