//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.



using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] inputAsNumber = new int[arr.Length];
        //string[] letters = new string[input.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            inputAsNumber[i] = int.Parse(arr[i]);
        }
        int firstChar = inputAsNumber[inputAsNumber.Length-1];
        int maximalSequence = 1;
        int maxChar = new int();
        int max = 0;
        for (int i = 0; i < inputAsNumber.Length; i++)
        {
            if (firstChar + 1 == inputAsNumber[i])
            {
                maximalSequence++;
                firstChar = inputAsNumber[i];
                if (maximalSequence > max)
                {
                    max = maximalSequence;
                    maxChar = inputAsNumber[i];
                }
            }
            else
            {
                firstChar = inputAsNumber[i];
                maximalSequence = 1;
            }
        }
        int digit = max;
        for (int i = 1; i < max; i++)
        {
            maxChar--;
        }
        for (int i = 0; i < max; i++)
        {
            Console.Write(maxChar++ + ",");
        }
    }
}

