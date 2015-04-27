//Problem 3. Min, Max, Sum and Average of N Numbers
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.


using System;
using System.Collections.Generic;

class MinMaxSumAverage
{
    static void Main()
    {
        Console.Write("How much numbers you will compare : ");
        int numbersCount = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        int min = int.MaxValue;
        int max = 0;
        double sum = 0.0;
        double average = 0.0;
        for (int i = 1; i <= numbersCount; i++)
        {
            Console.Write("Enter {0} number : ",i);
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
            if (max < numbers[i])
            {
                max = numbers[i];
            }
            sum += numbers[i];
        }
        average = (double)(sum / numbers.Count);
        Console.WriteLine("Min :" + min);
        Console.WriteLine("Max :" + max);
        Console.WriteLine("Sum :" + sum);
        Console.WriteLine("Average :{0:F2}", average);
    }
}

