using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    [SerializableAttribute]
    [ComVisibleAttribute(true)]
    public sealed class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string message)
            :base(message)
        {
           
        }
        public InvalidRangeException()
        {
        }

    }
}
