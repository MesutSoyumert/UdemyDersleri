using System;
using System.Collections.Generic;
using System.Text;

namespace Odev12.Entities
{
    public class Car : IEntity
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int ModelYear { get; set; }

        public int DailyPrice { get; set; }

        public string City { get; set; }
    }
}
