//Problem 6. Sum integers
//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int arr = ReadArr(Console.ReadLine);
        Console.WriteLine(arr);
    }

    private static int ReadArr(Func<string> func)
    {
        int[] arr = Console.ReadLine().Split(new char[] { ' ' }, 
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int sum = 0;
        foreach (var num in arr)
        {
            sum += num;
        }
        return sum;
    }
}

