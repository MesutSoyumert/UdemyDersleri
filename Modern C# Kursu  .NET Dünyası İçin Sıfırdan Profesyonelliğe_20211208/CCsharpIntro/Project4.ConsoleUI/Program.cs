using Project4.Business;
using Project4.DataAccess;
using Project4.Entities;
using System;

namespace Project4.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
          
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            try
            {
                productManager.Add(new Product
                {
                    ProductId = 10,
                    ProductName = "Laptop",
                    QuantityPerUnit = "4 Ayaklı Masa",
                    UnitPrice = 1000
                });
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
