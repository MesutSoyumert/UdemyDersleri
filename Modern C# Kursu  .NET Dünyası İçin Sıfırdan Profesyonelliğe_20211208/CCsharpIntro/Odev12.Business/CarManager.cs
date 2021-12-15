using Odev12.DataAccess;
using Odev12.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev12.Business
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Model == "Octavia")
            {
                throw new DuplicateProductException("Octavia model araç ekleyemezsiniz");
            }
            else
            {
                _carDal.Add(car);
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
