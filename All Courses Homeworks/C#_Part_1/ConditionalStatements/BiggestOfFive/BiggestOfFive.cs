//Problem 6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class BiggestNumber
{
    static void Main()
    {
        double a = -0.1;
        double b = -0.5;
        double c = -1.1;
        double d = 2;
        double e = 4;
        FindBiggest(a, b, c, d ,e);
    }
    public static double FindBiggest(double a, double b, double c, double d, double e)
    {
        int counter = 0;
        double biggest = double.MinValue;
        while (counter <= 5)
        {
            if (a >= biggest)
            {
                biggest = a;
            }
            if (b >= biggest)
            {
                biggest = b;
            }
            if (c >= biggest)
            {
                biggest = c;
            }
            if (d >= biggest)
            {
                biggest = d;
            }
            if (e >= biggest)
            {
                biggest = e;
            }
            
            counter++;
        }
        Console.WriteLine(biggest);
        return biggest;
    }
}