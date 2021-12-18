using Microsoft.EntityFrameworkCore;
using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev14.DataAccess
{
    public class EfCarDal : ICarDal
    {

        public List<Car> GetAll()
        {
            using(CarRentalContext context = new CarRentalContext())
            {
                return context.Cars.ToList();
            };
        }

        public async Task<List<Car>> GetAllAsync()
        {
            CarRentalContext context = new CarRentalContext();

            return await context.Cars.ToListAsync();
        }

        public Car GetById(int id)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return (Car)context.Cars.SingleOrDefault(p => p.CarId == id);
            };
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            CarRentalContext context = new CarRentalContext();

            return await context.Cars.SingleOrDefaultAsync(p => p.CarId == id);
        }

        public void Add(Car car)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                context.Cars.Add(car);

                context.SaveChanges();
            } ;
        }

        public async Task AddAsync(Car entity)
        {
            CarRentalContext context = new CarRentalContext();

            await context.Cars.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public void Update(Car car)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var carToUpdate = context.Cars.SingleOrDefault(p => p.CarId == car.CarId);
                carToUpdate.BrandId    = car.BrandId;
                carToUpdate.Model      = car.Model;
                carToUpdate.ModelYear  = car.ModelYear;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.City       = car.City;

                context.SaveChanges();
            };
        }

        public async Task UpdateAsync(Car car)
        {
            CarRentalContext context = new CarRentalContext();

            var carToUpdate = context.Cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Model = car.Model;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.City = car.City;

            await context.SaveChangesAsync();
        }

        public void Delete(Car car)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                context.Cars.Remove(context.Cars.SingleOrDefault(p => p.CarId == car.CarId));

                context.SaveChanges();
            };
        }

        public async Task DeleteAsync(Car car)
        {
            CarRentalContext context = new CarRentalContext();

            context.Cars.Remove(context.Cars.SingleOrDefault(p => p.CarId == car.CarId));

            await context.SaveChangesAsync();
        }
    }
}
