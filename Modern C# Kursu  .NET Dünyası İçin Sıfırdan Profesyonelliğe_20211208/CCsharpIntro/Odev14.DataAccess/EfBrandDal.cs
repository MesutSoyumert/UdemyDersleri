using Microsoft.EntityFrameworkCore;
using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev14.DataAccess
{
    public class EfBrandDal : IBrandDal
    {

        public EfBrandDal()
        {

        }

        public List<Brand> GetAll()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Brands.ToList();
            };
        }

        public async Task<List<Brand>> GetAllAsync()
        {
            CarRentalContext context = new CarRentalContext();

            return await context.Brands.ToListAsync();
        }

        public Brand GetById(int id)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Brands.SingleOrDefault(p => p.BrandId == id);
            };
        }

        public async Task<Brand> GetByIdAsync(int id)
        {
            CarRentalContext context = new CarRentalContext();
            return await context.Brands.SingleOrDefaultAsync(p => p.BrandId == id);
        }

        public void Add(Brand brand)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                context.Brands.Add(brand);

                context.SaveChanges();
            };
        }

        public async Task AddAsync(Brand brand)
        {
            CarRentalContext context = new CarRentalContext();

            await context.Brands.AddAsync(brand);

            await context.SaveChangesAsync();

        }

        public void Update(Brand brand)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var brandToUpdate = context.Brands.SingleOrDefault(p => p.BrandId == brand.BrandId);
                brandToUpdate.BrandName = brand.BrandName;

                context.SaveChanges();
            };
        }

        public async Task UpdateAsync(Brand brand)
        {
            CarRentalContext context = new CarRentalContext();

            var brandToUpdate = context.Brands.SingleOrDefault(p => p.BrandId == brand.BrandId);
            brandToUpdate.BrandName = brand.BrandName;

            await context.SaveChangesAsync();
        }

        public void Delete(Brand brand)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                context.Brands.Remove(context.Brands.SingleOrDefault(p => p.BrandId == brand.BrandId));

                context.SaveChanges();
            };
        }
        public async Task DeleteAsync(Brand brand)
        {
            CarRentalContext context = new CarRentalContext();

            context.Brands.Remove(context.Brands.SingleOrDefault(p => p.BrandId == brand.BrandId));

            await context.SaveChangesAsync();
        }
    }
}
