using Project4.DataAccess;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Business
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            //iş kuralları buraya yazılır

            if (product.ProductName == "Laptop")
            {
                throw new DuplicateProductException("Laptop ürünü ekleyemezsiniz");
            }
            else
            {
                _productDal.Add(product);
            }
            
        }

        public List<Product> GetAll()
        {

            //iş kuralları buraya yazılır

            return _productDal.GetAll();
        }
    }
}
