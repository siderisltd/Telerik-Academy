//Problem 6. String length
//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.


using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        while (input.Length > 20)
        {
            Console.WriteLine("Incorrect input - try again");
            input = Console.ReadLine();
        }
        int characterToInsert = 20 - input.Length;

        input += new string('*', characterToInsert);
        Console.WriteLine(input);
    }
}
