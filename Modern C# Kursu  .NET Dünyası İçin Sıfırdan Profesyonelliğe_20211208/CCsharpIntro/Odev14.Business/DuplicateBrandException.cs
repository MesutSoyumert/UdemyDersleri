using System;
using System.Collections.Generic;
using System.Text;

namespace Odev14.Business
{
    public  class DuplicateBrandException : Exception
    {
        public DuplicateBrandException(string message) : base(message)
        {

        }
    }
}
