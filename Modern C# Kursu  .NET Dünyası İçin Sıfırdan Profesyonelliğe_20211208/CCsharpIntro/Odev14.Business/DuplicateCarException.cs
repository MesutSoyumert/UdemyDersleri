using System;
using System.Collections.Generic;
using System.Text;

namespace Odev14.Business
{
    public class DuplicateCarException : Exception
    {
        public DuplicateCarException(string message) : base(message)
        {

        }
    }
}
