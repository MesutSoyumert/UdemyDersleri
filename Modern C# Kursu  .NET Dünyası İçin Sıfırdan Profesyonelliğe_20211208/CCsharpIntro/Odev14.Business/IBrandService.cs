using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Odev14.Business
{
    public interface IBrandService
    {
        List<Brand> GetAll();

        Brand GetById(int id);

        void Add(Brand brand);

        void Update(Brand brand);

        void Delete(Brand brand);

        Task<List<Brand>> GetAllAsync();

        Task<Brand> GetByIdAsync(int id);

        Task AddAsync(Brand brand);

        Task UpdateAsync(Brand brand);

        Task DeleteAsync(Brand brand);
    }
}
