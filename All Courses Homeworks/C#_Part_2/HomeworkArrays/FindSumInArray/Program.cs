//Problem 10. Find sum in array
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:
//array 	                 S 	                 result
//4, 3, 1, 4, 2, 5, 8 	     11 	                4, 2, 5

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter Arr :");
        string[] arr = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arrToInteger = new int[arr.Length];
        Console.Write("What sum are we looking for :");
        int s = int.Parse(Console.ReadLine());
        int sum = 0;
        List<int> variableSaving = new List<int>();


        for (int i = 0; i < arrToInteger.Length; i++)
        {
            arrToInteger[i] = int.Parse(arr[i]);
        }
        for (int i = 0; i < arrToInteger.Length; i++)
        {
            for (int j = i; j < arrToInteger.Length; j++)
            {
                sum += arrToInteger[j];
                variableSaving.Add(arrToInteger[j]);
                if (sum == s)
                {
                    foreach (var digit in variableSaving)
                    {
                        Console.Write("| {0} |",digit);
                    }
                }
                if (sum>s)
                {
                    variableSaving.Clear();
                    sum = 0;
                    break;
                }
            }
        }
    }
}

