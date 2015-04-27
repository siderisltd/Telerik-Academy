//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and 
//calculates and prints their sum. Note: You may need to use a for-loop.

using System;

class SumOfNumbers
{
    static void Main()
    {
        double result = new double();
        Console.Write("Enter how much numbers you want to sum:");
        double n = double.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter {0} number: ",i);
            double number = double.Parse(Console.ReadLine());
            result += number;
        }
        Console.WriteLine("Result = "+result);

    }
}