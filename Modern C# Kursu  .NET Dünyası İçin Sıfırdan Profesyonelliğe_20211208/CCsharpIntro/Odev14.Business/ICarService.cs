using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev14.Business
{
    public interface ICarService
    {
        List<Car> GetAll();

        Car GetById(int id);

        void Add(Car car);

        void Update(Car car);

        void Delete(Car car);
    }
}
