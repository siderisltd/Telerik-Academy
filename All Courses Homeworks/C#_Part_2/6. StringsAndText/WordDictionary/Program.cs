//Problem 14. Word dictionary
//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

//Sample dictionary:
//input 	    output
//.NET 	    platform for applications from Microsoft
//CLR 	    managed execution environment for .NET
//namespace 	hierarchical organization of classes

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;

namespace WordDictionary
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfoByIetfLanguageTag("BG-bg");
            Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            dictionary.Add(".NET", "Платформа за апликации от Майкрософт");
            dictionary.Add("input", "Входни данни");
            dictionary.Add("CLR", "Среда за изпълнение на .NET");
            dictionary.Add("namespace", "Йерархична организация на класовете");
            Console.Write("Available words to translate : ");
            foreach (var word in dictionary)
            {
                Console.Write("|");
                Console.Write("{0}",word.Key);
                Console.Write("|");
            }
            Console.WriteLine();
            Console.Write("Enter your word : ");
            string input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{0} = {1}",input, dictionary[input]);

        }
    }
}
