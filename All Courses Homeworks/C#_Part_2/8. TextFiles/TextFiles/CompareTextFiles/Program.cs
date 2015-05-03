//Problem 4. Compare text files
//Write a program that compares two text files line by line and prints the number of lines
//that are the same and the number of lines that are different.
//Assume the files have equal number of lines.


using System;
using System.IO;

namespace CompareTextFiles
{
    class Program
    {
        static void Main()
        {
            var streamReader = new StreamReader(@"../../Files/text1.txt");
            var streamReader2 = new StreamReader(@"../../Files/text2.txt");
            string textLine = streamReader.ReadLine();
            string textLine2 = streamReader2.ReadLine();

            bool areEqual = true;
            //тук не ми чете всяка линия ами чете на параграфи.
            while (textLine != null)
            {
                if (textLine != textLine2)
                {
                    areEqual = false;
                }
                textLine = streamReader.ReadLine();
                textLine2 = streamReader2.ReadLine();
            }
            Console.WriteLine("Are equal - {0}",areEqual);
        }
    }
}
