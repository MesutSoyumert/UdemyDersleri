using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    public class EfProductDal : IProductDal
    {
        List<Product> _products;

        public EfProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,
                            ProductName="Ef Acer Bilgisayar",
                            QuantityPerUnit="32 Gb Ram",
                            UnitPrice=10000,
                            UnitsInStock=2
                },
                new Product{ProductId=2,
                            ProductName="Ef Asus Bilgisayar",
                            QuantityPerUnit="32 Gb Ram",
                            UnitPrice=10000,
                            UnitsInStock=1
                },
                new Product{ProductId=3,
                            ProductName="Ef Hp Bilgisayar",
                            QuantityPerUnit="32 Gb Ram",
                            UnitPrice=10000,
                            UnitsInStock=0
                },
                new Product{ProductId=4,
                            ProductName="Ef Mac Bilgisayar",
                            QuantityPerUnit="32 Gb Ram",
                            UnitPrice=10000,
                            UnitsInStock=3
                },
                new Product{ProductId=5,
                            ProductName="Ef Dell Bilgisayar",
                            QuantityPerUnit="32 Gb Ram",
                            UnitPrice=10000,
                            UnitsInStock=10
                },
            };
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int id)
        {
            return _products;
        }

        public void Add(Product product)
        {
            Console.WriteLine("Entity Framework ile ürün eklendi"); ;
        }

        public void Update(Product product)
        {
            Console.WriteLine("Entity Framework ile ürün güncellendi"); ;
        }
        public void Delete(Product product)
        {
            Console.WriteLine("Entity Framework ile ürün silindi"); ;
        }
    }
}
