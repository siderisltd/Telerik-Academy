using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double CalculateSurface()
        {
            throw new NotImplementedException("Not Implemented");
        }
    }
}
