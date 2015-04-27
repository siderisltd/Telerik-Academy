using System;

namespace Shapes
{
    class MainClass
    {
        static void Main()
        {
            Shape[] figures = new Shape[3];
            figures[0] = new Rectangle(3.45, 2.35);
            figures[1] = new Triangle(12.3, 14.2);
            figures[2] = new Square(5);

            foreach (var figure in figures)
            {
                Console.WriteLine(String.Format("Surface of {0} : {1}"
                    ,figure.GetType().Name,figure.CalculateSurface()));
            }
        }
    }
}
