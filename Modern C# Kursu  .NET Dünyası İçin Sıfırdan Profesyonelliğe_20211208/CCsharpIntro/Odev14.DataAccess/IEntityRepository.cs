using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev14.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();

        T GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
