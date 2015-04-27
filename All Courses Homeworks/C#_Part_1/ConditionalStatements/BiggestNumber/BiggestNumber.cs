//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.


using System;

class BiggestNumber
{
    static void Main()
    {
        double a = -0.1;
        double b = -0.5;
        double c = -1.1;
        FindBiggest(a, b, c);
    }
    public static double FindBiggest(double a, double b, double c)
    {
        int counter = 0;
        double biggest = double.MinValue;
        while (counter <= 3)
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
            counter++;
        }
        Console.WriteLine(biggest);
        return biggest;
    }
}
