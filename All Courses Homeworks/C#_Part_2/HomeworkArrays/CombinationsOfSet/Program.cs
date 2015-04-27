//Problem 21.* Combinations of set
//Write a program that reads two numbers N and K and generates all the combinations 
//of K distinct elements from the set [1..N].

//Example:
//N 	K 	result
//5 	2 	{1, 2}
//          {1, 3}
//          {1, 4}
//          {1, 5}
//          {2, 3}
//          {2, 4}
//          {2, 5}
//          {3, 4}
//          {3, 5}
//          {4, 5}

using System;

class Program
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());
    static bool write = true;
    static int[] vector = new int[k];
    
    static void Main()
    {
        Gen01(k - 1, vector);
    }
    static void Gen01(int index, int[] vector)
    {
        if (index == -1)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                if (vector[i] == vector[i+1])
                {
                    write = false;
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
        Console.Write("{");
        for (int i = 0; i < k; i++)
        {

            Console.Write("{0}", vector[i]);
            if (i != k - 1)
            {
                Console.Write(",");
            }
        }
        Console.Write("}");
        Console.WriteLine();
    }
}
