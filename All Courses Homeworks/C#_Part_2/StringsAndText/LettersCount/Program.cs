//Problem 21. Letters count
//Write a program that reads a string from the console and prints all different 
//letters in the string along with information how many times each letter is found.

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            string letter = "letters in the string along with information how many times each letter is found.";
            char currentChar = new char();
            HashSet<Tuple<string,int>> test = new HashSet<Tuple<string,int>>();

            int count = 0;

            for (int i = 0; i < letter.Length; i++)
            {
                currentChar = letter[i];
                for (int j = 0; j < letter.Length; j++)
                {
                    if (letter[j] == currentChar)
                    {
                        count++;
                    }
                }
                test.Add(Tuple.Create<string, int>(currentChar.ToString(), count));
                count = 0;
            }

            foreach (var item in test)
            {
                Console.WriteLine("Letter : {0}      Count : {1}",item.Item1,item.Item2); 
            }
        }
    }
}
