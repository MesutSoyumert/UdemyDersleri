using System;
using System.Collections.Generic;
using System.Text;

namespace Odev12.Business
{
    public class DuplicateProductException : Exception
    {
        public DuplicateProductException(string message) : base(message)
        {

        }
    }
}
