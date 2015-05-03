//Problem 14. Decimal to Binary Number
//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.


using System;

class Program
{
    static void Main()
    {
        //long n = 43691;.
        long n = long.Parse(Console.ReadLine());
        string result = "";
        string output = "";
        long remainder = 0;

        while (n > 0)
        {
            remainder = n % 2;
            n /= 2;
            if (remainder == 1)
            {
                result += "1";
            }
            if (remainder == 0)
            {
                result += "0";
            }
        }

        for (int a = result.Length; a > 0; a--)  // This reverses the binary number for reading from right to left
        {
            output += result[a - 1];
        }
        Console.WriteLine(output);
    }
}