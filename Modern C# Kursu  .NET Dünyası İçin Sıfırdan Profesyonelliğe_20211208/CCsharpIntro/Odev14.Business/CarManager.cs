using Odev14.DataAccess;
using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev14.Business
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public void Add(Car car)
        {
            if (car.Model == "Octavia")
            {
                throw new DuplicateCarException("Octavia model araç ekleyemezsiniz");
            }
            else
            {
                _carDal.Add(car);
            };
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
    }
}
