//Problem 17.* Subset K with sum S
//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.


using System;

class Program
{
    static int s = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());
    static bool isEqual = false;
    static int[] vector = new int[]
           {
                2, 1, 2, 4, 3, 5, 2, 6

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
            int counter = 0;
            for (int i = 0; i < copyArrangedArr.Length; i++, sum = 0)
            {
                for (int j = i; j < copyArrangedArr.Length; j++)
                {
                    counter++;
                    if (counter <= k)
                    {
                        sum += copyArrangedArr[j];
                    }
                    else if (counter > k)
                    {
                        counter = 0;
                        break;
                    }
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
