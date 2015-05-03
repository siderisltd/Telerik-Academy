//Problem 11. Prefix "test"
//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CountWords
{
    class PrefixTest
    {
        static void Main()
        {
            try
            {
                #region variables
                StreamReader textReader = new StreamReader(@"../../Files/text.txt");
                List<string> textWords = new List<string>();
                string text = string.Empty;
                using (textReader)
                {
                    text = textReader.ReadToEnd();
                }
                string pattern = "test[a-zA-z0-9]*";
                List<string> wordsInText = GetWordsInArray(text, pattern);
                string[] textArr = text.Split(wordsInText.ToArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                #endregion variables
                CheckingWords(textWords, wordsInText, textArr);
                PrintResult(textWords);
            }
            #region possible exceptions
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("The file may be opened");
            }
            catch (Exception)
            {
                Console.WriteLine("Fatal error");
            }
            #endregion possible exceptions
        }

        private static void CheckingWords(List<string> textWords, List<string> wordsInText, string[] textArr)
        {
            foreach (var item in textArr)
            {
                textWords.Add(item);
            }

            foreach (var word in wordsInText)
            {
                foreach (var wo in textWords)
                {
                    if (word == wo)
                    {
                        textWords.Remove(word);
                        break;
                    }
                    else
                    {
                    }
                }
            }
        }
        private static void PrintResult(List<string> textWords)
        {
            StreamWriter writer = new StreamWriter(@"../../Files/result.txt");
            using (writer)
            {
                foreach (var item in textWords)
                {
                    writer.Write(item + " ");
                }
            }
        }
        private static List<string> GetWordsInArray(string text, string pattern)
        {
            //getting all words from the txt files in array
            List<string> result = new List<string>();
            Match match = Regex.Match(text, pattern, RegexOptions.IgnoreCase);
            while (match.Success)
            {
                var currentWord = text.Substring(match.Index, match.Length);
                result.Add(currentWord);
                match = match.NextMatch();
            }
            result.Add(" ");
            result.Reverse();
            return result;
        }
    }
}
