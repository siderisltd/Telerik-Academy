//Problem 7. Sort 3 Numbers with Nested Ifs
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        bool someEqual = (a == b || a == c || b == c);

        if (someEqual)
        {
            if (a == b && a == c && b == c)
            {
                Console.Write(a + "," + b + "," + c);
            }
            if (a == b && a > c)
            {
                Console.Write(a + "," + b + "," + c);
            }
            else if (a == b && a < c)
            {
                Console.Write(c + "," + a + "," + b);
            }
            if (a == c && a > b)
            {
                Console.Write(a + "," + c + "," + b);
            }
            else if (a == c && a < b)
            {
                Console.Write(b + "," + a + "," + c);
            }
            if (b == c && b > a)
            {
                Console.Write(b + "," + c + "," + a);
            }
            else if (b == c && b < a)
            {
                Console.Write(a + "," + b + "," + c);
            }
        }
        else
        {
            if (a > b && a > c) // for a
            {
                Console.Write(a + ",");
                if (b > c)
                {
                    Console.WriteLine(b + "," + c);
                }
                else if (b < c)
                {
                    Console.WriteLine(c + "," + b);
                }
            }
            if (b > a && b > c) // for b
            {
                Console.Write(b + ",");
                if (a > c)
                {
                    Console.WriteLine(a + "," + c);
                }
                else if (a < c)
                {
                    Console.WriteLine(c + "," + a);
                }
            }
            if (c > a && c > b) // for c
            {
                Console.Write(c + ",");
                if (a > b)
                {
                    Console.WriteLine(a + "," + b);
                }
                else if (a < b)
                {
                    Console.WriteLine(b + "," + a);
                }
            }
        }
    }
}

