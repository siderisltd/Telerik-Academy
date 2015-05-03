//Problem 20.* Variations of set

//    Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

//Example:
//N 	K 	  result
//3 	2 	  {1, 1}
//            {1, 2}
//            {1, 3}
//            {2, 1}
//            {2, 2}
//            {2, 3}
//            {3, 1}
//            {3, 2}
//            {3, 3}

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
                Print(vector);
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
        for (int i = k - 1; i >= 0; i--)
        {

            Console.Write("{0}", vector[i]);
            if (i != 0)
            {
                Console.Write(",");
            }
        }
        Console.Write("}");
        Console.WriteLine();
    }
}