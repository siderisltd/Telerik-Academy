//Problem 23. Series of letters
//Write a program that reads a string from the console and replaces all series of consecutive 
//identical letters with a single one.

//Example:
//input 	                output
//aaaaabbbbbcdddeeeedssaa 	abcdedsa

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();//"aaaaabbbbbcdddeeeedssaaaaab";
            bool isThere = false;
            string newResult = string.Empty;

            for (int i = 0; i < input.Length ; i++)
            {
                if (i < input.Length - 1)
                {
                    if (input[i + 1] != input[i])
                    {
                        newResult += input[i];
                    }
                }
                else
                {
                    newResult += input[i];
                }
            }            
            Console.WriteLine(newResult);
        }
    }
}
