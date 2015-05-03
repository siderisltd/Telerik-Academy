//Problem 7. Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose k different members out of a group of 
//n different elements (also known as the number of combinations) is calculated by the 
//following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops.


using System;
using System.Numerics;

class DividingFactorials
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger nMinusK = n - k;

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nMinusKFactorial = 1;

        BigInteger result = 0;

        bool isCorrectFormat = (1 < k && k < n && n < 100);

        while (isCorrectFormat == false)
        {
            Console.WriteLine("Incorrect format! It should be -- >" + "(1 < k && k < n && n < 100)");
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
                if (nMinusK != 0)
                {
                    nMinusKFactorial *= nMinusK;
                    nMinusK--;
                }
                if (n == 0 && k == 0 && nMinusK == 0)
                {
                    result = nFactorial / (kFactorial * nMinusKFactorial);
                    break;
                }
            }
        }
        Console.WriteLine(result);
    }
}
