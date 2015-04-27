//Problem 9. Frequent number
//Write a program that finds the most frequent number in an array.
//Example:
//input 	                                        result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	       4 (5 times)


using System;

class Program
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int counter = 0;
        string currentChar = "";
        int max = 0;
        string character = "";
        for (int i = 0; i < arr.Length; i++)
        {
            currentChar = arr[i];
            for (int j = 0; j < arr.Length; j++)
            {
                if (currentChar == arr[j])
                {
                    counter++;
                }
            }
            if (max < counter)
            {
                max = counter;
                character = arr[i];
            }
            counter = 0;
        }
        Console.WriteLine("{0} - ({1}) Times", character, max);
        Console.ReadLine();
    }
}

