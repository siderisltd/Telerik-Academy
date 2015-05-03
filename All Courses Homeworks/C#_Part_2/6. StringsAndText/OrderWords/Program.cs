//Problem 24. Order words
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


using System;
using System.Linq;
using System.Text;

namespace OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(p => p).ToArray();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
