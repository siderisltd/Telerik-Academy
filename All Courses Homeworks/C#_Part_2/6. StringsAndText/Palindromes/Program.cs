//Problem 20. PalindromesWrite a program that
//exeracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Linq;
using System.Text;

namespace Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string text = "exeracts from a given text all palindromes, e.g. ABBA, lamal, exe. "+
                "saksiqta s bob stoeshe na prozoreca i sus neinoto tattarrattat this word meand soap stone vendor - saippuakivikauppias from the Oxford Dictionary ";
            string[] allWords = text.Split(new char[] { ' ', '.',',','!','?'}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Text is : {0}",text);
            Console.WriteLine();
            Console.WriteLine("Palindromes from the text are : ");
            Console.WriteLine();
            int counter = 1;
            for (int i = 0; i < allWords.Length; i++)
            {
                bool isPalindrome = true;
                if (allWords[i].Length > 2)
                {
                    string currentWord = allWords[i];
                    for (int j = 0; j < allWords[i].Length / 2; j++)
                    {
                        if (currentWord[j] == currentWord[(currentWord.Length - 1) - j])
                        {
                            continue;
                        }
                        else
                        {
                            isPalindrome = false;
                            break;
                        }
                    }
                    if (isPalindrome)
                    {
                        Console.WriteLine("{0} - {1}", counter, currentWord);
                        counter++;
                    }
                }
            }
        }
    }
}
