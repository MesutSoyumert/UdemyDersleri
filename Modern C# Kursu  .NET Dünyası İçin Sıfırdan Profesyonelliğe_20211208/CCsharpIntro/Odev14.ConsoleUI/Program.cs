using Odev14.Business;
using Odev14.DataAccess;
using Odev14.Entities;
using System;

namespace Odev14.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //Console.WriteLine(brandManager.GetById(1).BrandName);

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine("{0} / {1}",
            //        brand.BrandId, brand.BrandName);
            //}

            //brandManager.Add(new Entities.Brand { BrandName = "Fiat" });
            Brand brand = new Brand();
            brand.BrandId = 1002;
            //brand.BrandName = "Güncellenen Brand 2";

            //brandManager.Update(brand);

            //brandManager.Delete(brand);

            //foreach (var brand1 in brandManager.GetAll())
            //{
            //    Console.WriteLine("{0} / {1}",
            //        brand1.BrandId, brand1.BrandName);
            //}

            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetById(1).Model);

            Car car = new Car();
            car.CarId = 1;
            car.BrandId = 1;
            car.Model = "Fabia";
            car.ModelYear = 2021;
            car.City = "Ankara";

            carManager.Update(car);

            foreach (var car1 in carManager.GetAll())
            {
                Console.WriteLine("{0} / {1} / {2} / {3} / {4}",
                    car1.CarId, car1.BrandId, car1.Model, car1.ModelYear, car1.City); 
            }

            ArabaManager arabaManager = new ArabaManager(new EfArabaDal());

            //foreach (var araba in arabaManager.GetAll())
            //{
            //    Console.WriteLine("{0} / {1} / {2}",
            //        araba.Id, araba.ArabaModeli, araba.GunlukUcret);
            //}
        }
    }
}
