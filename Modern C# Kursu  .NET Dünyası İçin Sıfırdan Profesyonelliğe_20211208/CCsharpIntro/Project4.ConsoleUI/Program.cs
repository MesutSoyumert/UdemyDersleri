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

            //productManager.Delete(new Product { ProductId = 80 });
            //,CategoryId = 1, 
            //ProductName = "Masa Güncellenen ürün 3", 
            //QuantityPerUnit = "4 Ayaklı Masa", 
            //UnitPrice = 1000,
            //UnitsInStock = 10});

            Console.WriteLine(productManager.GetById(1).ProductName);
            
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //try
            //{
              //  productManager.Add(new Product
              //  {
              //      CategoryId = 1,
              //      ProductName = "Eklenen ürün 2",
              //      QuantityPerUnit = "4 Ayaklı Masa",
              //      UnitPrice = 1000,
              //      UnitsInStock = 10
              //});
            //}
            //catch (Exception exception)
            //{

            //    Console.WriteLine(exception.Message);
            //}

            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());

            foreach (var personel in personelManager.GetAll())
            {
                Console.WriteLine("{0} / {1} / {2}",
                                    personel.Id, personel.Name, personel.SurName);
            }
        }
    }
}