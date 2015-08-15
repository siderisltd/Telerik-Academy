//Problem 11. Random Numbers in Given Range
//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        List<int> dynamicArray = new List<int>();
      
        if (min != max)
        {
            for (int i = 0; i < n; i++)
            {
 
                Random randomnumber = new Random(i * 4);
                dynamicArray.Add(randomnumber.Next(min, max));
            }
            foreach (var number in dynamicArray)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("min == max ! try again with a correct imput");
        }
    }
}

