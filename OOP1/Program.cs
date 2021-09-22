using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Desk";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 25;

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Pen", UnitPrice = 50, UnitsInStock = 100 };

            ProductManeger productManeger = new ProductManeger();

            productManeger.Add(product1);


        }
    }
}
