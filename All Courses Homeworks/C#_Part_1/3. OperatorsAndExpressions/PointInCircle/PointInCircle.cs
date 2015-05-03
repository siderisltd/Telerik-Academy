//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

namespace PointInCircle
{
    class IsPointInCircle
    {
        static void Main()
        {
            double pointX = 0.2;
            double pointY = -0.8;

            bool isInCircle = (Math.Pow(pointX,2) + (Math.Pow(pointY,2)) < 2 * 2);

            Console.WriteLine(isInCircle);
        }
    }
}