//Problem 9. Sorting array
//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] array = { 22, 2, 3, 4, 5, 7, 8, 4, 1, 3, 2, 5,10 };

        Console.Write("Index : ");
        int index = int.Parse(Console.ReadLine()); ;

        int max = MaximalElement(array, index);

        Console.WriteLine("Max" + max);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Accending :");

        int[] reversedArray = ReversedAccending(array);

        foreach (var item in reversedArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Descending :");

        int[] reversedDescendingArray = ReversedDescending(array);

        foreach (var item in reversedDescendingArray)
        {
            Console.Write(item + " ");
        }


    }

    private static int[] ReversedAccending(int[] array)
    {
        int[] reversedArr = new int[array.Length];
        List<int> arrRep = new List<int>();
        int min = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            arrRep.Add(array[i]);
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < arrRep.Count; j++)
            {
                if (min > arrRep[j])
                {
                    min = arrRep[j];
                }
            }
            for (int k = 0; k < arrRep.Count; k++)
            {
                if (min == arrRep[k])
                {
                    arrRep.Remove(arrRep[k]);
                    break;
                }
            }
            reversedArr[i] = min;
            min = int.MaxValue;
        }

        return reversedArr;
    }



    private static int[] ReversedDescending(int[] array)
    {
        int[] reversedArr = new int[array.Length];
        List<int> arrRep = new List<int>();
        int min = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            arrRep.Add(array[i]);
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < arrRep.Count; j++)
            {
                if (min < arrRep[j])
                {
                    min = arrRep[j];
                }
            }
            for (int k = 0; k < arrRep.Count; k++)
            {
                if (min == arrRep[k])
                {
                    arrRep.Remove(arrRep[k]);
                    break;
                }
            }
            reversedArr[i] = min;
            min = int.MinValue;
        }

        return reversedArr;
    }

    private static int MaximalElement(int[] array, int index)
    {
        int maximal = -1;

        for (int i = index; i < array.Length; i++)
        {
            
            if (array[i] > maximal)
            {
                maximal = array[i];
            }
        }
        return maximal;
    }
}

