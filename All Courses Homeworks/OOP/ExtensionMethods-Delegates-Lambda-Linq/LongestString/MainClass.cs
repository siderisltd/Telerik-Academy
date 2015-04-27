//Problem 17. Longest string
//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

using System;
using System.Linq;

namespace LongestString
{
    class MainClass
    {
        static void Main()
        {
            string[] arr = new string[] 
            { 
                "as" ,
                "asas",
                "sdsbfgf",
                "na  baba mi hvarchiloto"
            };

            string[] longestArr =
                (from seq in arr
                orderby seq.Length descending
                select seq).ToArray();

            Console.WriteLine(longestArr[0]);
        }
    }
}
