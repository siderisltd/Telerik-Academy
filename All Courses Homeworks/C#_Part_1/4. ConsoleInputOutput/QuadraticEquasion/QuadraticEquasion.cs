//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation 
//ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquasion
{
    static void Main()
    {
        double a = int.Parse(Console.ReadLine());
        double b = int.Parse(Console.ReadLine());
        double c = int.Parse(Console.ReadLine());

        double discriminant = Math.Pow(b, 2) - (4 * a * c);
        if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
            Environment.Exit(0);
        }
        if (discriminant == 0)
        {
            Console.WriteLine("Only one root exist");
        }

        double firstRoot = ((-b - Math.Sqrt(discriminant)) / (2 * a));
        double secondRoot = ((-b + Math.Sqrt(discriminant)) / (2 * a));

        Console.Write("X1=" + firstRoot);
        Console.WriteLine("X2=" + secondRoot);
    }
}
