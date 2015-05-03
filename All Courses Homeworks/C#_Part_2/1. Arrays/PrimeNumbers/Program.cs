﻿//Problem 15. Prime numbers
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;

class Program
{
    static void Main()
    {
        long n = 10000000;
        bool[] e = new bool[n];//by default they're all false
        for (int i = 2; i < n; i++)
        {
            e[i] = true;//set all numbers to true
        }
        //weed out the non primes by finding mutiples
        for (int j = 2; j < n; j++)
        {
            if (e[j])//is true
            {
                for (long p = 2; (p * j) < n; p++)
                {
                    e[p * j] = false;
                }
            }
        }
        for (int i = 0; i < e.Length; i++)
        {
            if (e[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}
