using Odev14.DataAccess;
using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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

        public Brand GetById(int id)
        {
            return _brandDal.GetById(id);
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

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }
    }
}
