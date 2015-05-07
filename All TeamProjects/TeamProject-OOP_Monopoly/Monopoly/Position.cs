using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public struct Position
    {        
        public Position(int x, int y)    
            : this()
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; private set; }
        public int Y { get; private set; }
    }
}
