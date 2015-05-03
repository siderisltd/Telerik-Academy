//Problem 13. Count words
//Write a program that reads a list of words from the file words.txt and finds how many times each of 
//the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of 
//their occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CountWords
{
    class CountWords
    {
        static void Main()
        {
            #region variables and streams
            var wordsArrTextReader = new StreamReader(@"../../Files/words.txt");
            var textReader = new StreamReader(@"../../Files/text.txt");
            string[] words;
            string[] allWordsInText;
            List<Tuple<string, int>> result = new List<Tuple<string, int>>();
            #endregion variables and streams
            words = GetWordsInArray(wordsArrTextReader);
            allWordsInText = GetWordsInArray(textReader);
            FillingTheList(words, allWordsInText, result);
            SaveInNewFile(result);
        }
        private static void FillingTheList(string[] words, string[] allWordsInText, List<Tuple<string, int>> result)
        {
            try
            {
                int counter = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    string currentWord = words[i];
                    for (int j = 0; j < allWordsInText.Length; j++)
                    {
                        if (currentWord == allWordsInText[j])
                        {
                            counter++;
                        }
                    }
                    result.Add(Tuple.Create(currentWord, counter));
                    counter = 0;
                }

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The index is out of range");
            }
            catch (OverflowException)
            {
                Console.WriteLine("You are giving file size beyond the capacity");
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("You are giving file size beyond the capacity");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format");
            }
            catch (Exception)
            {
                Console.WriteLine("Fatal Error");
            }
        }
        private static void SaveInNewFile(List<Tuple<string, int>> result)
        {
            try
            {
                var output = new StreamWriter(@"../../Files/result.txt");
                using (output)
                {
                    //printing in descending order
                    foreach (var item in result.OrderByDescending(key => key.Item2))
                    {
                        output.WriteLine("{0,13} -{1,2}", item.Item1, item.Item2);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format");
            }
            catch (Exception)
            {
                Console.WriteLine("Fatal error!");
            }
        }
        private static string[] GetWordsInArray(StreamReader wordsArrText)
        {
            //getting all words from the txt files in array
            string[] words = new string[0];
            try
            {
                using (wordsArrText)
                {
                    words = wordsArrText.ReadToEnd().Split(new string[] { " ", "\r\n", "\r", "\n", ",", "/" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file is not found in the specified directory");
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("The file is using by another program");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format");
            }
            catch (IOException)
            {
                Console.WriteLine("IO exception");
            }
            catch (Exception)
            {
                Console.WriteLine("Fatal error");
            }
            return words;
        }
    }
}
