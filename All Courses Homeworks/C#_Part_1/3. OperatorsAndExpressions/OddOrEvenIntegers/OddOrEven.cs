//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.


using System;

class OddOrEven
{
    static void Main()
    {
        int numberToCheck = int.Parse(Console.ReadLine());
        if (numberToCheck % 2 == 1)
        {
            Console.WriteLine("Odd");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
