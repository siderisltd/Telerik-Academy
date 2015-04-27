//Problem 19.* Permutations of set
//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].


using System;

class Program
{
    static int n = int.Parse(Console.ReadLine());
    static bool write = true;
    static void Main()
    {

        int[] vector = new int[n];
        Gen01(n - 1, vector);
    }
    static void Gen01(int index, int[] vector)
    {
        if (index == -1)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                int currentNum = i+1;

                if (vector[i] == vector[currentNum])
                {
                    write = false;
                    break;
                }
            }
            if (write)
            {
                Print(vector);
            }
        }
        else
        {
            write = true;
            for (int i = 1; i <= n; i++)
            {
                vector[index] = i;
                Gen01(index - 1, vector);
            }
        }
    }
    static void Print(int[] arr)
    {
        foreach (var vec in arr)
        {
            Console.Write("{0}", vec);
        }
        Console.WriteLine();
    }
}

