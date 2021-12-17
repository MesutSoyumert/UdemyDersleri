using Odev14.DataAccess;
using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev14.Business
{
    public class ArabaManager : IArabaService
    {
        IArabaDal _arabaDal;

        public ArabaManager(IArabaDal arabaDal)
        {
            _arabaDal = arabaDal;
        }

        public List<Araba> GetAll()
        {
            return _arabaDal.GetAll();
        }
    }
}
