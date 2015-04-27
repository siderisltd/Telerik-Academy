//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area 
//formatted with 2 digits after the decimal point.

using System;

class PerimeterArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r, 2);

        Console.WriteLine("Perimeter: {0:F2}", perimeter);
        Console.WriteLine("Area: {0:F2}", area);
    }
}
