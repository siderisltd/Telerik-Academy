//Problem 1. Odd lines
//Write a program that reads a text file and prints on the console its odd lines.


using System;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main()
        {
            var streamreader = new StreamReader(@"../../Files/text.txt");
            using (streamreader)
            {
                string textLine = streamreader.ReadLine();

                int counter = 1;
                while (textLine != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(textLine);
                    }
                    counter++;
                    textLine = streamreader.ReadLine();
                }
            }
        }
    }
}
