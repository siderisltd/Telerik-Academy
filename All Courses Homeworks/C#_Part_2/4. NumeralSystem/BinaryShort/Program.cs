//Problem 8. Binary short
//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).


using System;

class Program
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number,2).PadLeft(16,'0'));
    }
}

