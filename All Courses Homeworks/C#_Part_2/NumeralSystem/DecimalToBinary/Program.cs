//Problem 1. Decimal to binary
//Write a program to convert decimal numbers to their binary representation.


using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(Binary(n));
    }

    private static string Binary(long n)
    {
        string result = string.Empty;
        string output = string.Empty;
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
        return output;
    }
}

