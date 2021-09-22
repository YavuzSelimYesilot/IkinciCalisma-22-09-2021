using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    //ürünlerle ilgili Fonksiyonları Tutan Class
    class BasketManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Urun Sepete Eklendi :  " + product.productName);
        }
    }
}
