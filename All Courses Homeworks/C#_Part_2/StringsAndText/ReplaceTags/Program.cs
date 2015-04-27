//Problem 15. Replace tags
//Write a program that replaces in a HTML document given as string all the 
//tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].


using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ReplaceTags
{
    class ReplaceTags
    {
        static void Main()
        {
            string text = "asdfsfsfdsf<a href=\"http://www.w3schools.com\">Visit W3Schools.com!</a> sfdsdfsdfsfsd";
            string patternFirst = @"<a href=";
            string patternSecond = "\\w*</a>";
            text = Regex.Replace(text, patternFirst,"[URL=…]");
            text = Regex.Replace(text,patternSecond,"[/URL]");

            Console.WriteLine(text);

        }
        
    }
}
