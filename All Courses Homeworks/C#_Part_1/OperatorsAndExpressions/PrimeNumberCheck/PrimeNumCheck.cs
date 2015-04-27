//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n = 100) is prime
//(i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeNumCheck
{
    static void Main()
    {

        Console.WriteLine(isPrime(3));    
    }
    public static bool isPrime(int number)
    {
        double boundary = Math.Floor(Math.Sqrt(number));

        if (number == 1) return false;
        if (number == 2) return true;

        for (int i = 2; i <= boundary; ++i)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
