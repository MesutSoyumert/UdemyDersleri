using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev14.DataAccess
{
    public class EfArabaDal : IArabaDal
    {

        public List<Araba> GetAll()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Arabas.ToList();
            };
        }

        public Araba GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Araba entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Araba entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Araba entity)
        {
            throw new NotImplementedException();
        }
    }
}
