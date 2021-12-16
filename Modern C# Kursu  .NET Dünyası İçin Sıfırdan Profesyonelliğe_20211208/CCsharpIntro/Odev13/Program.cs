using System;
using System.Collections.Generic;
using System.Linq;

namespace Odev13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Brand> brands;
            List<Car> cars;

            brands = new List<Brand> {
                new Brand
                {
                    BrandId = 1,
                    BrandName = "Skoda"
                },
                new Brand
                {
                    BrandId = 2,
                    BrandName = "Volswagen"
                }
                };

            cars = new List<Car>()
            {
                new Car
                {
                    CarId =1,
                    BrandId = 1,
                    Model = "Fabia",
                    ModelYear = 2018,
                    DailyPrice = 250,
                    City = "İzmir"
                },
                new Car
                {
                    CarId =2,
                    BrandId = 1,
                    Model = "Octavia",
                    ModelYear = 2020,
                    DailyPrice = 750,
                    City = "Ankara"
                },
                new Car
                {
                    CarId =3,
                    BrandId = 1,
                    Model = "Superb",
                    ModelYear = 2016,
                    DailyPrice = 850,
                    City = "Ankara"
                },
                new Car
                {
                    CarId =4,
                    BrandId = 2,
                    Model = "Jetta",
                    ModelYear = 2021,
                    DailyPrice = 800,
                    City = "İstanbul"
                },
                new Car
                {
                    CarId =5,
                    BrandId = 2,
                    Model = "Passat",
                    ModelYear = 2021,
                    DailyPrice = 900,
                    City = "Ankara"
                }

            };

            // IEnumerable<CarDto> result = TestJoin(brands, cars);

            // TestDto(cars);

            // FindTest(cars);

            // FindAllTest(cars);
        }

        private static IEnumerable<CarDto> TestJoin(List<Brand> brands, List<Car> cars)
        {
            // Join örneği
            var result = from c in cars
                         join b in brands
                         on c.BrandId equals b.BrandId
                         where c.DailyPrice > 500
                         orderby c.DailyPrice descending
                         select new CarDto
                         {
                             CarId = c.CarId,
                             BrandName = b.BrandName,
                             Model = c.Model,
                             ModelYear = c.ModelYear,
                             DailyPrice = c.DailyPrice,
                             City = c.City
                         };

            Console.WriteLine("Join örneği");

            foreach (var carDto in result)
            {
                Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}",
                                    carDto.CarId, carDto.BrandName, carDto.Model, carDto.ModelYear, carDto.DailyPrice, carDto.City);
            }

            return result;
        }
        private static void FindAllTest(List<Car> cars)
        {
            var result = cars.FindAll(c => c.Model == "Octavia");

            foreach (var car in result)
            {
                Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}",
                                   car.CarId, car.BrandId, car.Model, car.ModelYear, car.DailyPrice, car.City);
            }
        }

        private static void FindTest(List<Car> cars)
        {
            var result = cars.Find(c => c.CarId == 3);
            Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}",
                               result.CarId, result.BrandId, result.Model, result.ModelYear, result.DailyPrice, result.City);
        }

        private static void TestDto(List<Car> cars)
        {
            // Tek tablodan Dto örneği

            var result = from car in cars
                         where car.CarId == 5
                         select new CarDto
                         {
                             CarId = car.CarId,
                             BrandId = car.BrandId,
                             Model = car.Model,
                             ModelYear = car.ModelYear,
                             DailyPrice = car.DailyPrice,
                             City = car.City
                         };

            Console.WriteLine("Tek tablodan Dto örneği");

            foreach (var carDto in result)
            {
                Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}",
                                carDto.CarId, carDto.BrandName, carDto.Model, carDto.ModelYear, carDto.DailyPrice, carDto.City);
            }
        }
    }

    class Brand
    {
        public int BrandId { get; set; }

        public string BrandName { get; set; }
    }

    class Car
    {
        public int CarId { get; set; }

        public int BrandId { get; set; }

        public string Model { get; set; }

        public int ModelYear { get; set; }

        public int DailyPrice { get; set; }

        public string City { get; set; }

    }

    class CarDto
    {
        public int CarId { get; set; }

        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public string Model { get; set; }

        public int ModelYear { get; set; }

        public int DailyPrice { get; set; }

        public string City { get; set; }
    }
}
