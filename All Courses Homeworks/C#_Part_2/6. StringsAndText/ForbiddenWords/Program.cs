//Problem 9. Forbidden words
//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0
//and is implemented as a dynamic language in CLR.
//Forbidden words: PHP, CLR, Microsoft
//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0
//and is implemented as a dynamic language in ***.

using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            string forbiddenWords = "PHP|CLR|Microsoft";
            string text = "Microsoft announced its next generation PHP compiler today. pIt is based " +
            "on .NET Framework 4.0and is implemented as a dynamic language in CLR.";


            text = Censore(text, forbiddenWords);

        }

        private static string Censore(string text, string forbiddenWords)
        {
            Match match = Regex.Match(text, forbiddenWords, RegexOptions.IgnoreCase);
            while (match.Success)
            {
                var CurrentWord = text.Substring(match.Index, match.Length);
                text = Regex.Replace(text, CurrentWord, new String('*', match.Length));
                match = match.NextMatch();
            }
            Console.WriteLine(text);
            return text;
        }
    }
}
