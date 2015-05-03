//Problem 6. Maximal K sum
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.


using System;

class Program
{
    static void Main()
    {
        Console.Write("How bigger you want the array to be? ... :");
        int n = int.Parse(Console.ReadLine());
        Console.Write("How much numbers we will search for their sum? ... :");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter arr [{0}] element : ",i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += arr[n - i - 1];
        }
        Console.WriteLine("Maximal sum of {0} elements is = "+sum,k);
    }
}

