//Problem 9. Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Program
{
    static void Main()
    {
        double sideA = 5;
        double sideB = 7;
        double heigh = 12;

        double areaEquasion = ((sideA + sideB) / 2) * heigh;
        Console.WriteLine(areaEquasion);

        
    }
}
