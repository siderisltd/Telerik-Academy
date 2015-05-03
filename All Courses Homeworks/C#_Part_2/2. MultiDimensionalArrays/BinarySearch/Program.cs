//Problem 4. Binary search
//Write a program, that reads from the console an array of N integers 
//and an integer K, sorts the array and using the method Array.BinSearch() finds 
//the largest number in the array which is ≤ K.

using System;
using BinarySearch;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number N (size of array): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a number K: ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter {0} element : ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    

        PrintLargestNumber(array, k);


    }
    static void PrintLargestNumber(int[] numbers, int k)
    {
        Array.Sort(numbers);
        int index = Array.BinarySearch(numbers, k);
        index = index >= 0 ? index : (index == -1 ? -1 : Math.Abs(index + 2));
        if (index != -1)
        {
            Console.WriteLine("\nFound smaller or equal number to K = {0}", k);
            Console.WriteLine("-> Result number: {0}\n", numbers[index]);
        }
        else
        {
            Console.WriteLine("\n- There is no smaller or equal to K = {0} number in array!\n", k);
        }
    }

}

