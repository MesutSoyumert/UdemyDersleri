using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev14.DataAccess
{
    public class EfBrandDal : IBrandDal
    {

        public EfBrandDal()
        {

        }

        public List<Brand> GetAll()
        {
            using(CarRentalContext context = new CarRentalContext())
            {
                return context.Brands.ToList();
            };
        }

        public Brand GetById(int id)
        {
            using(CarRentalContext context = new CarRentalContext())
            {
                return context.Brands.SingleOrDefault(p => p.BrandId == id);
            };
        }
        public void Add(Brand brand)
        {
            using(CarRentalContext context = new CarRentalContext())
            {
                context.Brands.Add(brand);

                context.SaveChanges();
            };
        }

        public void Update(Brand brand)
        {
            using(CarRentalContext context = new CarRentalContext())
            {
                var brandToUpdate = context.Brands.SingleOrDefault(p => p.BrandId == brand.BrandId);
                brandToUpdate.BrandName = brand.BrandName;

                context.SaveChanges();
            };
        }

        public void Delete(Brand brand)
        {
            using(CarRentalContext context = new CarRentalContext())
            {
                context.Brands.Remove(context.Brands.SingleOrDefault(p => p.BrandId == brand.BrandId));

                context.SaveChanges();
            };
        }
    }
}
