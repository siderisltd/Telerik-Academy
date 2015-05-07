using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Exceptions
{
    public class InvalidPlayerChoiceException : ApplicationException
    {
        const string ExceptionMessage = "Plese enter number 1 or 2!";
        public InvalidPlayerChoiceException()
            : base(ExceptionMessage)
        { 
        }
    }
}
