//Problem 10. Extract text from XML
//Write a program that extracts from given XML file all the text without the tags.
//Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
//<interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

using System;
using System.Text.RegularExpressions;

namespace CountWords
{
    class ExtractTextFromXML
    {
        static void Main()
        {
            string text = "<?xml version=\"1.0\"><student><name>Pesho</name><age>21</age><interests count=\"3\"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>";
            Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));
        }
    }
}
