//Problem 9. Delete odd lines
//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main()
        {
            var streamReader = new StreamReader(@"../../Files/text.txt");
            
            string textLine = string.Empty;
            string newText = string.Empty;
            using (streamReader)
            {
                textLine = streamReader.ReadLine();

                int counter = 1;
                    while (textLine != null)
                    {
                        if (counter % 2 == 0)
                        {
                            newText += textLine;
                            newText += "\r\n";
                        }
                        counter++;
                        textLine = streamReader.ReadLine();
                    }
            }
            newText =  newText.Remove(newText.Length - 2);
            var streamWriter = new StreamWriter(@"../../Files/text.txt");
            using (streamWriter)
            {
                streamWriter.WriteLine(newText);
            }
        }

    }
}
