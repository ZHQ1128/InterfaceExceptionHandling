using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExceptionHandling.CustomExceptions
{
    class TooManyEggsException :Exception
    {
        public TooManyEggsException(string message) : base (message) { }
    }
}
