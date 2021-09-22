using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product pro1 = new Product();

            pro1.productName = "Armut";
            pro1.productPrice = 15;
            pro1.productExplanation = "Antalya Armutu";

            Product pro2 = new Product();

            pro2.productName = "Elma";
            pro2.productPrice = 5;
            pro2.productExplanation = "Amasya Elması";

            Product[] products = new Product[] { pro1, pro2 };

            foreach (var urun in products)
            {
                Console.WriteLine(urun.productName);
                Console.WriteLine(urun.productPrice);
                Console.WriteLine(urun.productExplanation);
                Console.WriteLine("-----------------");
            }


            BasketManager basketManager = new BasketManager();

            basketManager.Add(pro1);
            basketManager.Add(pro2);
            



        }
    }
}
