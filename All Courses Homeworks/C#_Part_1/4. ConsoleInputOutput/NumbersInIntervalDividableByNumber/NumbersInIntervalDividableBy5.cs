//Problem 11.* Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and prints how many numbers p exist
//between them such that the reminder of the division by 5 is 0.

using System;
using System.Collections.Generic;

class NumbersInIntervalDividableBy5
{
    static void Main()
    {
        Console.Write("Start:");
        int start = int.Parse(Console.ReadLine());
        Console.Write("End:");
        int end = int.Parse(Console.ReadLine());
        int? p = new int();
        List<int> iList = new List<int>();
        int counterForSecondArray = 1;

        for (int index = start; index <= end; index++)
        {
            
            if ((index % 5) == 0)
            {
                p++;
                for (int i = counterForSecondArray-1; i < counterForSecondArray; i++)
                {
                    iList.Add(index);
                }
            }
        }
        Console.WriteLine("p= "+p);
        foreach (var item in iList)
        {
            Console.Write(item+",");
        }
        Console.ReadLine();
    }
}

