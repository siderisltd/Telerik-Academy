//Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.
//Example:
//input 	                                result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1          	2, 2, 2


using System;

class Program
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries);
        string input = "";
        //string[] letters = new string[input.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            input += arr[i];
        }
        char firstChar = input[0];
        int maximalSequence = 1;
        char maxChar = new char();
        int max = 0;
        for (int i = 1; i < input.Length; i++)
        {
            if (firstChar == input[i])
            {
                maximalSequence++;
                firstChar = input[i];
                if (maximalSequence > max)
                {
                    max = maximalSequence;
                    maxChar = input[i];
                }
            }
            else
            {
                firstChar = input[i];
                maximalSequence = 1;
            }
        }
        for (int i = 0; i < max; i++)
        {
            Console.Write(maxChar + ",");
        }
    }
}

