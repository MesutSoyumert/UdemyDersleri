﻿using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev14.DataAccess
{
    public interface ICarDal : IEntityRepository<Car>, IAsyncRepository<Car>
    {
    }
}