//Problem 8. Replace whole word
//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceSubstring
{
    class ReplaceWholeWord
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
           // Match match = Regex.Match(text, wordToChange, RegexOptions.IgnoreCase);
            string wordToInsert = "finish";

            int index = text.IndexOf(wordToChange,0);

            int counter = 0;
            while (index != -1)
            {
                if (index != 0 && index < text.Length)
                {
                    if (text[index + wordToChange.Length].ToString() == " " && text[index - 1].ToString() == " ")
                    {
                        text = text.Remove(index, wordToChange.Length);
                        text = text.Insert(index, wordToInsert);

                        counter++;
                    }
                }
                else
                {
                    if (text[index + wordToChange.Length].ToString() == " ")
                    {
                        text = text.Remove(index, wordToChange.Length);
                        text = text.Insert(index, wordToInsert);

                        counter++;
                    }
                }

                index = text.IndexOf(wordToChange, index + 1);
            }

            return text;
        }
    }
}
