//Problem 2. Concatenate text files
//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;

namespace ConcatenateTextFiles
{
    class Program
    {
        static void Main()
        {
            try
            {
                StreamReader firstSw = new StreamReader(@"../../Files/Text 1.txt", true);
                StreamReader secondSw = new StreamReader(@"../../Files/Text 2.txt", true);

                StreamWriter testResult = new StreamWriter(@"../../Files/Result.txt");
                string firstFile = string.Empty;
                string secondFile = string.Empty;



                using (firstSw)
                {
                    firstFile = firstSw.ReadToEnd();
                }
                using (secondSw)
                {
                    secondFile = secondSw.ReadToEnd();
                }
                using (testResult)
                {
                    testResult.WriteLine(firstFile);
                    testResult.WriteLine(secondFile);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Fatal error");
            }


        }
    }
}
