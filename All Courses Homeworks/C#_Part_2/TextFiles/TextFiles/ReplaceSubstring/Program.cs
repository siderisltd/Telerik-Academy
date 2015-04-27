//Problem 7. Replace sub-string
//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).


using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceSubstring
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"../../Files/text.txt");
            string text = string.Empty;
            using (sr)
            {
                text = sr.ReadToEnd();
            }
            string pattern = "start"; 

            text = Censore(text, pattern);
            var sw = new StreamWriter(@"../../Files/result.txt");
            using (sw)
            {
                sw.WriteLine(text);
            }


        }

        private static string Censore(string text, string wordToChange)
        {
            Match match = Regex.Match(text, wordToChange, RegexOptions.IgnoreCase);
            string wordToInsert = "finish";
            int difference = 0;
            if (wordToInsert.Length > wordToChange.Length)
            {
                difference = wordToInsert.Length - wordToChange.Length;
            }
            else
            {
                difference = wordToChange.Length - wordToInsert.Length;
            }
            int counter = 0;
            while (match.Success)
            {
                text = text.Remove(match.Index + (counter * difference), wordToChange.Length);
                text = text.Insert(match.Index + (counter * difference), wordToInsert);
                match = match.NextMatch();
                counter++;
            }
            return text;
        }
    }
}
