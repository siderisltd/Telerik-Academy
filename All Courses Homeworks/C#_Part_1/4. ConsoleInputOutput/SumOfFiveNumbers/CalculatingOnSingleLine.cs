//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum

using System;

class Program
{
    static void Main()
    {
        int result = new int();
        string lineToSum = "1 2 3 4 5";
        string[] splitedNumbers = lineToSum.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int index = 0; index < splitedNumbers.Length; index++)
        {
           result += int.Parse(splitedNumbers[index]);
        }
        Console.WriteLine(result);
        
    }
}

