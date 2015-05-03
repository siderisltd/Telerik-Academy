//Problem 6. Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Numerics;

class DividingFactorials
{
    static void Main()
    {
        
        Console.WriteLine("Enter number n in the correct format -- >"+"(1 < k && k < n && n < 100)");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("Enter number n in the same format");
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;

        BigInteger result = 0;

        bool isCorrectFormat = (1 < k && k < n && n < 100);

        while (isCorrectFormat == false)
        {
            Console.WriteLine("Incorrect format! It should be -- >"+"(1 < k && k < n && n < 100)");
            Console.WriteLine("Enter n :");
            n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Enter k :");
            k = BigInteger.Parse(Console.ReadLine());
            isCorrectFormat = (1 < k && k < n && n < 100);
        }

        if (isCorrectFormat)
        {

            while (true)
            {
                if (n != 0)
                {
                    nFactorial *= n;
                    n--;
                }
                if (k != 0)
                {
                    kFactorial *= k;
                    k--;
                }
                if (n == 0 && k == 0)
                {
                    result = nFactorial / kFactorial;
                    Console.Write("Result : {0}", result);
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid format try again!");
        }
    }
}

