//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of 
//the Fibonacci sequence (at a single line, separated by comma 
//and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class FibonacciNumbers
{
    static void Main()
    {
        int result = new int();
        int first = new int();
        int second = 1;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.Write("0,");
            }
            if (i == 1)
            {
               Console.Write("1"); 
            }
            else if (i != 0 && i != 1)
            {
                result = first + second;
                Console.Write("," + result);
                first = second;
                second = result;
            }
        }
        Console.ReadLine();
    }
}
