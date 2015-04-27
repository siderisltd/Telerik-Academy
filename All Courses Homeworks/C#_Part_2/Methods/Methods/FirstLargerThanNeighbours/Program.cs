//Problem 6. First larger than neighbours
//Write a method that returns the index of the first element in array that is larger 
//than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;


class Program
{
    static void Main()
    {
        int[] array = {1,2,3,4,5};
        Console.WriteLine(CheckArrAtPosition(array));
    }
    private static int CheckArrAtPosition(int[] array)
    {
        int pos = -1;
        // With this piece of code we check if there is no such a position it will cause IndexOutOfRangeException
        // if this exception is thrown it will return -1 also
        try
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    pos = i;
                    return pos;
                }
            }
        }
        catch (IndexOutOfRangeException)
        {
            return pos;

        }
        return pos;
    }
}