//Problem 3. Line numbers
//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main()
        {
            var streamReader = new StreamReader(@"../../Files/text.txt");
            var streamWriter = new StreamWriter(@"../../Files/result.txt");
            string textLine = streamReader.ReadLine();
            int counter = 1;
            //тук не ми чете всяка линия ами чете на параграфи.
            using (streamWriter)
            {
                while (textLine != null)
                {

                    streamWriter.WriteLine(counter + "-" + textLine);



                    counter++;
                    textLine = streamReader.ReadLine();
                }
            }
            streamReader.Close();

        }
    }
}
