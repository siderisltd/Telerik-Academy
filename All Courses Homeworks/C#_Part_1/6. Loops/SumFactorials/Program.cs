using System;
using System.Numerics;

class SumCalculation
{
    private static BigInteger FindFactorial(int N)
    {
        BigInteger factorial = 1;
        for (int i = 1; i < N + 1; i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }

    private static BigInteger FindPower(int X, int N)
    {
        BigInteger powerX = 1;
        for (int i = 1; i < N + 1; i++)
        {
            powerX = powerX * X;
        }
        return powerX;
    }

    static void Main()
    {
        int N, X;
        double sum = 1.0;
        Console.Write("Enter the first number N:");
        bool isNInt = int.TryParse(Console.ReadLine(), out N);
        Console.Write("Enter the second number X:");
        bool isXInt = int.TryParse(Console.ReadLine(), out X);
        if (isNInt && isXInt)
        {
            for (int i = 1; i < N + 1; i++)
            {
                sum = sum + ((double)FindFactorial(i) / (double)FindPower(X, i));

            }
            Console.WriteLine("sum = {0}", sum);
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }
    }
}