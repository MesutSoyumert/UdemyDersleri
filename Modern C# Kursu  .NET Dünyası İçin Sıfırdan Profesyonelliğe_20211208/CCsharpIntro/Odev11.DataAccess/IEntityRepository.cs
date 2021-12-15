using Odev11.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev11.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();

        List<T> GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(int id);
    }
}
