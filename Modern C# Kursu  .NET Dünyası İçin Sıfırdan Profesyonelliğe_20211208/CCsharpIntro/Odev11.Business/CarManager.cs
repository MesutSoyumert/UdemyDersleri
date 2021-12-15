using Odev11.DataAccess;
using Odev11.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev11.Business
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
            return _cardal.GetAll();
        }
    }
}
