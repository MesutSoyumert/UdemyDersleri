using Odev12.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev12.Business
{
    public interface ICarService
    {
        List<Car> GetAll();

        void Add(Car car);
    }
}
