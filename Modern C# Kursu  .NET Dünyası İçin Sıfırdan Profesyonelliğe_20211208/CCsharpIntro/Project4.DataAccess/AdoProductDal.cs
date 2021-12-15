using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    public class AdoProductDal : IProductDal
    {
        List<Product> _products;

        public AdoProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,
                            ProductName="Ado Acer Bilgisayar",
                            QuantityPerUnit="32 Gb Ram",
                            UnitPrice=10000,
                            UnitsInStock=2
                },
                new Product{ProductId=2,
                            ProductName="Ado Asus Bilgisayar",
                            QuantityPerUnit="32 Gb Ram",
                            UnitPrice=10000,
                            UnitsInStock=1
                },
                new Product{ProductId=3,
                            ProductName="Ado Hp Bilgisayar",
                            QuantityPerUnit="32 Gb Ram",
                            UnitPrice=10000,
                            UnitsInStock=0
                },
                new Product{ProductId=4,
                            ProductName="Ado Mac Bilgisayar",
                            QuantityPerUnit="32 Gb Ram",
                            UnitPrice=10000,
                            UnitsInStock=3
                },
                new Product{ProductId=5,
                            ProductName="Ado Dell Bilgisayar",
                            QuantityPerUnit="32 Gb Ram",
                            UnitPrice=10000,
                            UnitsInStock=10
                },
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado.net ile ürün eklendi");
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
