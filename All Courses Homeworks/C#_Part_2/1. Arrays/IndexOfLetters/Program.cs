//Problem 12. Index of letters
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class Program
{
    static void Main()
    {
        int[] alphabetNumbers = new int[26];
        string input = Console.ReadLine();
        Console.WriteLine();
        for (int i = 0; i < alphabetNumbers.Length; i++)
        {
            alphabetNumbers[i] = i + 65;
        }
        input = input.ToUpper();
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < alphabetNumbers.Length; j++)
            {
                if (Convert.ToChar(input[i]) == Convert.ToChar(alphabetNumbers[j]))
                {
                    Console.Write(" || ");
                    Console.Write(alphabetNumbers[j] - 65 + " || ");
                }
            }
        }
        Console.ReadLine();
    }
}
