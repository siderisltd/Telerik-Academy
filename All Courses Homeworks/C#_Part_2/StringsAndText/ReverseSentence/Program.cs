//Problem 13. Reverse sentence
//Write a program that reverses the words in given sentence.

//Example:
//input 	                                          output
//C# is not C++, not PHP and not Delphi! 	          Delphi not and PHP, not C++ not is C#!

using System;
using System.Linq;
using System.Text;

namespace ReverseSentence
{
    class ReverseSentences
    {
        static void Main()
        {
            string input = "C# is not C++, not PHP and not Delphi!";
            string[] wordsOfInput = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string newInput = string.Empty;
            int wordsCount = 0;

            for (int i = wordsOfInput.Length - 1; i >= 0; i--)
            {

                newInput += wordsOfInput[i];
                if (i != 0)
                {
                    newInput += " ";
                }
                else
                {
                    continue;
                }
            }
            newInput += input[input.Length - 1];
            Console.WriteLine(newInput);
        }
    }
}
