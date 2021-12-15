using Odev12.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev12.DataAccess
{
    public class EfCarDal : ICarDal
    {
        List<Car> _cars;

        public EfCarDal()
        {
            _cars = new List<Car>()
            {
                new Car
                {
                    Id =1,
                    Brand = "Ef Skoda",
                    Model = "Fabia",
                    ModelYear = 2018,
                    DailyPrice = 250,
                    City = "İzmir"
                },
                new Car
                {
                    Id =2,
                    Brand = "Ef Skoda",
                    Model = "Rapid",
                    ModelYear = 2020,
                    DailyPrice = 350,
                    City = "Ankara"
                },
                new Car
                {
                    Id =3,
                    Brand = "Ef Skoda",
                    Model = "Octavia",
                    ModelYear = 2016,
                    DailyPrice = 500,
                    City = "Ankara"
                },
                new Car
                {
                    Id =4,
                    Brand = "Ef Skoda",
                    Model = "Superb",
                    ModelYear = 2021,
                    DailyPrice = 700,
                    City = "İstanbul"
                },
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars;
        }

        public void Add(Car entity)
        {
            Console.WriteLine("Ef ile Araç eklendi");
        }

        public void Update(Car entity)
        {
            Console.WriteLine("Ef ile Araç güncellendi");
        }

        public void Delete(Car entity)
        {
            Console.WriteLine("Ef ile Araç silindi");
        }
    }
}
