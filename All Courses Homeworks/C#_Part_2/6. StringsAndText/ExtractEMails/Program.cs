//Problem 18. Extract e-mails
//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.


using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractEMails
{
    class ExtractEMails
    {
        static void Main()
        {
            string emails = Console.ReadLine();//"test-1.p46@ala-bala.somehost.somewhere.bg ivan@abv.bg Denica.@-host.bg Ivanov@gmail.com";
            string regex = @"\w*([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" +
              @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})\w*";
            Match email = Regex.Match(emails, regex);
            while (email.Success)
            {
                Console.WriteLine("email match is: " + email);
                email = email.NextMatch();
            }

        }
    }
}
