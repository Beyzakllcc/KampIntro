using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoyId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoyId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };
            //PascalCase    //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Update(product2);
            //int, double, bool... değer tip
            //diziler, class, abstract class, interfaces ... referance tip
            //ref out
        }
    }
}
