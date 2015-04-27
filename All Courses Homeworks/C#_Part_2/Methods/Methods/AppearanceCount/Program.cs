//Problem 4. Appearance count
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Array Length : ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter {0} element : ",i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter number that we are searching for : ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(Counts(array,number));

        // TODO : UNIT TESTING

    }
    static int Counts(int[] arr, int number)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                count++;
            }
        }
        return count;
    }
}
