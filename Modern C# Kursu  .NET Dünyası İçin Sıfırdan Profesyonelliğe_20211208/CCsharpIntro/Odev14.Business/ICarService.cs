using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Odev14.Business
{
    public interface ICarService
    {
        List<Car> GetAll();

        Car GetById(int id);

        void Add(Car car);

        void Update(Car car);

        void Delete(Car car);

        Task<List<Car>> GatAllAsync();

        Task<Car> GetByIdAsync(int id);

        Task AddAsync(Car car);

        Task UpdateAsync(Car car);

        Task DeleteAsync(Car car);
    }
}
