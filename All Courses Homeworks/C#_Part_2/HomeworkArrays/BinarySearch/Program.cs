//Problem 11. Binary search
//Write a program that finds the index of given element in a sorted 
//array of integers by using the Binary search algorithm.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Arr :");
        string[] arr = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arrToInteger = new int[arr.Length];
        for (int i = 0; i < arrToInteger.Length; i++)
        {
            arrToInteger[i] = int.Parse(arr[i]);
        }
        Console.Write("Enter item that we search for position :");
        int searchedItem = int.Parse(Console.ReadLine());
        int length = arrToInteger.Length / 2;
        Array.Sort(arrToInteger);
        while (true)
        {
            if (searchedItem == arrToInteger[length])
            {
                Console.WriteLine(length);
                break;
            }
            else if (searchedItem > arrToInteger[length])
            {
                length = (arrToInteger.Length + length) / 2;
            }
            else if (searchedItem < arrToInteger[length])
            {
                length = arrToInteger.Length  / 2 - length ;
            }
            else if (length < 0 && length > arrToInteger.Length)
            {
                Console.WriteLine("Nothing found");
                break;
            }
        }
    }
}
