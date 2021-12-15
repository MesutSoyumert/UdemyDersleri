using Odev12.Business;
using Odev12.DataAccess;
using Odev12.Entities;
using System;

namespace Odev12.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Model);
            }

            try
            {
                carManager.Add(new Car
                    {
                        Id=1,
                        Brand = "Volswagen",
                        Model = "Octavia",
                        ModelYear = 2020,
                        City = "Ankara"
                    }
                );
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
