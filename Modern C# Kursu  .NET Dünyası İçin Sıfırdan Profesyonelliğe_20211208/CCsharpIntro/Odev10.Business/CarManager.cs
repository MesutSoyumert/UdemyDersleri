using Odev10.DataAccess;
using Odev10.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev10.Business
{
    public class CarManager
    {
        ICarDal _cardal;

        public CarManager(ICarDal carDal)
        {
            _cardal = carDal;
        }

        public List<Car> GetAll()
        {
            //iş kuralları buraya yazılır
            return _cardal.GetAll();
        }
    }
}