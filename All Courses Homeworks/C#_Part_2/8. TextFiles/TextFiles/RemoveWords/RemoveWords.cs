//Problem 12. Remove words
//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Linq;

namespace CountWords
{
    class RemoveWords
    {
        static void Main()
        {
            StreamReader readText = new StreamReader(@"../../Files/text.txt");
            StreamReader readWords = new StreamReader(@"../../Files/words.txt");
            string text = string.Empty;
            string[] wordsToChangeArr;
            using (readText)
            {
                text = readText.ReadToEnd();
            }
            wordsToChangeArr = GetWordsInArray(readWords);
            for (int i = 0; i < wordsToChangeArr.Length; i++)
            {
                string wordToChange = wordsToChangeArr[i];
                text = Remove(text, wordToChange);
            }

            var writeResult = new StreamWriter(@"../../Files/result.txt");
            using (writeResult)
            {
                writeResult.WriteLine(text);
            }
        }

        private static string Remove(string text, string wordToChange)
        {

            int index = text.IndexOf(wordToChange, 0);
            while (index != -1)
            {
                if (index != 0 && index < text.Length)
                {
                    if (text[index + wordToChange.Length].ToString() == " " && text[index - 1].ToString() == " ")
                    {
                        text = text.Remove(index, wordToChange.Length + 1);
                    }
                }
                else
                {
                    if (text[index + wordToChange.Length].ToString() == " ")
                    {
                        text = text.Remove(index, wordToChange.Length + 1);
                    }
                }

                index = text.IndexOf(wordToChange, index + 1);
            }

            return text;
        }
        private static string[] GetWordsInArray(StreamReader wordsArrText)
        {
            //getting all words from the txt files in array
            string[] words;
            using (wordsArrText)
            {
                words = wordsArrText.ReadToEnd().Split(new string[] { " ", "\r\n", "\r", "\n", ",", "/" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            return words;
        }
    }
}
