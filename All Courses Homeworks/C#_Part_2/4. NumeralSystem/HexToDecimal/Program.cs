//Problem 4. Hexadecimal to decimal
//Write a program to convert hexadecimal numbers to their decimal representation.




using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //string number = "ABC3";
        Console.Write("Enter Number in HEX Format : ");
        string number = Console.ReadLine();
        List<long> listOfNumbers = new List<long>();
        int countSystem = 16; // Count system we wanna use
        long currentNumber = 0;
        long result = 0;
        for (int a = number.Length; a > 0; a--)  // This reverses the binary number for reading from right to left
        {
            switch (number[a - 1]) // Checking if some value == A,B,C,D,E,F and transfer the actual dec value to it
            {
                case 'A':
                    currentNumber = 10;
                    break;
                case 'B':
                    currentNumber = 11;
                    break;
                case 'C':
                    currentNumber = 12;
                    break;
                case 'D':
                    currentNumber = 13;
                    break;
                case 'E':
                    currentNumber = 14;
                    break;
                case 'F':
                    currentNumber = 15;
                    break;
                default:
                    currentNumber = long.Parse((number[a - 1]).ToString()); // If it's not, than simply convert it to long
                    break;
            }
            listOfNumbers.Add(currentNumber); // and than add it to the dynamic list

        }
        for (int power = 0; power < listOfNumbers.Count; power++)
        {
            result += listOfNumbers[power] * OnPower(countSystem, power); // So by this formula we can get any count system by base
        }
        Console.WriteLine("result : " + result);
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

