//Problem 13. Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //string binaryNumber = "1110000110000101100101000000";
        string binaryNumber = Console.ReadLine();
        string reversedBinaryNumber = "";
        long result = 0;

        for (int a = binaryNumber.Length; a > 0; a--)  // This reverses the binary number for reading from right to left
        {                                              
            reversedBinaryNumber += binaryNumber[a - 1];
        }
        
        for (int i = 0; i < binaryNumber.Length; i++)  // For loop to check all digits in the given string
        {
            long currentNumber = long.Parse(reversedBinaryNumber[i].ToString()); //getting the currentNumber as integer
            if (currentNumber != 0)
            {
                result += OnPower(2, i);
            }
        }
        Console.WriteLine(result);
        
    }
    public static long OnPower(long number, long power) // Method returning the number X on power Y 
    {
        long result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }
        return result;
    }
}
