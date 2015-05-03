using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int number = 101;
            if (number >= 0 && number <= 100)
            {
                throw new InvalidRangeException<int>("Invalid range");
            }

            DateTime Date = new DateTime(1980, 1, 1);
            DateTime firstBareer = new DateTime(1980,1,1);
            DateTime secondBareer = new DateTime(2013,12,31);

            if (Date <= firstBareer || Date >= secondBareer )
            {
                throw new InvalidRangeException<DateTime>("Invalid range");
            }
        }
    }
}
