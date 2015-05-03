//Problem 8. Maximal sum
//Write a program that finds the sequence of maximal sum in given array.
//Example:
//input 	                                       result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	              2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] nums = new int[arr.Length];
        //string[] letters = new string[input.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            nums[i] = int.Parse(arr[i]);
        }
        int sum = 0;
        int bestSum = 0;
        int startIndex = new int();
        int endIndex = new int();
        // One scan
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                sum += nums[j];
                if (sum > bestSum)
                {
                    startIndex = i;
                    endIndex = j;
                    bestSum = sum;
                }
            }
            sum = 0;
        }
        // Printing 
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
        Console.Write("SUM: " + bestSum);
        Console.ReadLine();
    }
}
