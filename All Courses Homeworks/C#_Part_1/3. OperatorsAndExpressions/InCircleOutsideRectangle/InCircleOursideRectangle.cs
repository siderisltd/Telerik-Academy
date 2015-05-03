//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle 
//K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;


class InCircleOursideRectangle
{
    
    static void Main()
    {
        double pointX = 2;
        double pointY = 1.5;

        double rectangleTop = 1;
        double rectangleLeft = -1;
        double rectangleWidth = 6;
        double rectangleHeight = 2;

        bool isInCircle = (Math.Pow(pointX - 1, 2) + (Math.Pow(pointY - 1, 2)) <= 1.5 * 1.5);
        bool isInRectangle = (pointX <= 3 && pointX >= -3) && (pointY >= -3 && pointY <= 3);

        if (isInCircle && isInRectangle)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

    }
}
