//Problem 13. Solve tasks
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Press [1] to reverse the digits of given number");
        Console.WriteLine("Press [2] to calculate the average of a sequence of integers");
        Console.WriteLine("Press [3] to solve a linear equation a * x + b = 0");
        Console.WriteLine();
        Console.Write("Your input: ");
        byte userInput = byte.Parse(Console.ReadLine());
        while (userInput != 1 && userInput != 2 && userInput != 3)
        {
            Console.Write("Incorrect input ! Input can only be 1,2 or 3 \r\nYour input: ");
            userInput = byte.Parse(Console.ReadLine());
        }
        switch (userInput)
        {
            case 1:
                Console.Write("Enter your number : ");
                decimal number = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Reversed number is : "+ Reversed(number));
        break;
            case 2:
        Console.Write("Enter your numbers separated by spaces : ");
        int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                                                    .Select(int.Parse).ToArray();
        Console.WriteLine("Average number of this sequence is : " + Average(numbers));
        break;
            case 3:
        Console.WriteLine("I can't solve a linear equasion yet :D");
        break;
        }
    }
    private static decimal Reversed(decimal number)
    {
        string holder = number.ToString();
        string stringRes = "";
        decimal result = new decimal();
        for (int i = holder.Length - 1; i >= 0; i--)
        {
            stringRes += holder[i];
        }
        result = decimal.Parse(stringRes);

        return result;
    }
    private static decimal Average(int[] numbers)
    {
        decimal average = 0;

        foreach (var num in numbers)
        {
            average += num;
        }
        average /= 2;

        return average;
    }
}

