//Problem 1. StringBuilder.Substring
//Implement an extension method Substring(int index, int length) for the class StringBuilder that 
//returns new StringBuilder and has the same functionality as Substring in the class String

namespace StringBuilderSubstring
{
    using System;
    using System.Linq;
    using System.Text;

    public class Program
    {
        private static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("0123456789");
            StringBuilder test = sb.SubString(2, 4);  // 2 3 4 5
            Console.WriteLine(test);
        }
    }
}
