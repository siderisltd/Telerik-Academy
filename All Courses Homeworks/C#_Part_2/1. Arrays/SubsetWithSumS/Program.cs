//Problem 16.* Subset with sum S
//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
//Example:
//input array 	               S 	             result
//2, 1, 2, 4, 3, 5, 2, 6        14 	               yes

using System;

class Program
{
    static int counter = 0;
    static int s = int.Parse(Console.ReadLine());
    static bool isEqual = false;
    static int[] vector = new int[]
           {
                1,2,3,3,3,3,3,9,10,23,41,23,43,1
           };
    static int[] arrangedArr = new int[vector.Length];
   
    static void Main()
    {
        Array.Copy(vector, arrangedArr, vector.Length);
        int size = vector.Length;
        Gen01(size - 1, vector);
        Console.WriteLine("No");
        
    }
    static void Gen01(int index, int[] vector)
    {

        if (index == -1)
        {
            int[] copyArrangedArr = new int[vector.Length];
            Array.Copy(arrangedArr, copyArrangedArr, vector.Length);
            int[] secondArrangedArr = new int[copyArrangedArr.Length];
            Array.Copy(arrangedArr, secondArrangedArr, vector.Length);

            for (int i = 0; i < copyArrangedArr.Length; i++)
            {
                copyArrangedArr[vector[i]] = secondArrangedArr[i];
            }
            int sum = 0;
            for (int i = 0; i < copyArrangedArr.Length; i++, sum = 0)
            {
                for (int j = i; j < copyArrangedArr.Length; j++)
                {
                    sum += copyArrangedArr[j];
                    if (sum == s)
                    {
                        isEqual = true;
                        Console.WriteLine("Yes");
                        System.Environment.Exit(0);
                    }
                    if (sum > s)
                    {
                        sum = 0;
                        break;
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[index] = i;
                Gen01(index - 1, vector);
            }
        }
    }
}
