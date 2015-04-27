//Problem 9. Matrix of Numbers
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints
//a matrix like in the examples below. Use two nested loops.


using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int currentnumber = 1;
        int startNumber = 1;
       
        for (int rows = 1; rows <= n; rows++)
        {
            for (int cols = 1; cols <= n; cols++)
            {
                Console.Write(currentnumber);
                if (cols == 2)
                {
                    startNumber = currentnumber;
                }
                currentnumber++;
            }
            currentnumber = startNumber;
            Console.WriteLine();
        }
    }
}

