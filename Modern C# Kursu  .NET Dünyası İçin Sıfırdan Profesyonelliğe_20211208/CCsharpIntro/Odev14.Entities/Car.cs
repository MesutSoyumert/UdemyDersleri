using System;
using System.Collections.Generic;
using System.Text;

namespace Odev14.Entities
{
    public class Car : IEntity
    {
        public int CarId { get; set; }

        public int BrandId { get; set; }

        public string Model { get; set; }

        public int ModelYear { get; set; }

        public int DailyPrice { get; set; }

        public string City { get; set; }
    }
}
