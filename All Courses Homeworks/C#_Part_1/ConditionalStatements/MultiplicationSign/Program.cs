//Problem 4. Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.


using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 6;
        int c = 2;
        if (a + b + c == 0)
        {
            Console.WriteLine("0");
        }
        if (a + b + c > 0)
        {
            Console.WriteLine("+");
        }
        if (a + b + c > 0)
        {
            Console.WriteLine("+");
        }
    }
}

