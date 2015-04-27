//Problem 18.* Trailing Zeroes in N!
//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.


using System;
using System.Numerics;

namespace TrailingZeroes
{
    class Program
    {
        static void Main()
        {
            int n = 100000;
            int counter = 0;
            BigInteger nFactorial = Factorial(n);
            while (nFactorial % 10 == 0)
            {
                counter++;
                nFactorial /= 10;
            }
            if (n < 10000)
            {
                Console.WriteLine("Factorial : {0}\r\n" + "Trailing Zeroes : {1}", Factorial(n), counter);
            }
            else
            {
                Console.WriteLine("Trailing Zeroes : {0}", counter);
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
}
