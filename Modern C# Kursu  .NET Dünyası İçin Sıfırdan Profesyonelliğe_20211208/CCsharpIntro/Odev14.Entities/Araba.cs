using System;
using System.Collections.Generic;
using System.Text;

namespace Odev14.Entities
{
    public class Araba : IEntity
    {
        public int Id { get; set; } 

        public string ArabaModeli { get; set; }

        public int GunlukUcret { get; set;}
    }
}