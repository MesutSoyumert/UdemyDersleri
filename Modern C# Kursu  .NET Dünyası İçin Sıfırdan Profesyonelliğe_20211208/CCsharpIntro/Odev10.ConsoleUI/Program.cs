using Odev10.Business;
using Odev10.DataAccess;
using Odev10.Entities;
using System;

namespace Odev10.ConsoleUI
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
