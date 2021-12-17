using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public Car GetById(int id)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return (Car)context.Cars.SingleOrDefault(p => p.CarId == id);
            };
        }

        public void Add(Car car)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                context.Cars.Add(car);

                context.SaveChanges();
            } ;
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
        public void Delete(Car car)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                context.Cars.Remove(context.Cars.SingleOrDefault(p => p.CarId == car.CarId));

                context.SaveChanges();
            };
        }
    }
}
