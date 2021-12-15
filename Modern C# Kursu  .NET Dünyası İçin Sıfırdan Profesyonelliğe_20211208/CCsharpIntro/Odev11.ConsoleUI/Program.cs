using Odev11.Business;
using Odev11.DataAccess;
using System;

namespace Odev11.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Brand);
            }
        }
    }
}
