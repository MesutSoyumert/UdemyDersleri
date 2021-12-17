using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project4.DataAccess
{
    public class EfProductDal : IProductDal
    {
        List<Product> _products;

        public EfProductDal()
        {
            //_products = new List<Product>
            //{
            //    new Product{ProductId=1,
            //                ProductName="Ef Acer Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram",
            //                UnitPrice=10000,
            //                UnitsInStock=2
            //    },
            //    new Product{ProductId=2,
            //                ProductName="Ef Asus Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram",
            //                UnitPrice=10000,
            //                UnitsInStock=1
            //    },
            //    new Product{ProductId=3,
            //                ProductName="Ef Hp Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram",
            //                UnitPrice=10000,
            //                UnitsInStock=0
            //    },
            //    new Product{ProductId=4,
            //                ProductName="Ef Mac Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram",
            //                UnitPrice=10000,
            //                UnitsInStock=3
            //    },
            //    new Product{ProductId=5,
            //                ProductName="Ef Dell Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram",
            //                UnitPrice=10000,
            //                UnitsInStock=10
            //    },
            //};
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            };  
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == id);
            };
        }

        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            };
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var productToUpdate = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;
                
                context.SaveChanges();
            };
        }
        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                context.SaveChanges();
            };
        }
    }
}
