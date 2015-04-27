//Problem 1. Exchange If Greater
//Write an if-statement that takes two double variables a and b and exchanges their values if the 
//first one is greater than the second one. As a result print the values a and b, separated by a space.


using System;

class Program
{
    static void Main()
    {
        double a = 5;
        double b = 2;

        if (a > b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        Console.WriteLine("{0} {1}",a,b);
    }
}
