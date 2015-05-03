//Problem 10. N Factorial
//Write a program to calculate n! for each n in the range [1..100]


using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        long number = int.Parse(Console.ReadLine());


        Console.WriteLine(CalculateFactorial(number));
    }

    private static BigInteger CalculateFactorial(long number)
    {
        BigInteger factorial = 1;

        for (long i = number; i >= 1; i--)
        {
            factorial *= i;
        }
        return factorial;
    }
}

