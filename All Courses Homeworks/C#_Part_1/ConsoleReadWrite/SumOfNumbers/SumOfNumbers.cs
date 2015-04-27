//Problem 1. Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumOfNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int sum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine("{0} + {1} + {2} = {3}",firstNumber,secondNumber,thirdNumber,sum);
    }
}
