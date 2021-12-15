using Odev10.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev10.DataAccess
{
    public interface ICarDal
    {
        List<Car> GetAll();

        void Add(Car car);
    }
}
