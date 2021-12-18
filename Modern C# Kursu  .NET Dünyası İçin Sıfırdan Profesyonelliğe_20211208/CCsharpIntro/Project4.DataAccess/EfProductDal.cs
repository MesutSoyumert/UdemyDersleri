using Microsoft.EntityFrameworkCore;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class EfProductDal : IProductDal
    {
        List<Product> _products;

        public EfProductDal()
        {
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            };
        }

        public async Task<List<Product>> GetAllAsync()
        {
            NorthwindContext context = new NorthwindContext();

            return await context.Products.ToListAsync();
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == id);
            };
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            NorthwindContext context = new NorthwindContext();

            return await context.Products.SingleOrDefaultAsync(p => p.ProductId == id);
        }

        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            };
        }

        public async Task AddAsync(Product product)
        {
            NorthwindContext context = new NorthwindContext();
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
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

        public async Task UpdateAsync(Product product)
        {
            NorthwindContext context = new NorthwindContext();
            var productToUpdate = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;

            await context.SaveChangesAsync();
        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                context.SaveChanges();
            };
        }

        public async Task DeleteAsync(Product product)
        {
            NorthwindContext context = new NorthwindContext();
            {
                context.Products.Remove(context.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                await context.SaveChangesAsync();
            };
        }
    }
}
