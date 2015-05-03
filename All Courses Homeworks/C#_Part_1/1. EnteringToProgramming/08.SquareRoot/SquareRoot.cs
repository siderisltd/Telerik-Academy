//Problem 8. Square Root
//Create a console application that calculates and prints the square root of the number 12345.
//Find in Internet “how to calculate square root in C#”.

using System;

class Program
{
    static void Main()
    {
        //Defining number
        int number = 12345;
        //Defining sqrt in decimal variable for most correct result
        decimal sqrt = (decimal) Math.Sqrt(number);

        Console.WriteLine(sqrt);

    }
}
