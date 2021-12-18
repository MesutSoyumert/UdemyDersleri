using Odev14.DataAccess;
using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public Task<List<Car>> GatAllAsync()
        {
            return _carDal.GetAllAsync();
        }

        public Car GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public Task<Car> GetByIdAsync(int id)
        {
            return _carDal.GetByIdAsync(id);
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

        public Task AddAsync(Car car)
        {
            if (car.Model == "Octavia")
            {
                throw new DuplicateCarException("Octavia model araç ekleyemezsiniz");
            }
            else
            {
                return _carDal.AddAsync(car);
            };
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public Task UpdateAsync(Car car)
        {
            return _carDal.UpdateAsync(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Task DeleteAsync(Car car)
        {
            return _carDal.DeleteAsync(car);
        }
    }
}
