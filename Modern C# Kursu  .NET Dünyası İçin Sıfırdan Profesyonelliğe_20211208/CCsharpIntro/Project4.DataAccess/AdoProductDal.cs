using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class AdoProductDal : IProductDal
    {
        List<Product> _products;
        Product _product;

        public AdoProductDal()
        {
            //_products = new List<Product>
            //{
            //    new Product{ProductId=1,
            //                ProductName="Ado Acer Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram",
            //                UnitPrice=10000,
            //                UnitsInStock=2
            //    },
            //    new Product{ProductId=2,
            //                ProductName="Ado Asus Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram",
            //                UnitPrice=10000,
            //                UnitsInStock=1
            //    },
            //    new Product{ProductId=3,
            //                ProductName="Ado Hp Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram",
            //                UnitPrice=10000,
            //                UnitsInStock=0
            //    },
            //    new Product{ProductId=4,
            //                ProductName="Ado Mac Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram",
            //                UnitPrice=10000,
            //                UnitsInStock=3
            //    },
            //    new Product{ProductId=5,
            //                ProductName="Ado Dell Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram",
            //                UnitPrice=10000,
            //                UnitsInStock=10
            //    },
            //};
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado.net ile ürün eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ado.net ile ürün güncellendi");
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Ado.net ile ürün silindi");
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _product;
        }

        public Task<List<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
