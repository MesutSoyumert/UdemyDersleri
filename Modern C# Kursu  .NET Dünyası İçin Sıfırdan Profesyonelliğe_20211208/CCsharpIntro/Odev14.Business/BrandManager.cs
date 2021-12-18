using Odev14.DataAccess;
using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Odev14.Business
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Task<List<Brand>> GetAllAsync()
        {
            return _brandDal.GetAllAsync();
        }

        public Brand GetById(int id)
        {
            return _brandDal.GetById(id);
        }

        public Task<Brand> GetByIdAsync(int id)
        {
            return _brandDal.GetByIdAsync(id);
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName == "Skoda")
            {
                throw new DuplicateBrandException("Skoda markasını ekleyemezsiniz");
            }
            else
            {
                _brandDal.Add(brand);
            };
        }

        public Task AddAsync(Brand brand)
        {
            if (brand.BrandName == "Skoda")
            {
                throw new DuplicateBrandException("Skoda markasını ekleyemezsiniz");
            }
            else
            {
                 return _brandDal.AddAsync(brand);
            };
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }

        public Task UpdateAsync(Brand brand)
        {
            return _brandDal.UpdateAsync(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public Task DeleteAsync(Brand brand)
        {
            return _brandDal.DeleteAsync(brand);
        }
    }
}
