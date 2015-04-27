//Problem 8. Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).


using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("How much factorials to print : ");
        int n = int.Parse(Console.ReadLine());
        BigInteger catalanNumber = 1;
        bool correctFormat = 0 <= n && n <= 100;
        List<BigInteger> CatalanNumbers = new List<BigInteger>();

        BigInteger nFactorial = Factorial(n);
        BigInteger nFactorialPlusOne = Factorial(n+1);
        BigInteger twonFactorial = Factorial(n * 2);

        for (int i = 0; i <= n; i++)
        {
            catalanNumber = Factorial(2*i) / (Factorial(i + 1) * Factorial(i));
            CatalanNumbers.Add(catalanNumber);
        }
        foreach (var item in CatalanNumbers)
        {
            Console.WriteLine(item);
        }
    }
    public static BigInteger Factorial(int n)
    {
        BigInteger nFactorial = 1;
        for (int i = n; i > 0; i--)
        {
            nFactorial *= i;
        }
        return nFactorial;
    }
}

