//Problem 6. Save sorted names
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.


using System;
using System.IO;
using System.Linq;

namespace SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main()
        {
            var streamReader = new StreamReader(@"../../Files/Names.txt");
            var streamWriter = new StreamWriter(@"../../Files/SortedNames.txt");
            string[] namesUnsorted = streamReader.ReadToEnd().Split(new char[] { '\n','\r' },StringSplitOptions.RemoveEmptyEntries);
            string[] sortedNames = namesUnsorted.OrderBy(n => n).ToArray();
            using (streamWriter)
            {
                foreach (var name in sortedNames)
                {
                    streamWriter.WriteLine(name);
                }
            }
        }
    }
}
