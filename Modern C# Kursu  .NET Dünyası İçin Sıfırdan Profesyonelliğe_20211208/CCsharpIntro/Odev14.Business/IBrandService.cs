using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev14.Business
{
    public interface IBrandService
    {
        List<Brand> GetAll();

        Brand GetById(int id);

        void Add(Brand brand);

        void Update(Brand brand);

        void Delete(Brand brand);
    }
}
