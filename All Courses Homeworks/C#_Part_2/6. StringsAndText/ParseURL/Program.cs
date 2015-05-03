//Problem 12. Parse URL
//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.


using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ParseURL
{
    class ParsingURL
    {
        static void Main()
        {
            //input 
            string input = Console.ReadLine();//"http://telerikacademy.com/Courses/Courses/Details/212";
            string protocolFormat = @"^\w*[TCPUDHOFIMAGRES]{3,5}://"; // letters to the most common protocols from wikipedia
         
            //output
            
            var protocol = string.Empty;
            string server = string.Empty;
            string resource = string.Empty;


            Match protocolMatch = Regex.Match(input, protocolFormat, RegexOptions.IgnoreCase);
            if (protocolMatch.Success)
            {
                protocol = input.Substring(protocolMatch.Index,protocolMatch.Length - 3).ToString();
                input = input.Remove(protocolMatch.Index, protocolMatch.Length);
            }
            else
            {
                Console.WriteLine("Incorrect address");
                System.Environment.Exit(0);
            }
            int breakIndex = input.IndexOf('/', 1);
            server = input.Substring(0, breakIndex);
            resource = input.Remove(0, breakIndex);
            Console.Write("[protocol] = {0}\n[server] = {1}\n[resource] = {2}", protocol, server, resource);
            Console.WriteLine();
        }
    }
}
