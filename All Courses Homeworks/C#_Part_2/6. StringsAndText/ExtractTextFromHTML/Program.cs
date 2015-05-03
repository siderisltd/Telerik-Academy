//Problem 25. Extract text from HTML
//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//Example input:
//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>

//Output:
//Title: News
//Text: Telerik Academy aims to provide free real-world practical training for young people who want to 
//turn into skilful .NET software engineers.
//Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.



using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        static void Main()
        {
            string text = "<html> <head><title>News</title></head> <body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body> </html>";
            int titleIndexStart = text.IndexOf("<title>", 0);
            int titleIndexEnd = text.IndexOf("</title>", 0);

            while (titleIndexStart != -1 || titleIndexEnd != -1)
            {
                Console.WriteLine("Title : " + text.Substring(titleIndexStart + 7, titleIndexEnd - titleIndexStart - 7));
                titleIndexStart = text.IndexOf("<title>", titleIndexStart + 1);
                titleIndexEnd = text.IndexOf("</title>", titleIndexEnd + 1);
            }

            int textIndexStart = text.IndexOf("<p>", 0);
            int textIndexEnd = text.IndexOf("</p>", 0);
            string almostFinishedText = string.Empty;

            while (textIndexStart != -1 || textIndexEnd != -1)
            {
                almostFinishedText += text.Substring(textIndexStart + 3, textIndexEnd - textIndexStart - 3);
                textIndexStart = text.IndexOf("<p>", textIndexStart + 1);
                textIndexEnd = text.IndexOf("</p>", textIndexEnd + 1);
            }
            int firstIndexHrefTag = almostFinishedText.IndexOf("<a href", 0);
            int secondIndexHrefTag = almostFinishedText.IndexOf(">", 0);

            //Console.WriteLine(almostFinishedText);
            string finishedText = string.Empty;

            while (firstIndexHrefTag != -1 && secondIndexHrefTag != -1)
            {
                finishedText += almostFinishedText.Substring(secondIndexHrefTag + 1);
                firstIndexHrefTag = almostFinishedText.IndexOf("<a href", firstIndexHrefTag + 1);
                secondIndexHrefTag = almostFinishedText.IndexOf(">", secondIndexHrefTag + 1);
            }
            string pattern = "</a>|</ul>|</li>";
            finishedText = Regex.Replace(finishedText, pattern, " ");
            Console.WriteLine("Text : " + finishedText);
        }
    }
}
