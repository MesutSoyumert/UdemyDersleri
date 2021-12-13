using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev9
{
    internal class CarManager
    {
        List<Car> cars;

        public CarManager()
        {
            cars = new List<Car>()
            {
                new Car
                {
                    Id =1,
                    Brand = "Skoda",
                    Model = "Fabia",
                    ModelYear = 2018,
                    DailyPrice = 250,
                    City = "İzmir"
                },
                new Car
                {
                    Id =2,
                    Brand = "Skoda",
                    Model = "Rapid",
                    ModelYear = 2020,
                    DailyPrice = 350,
                    City = "Ankara"
                },
                new Car
                {
                    Id =3,
                    Brand = "Skoda",
                    Model = "Octavia",
                    ModelYear = 2016,
                    DailyPrice = 500,
                    City = "Ankara"
                },
                new Car
                {
                    Id =4,
                    Brand = "Skoda",
                    Model = "Superb",
                    ModelYear = 2021,
                    DailyPrice = 700,
                    City = "İstanbul"
                },
            };
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }
    }
}
