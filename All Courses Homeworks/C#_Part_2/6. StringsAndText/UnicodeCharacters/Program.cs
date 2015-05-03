//Problem 10. Unicode characters
//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.


using System;
using System.Linq;
using System.Text;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            foreach (var character in input)
            {
                Console.Write("|");
                char a = character;
                string escape = "\\u" + ((int)a).ToString("X").PadLeft(4, '0');
                Console.Write(String.Format("{0}|",escape));
            }
            Console.WriteLine();
            Console.ReadLine();
            
        }
    }
}
