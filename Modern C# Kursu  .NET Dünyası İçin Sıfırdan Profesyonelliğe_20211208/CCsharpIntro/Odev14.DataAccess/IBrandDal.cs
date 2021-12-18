using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev14.DataAccess
{
    public interface IBrandDal : IEntityRepository<Brand>, IAsyncRepository<Brand>
    {
    }
}