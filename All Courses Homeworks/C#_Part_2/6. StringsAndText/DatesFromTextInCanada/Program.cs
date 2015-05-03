//Problem 19. Dates from text in Canada
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;

namespace DatesFromTextInCanada
{
    class DatesFromTextInCanada
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
            string text = "From 12.12.2015 to 12/10/2018 are born 189993 computer programmers"+
            "this is 60% raising from past 12.12.2010 and 04.11.2013 y";
            string pattern = "\\w*[0-9]{2}.[0-9]{2}.[0-9]{4}|[0-9]{2}/[0-9]{2}/[0-9]{4}";
            Match match = Regex.Match(text, pattern);
            string[] dateTimeFormat = { "dd/MM/yyyy","dd.MM.yyyy", };
            List<DateTime> dateTimes = new List<DateTime>();
            
            while (match.Success)
            {
                string currDate = match.ToString();
                DateTime currentDateTime = DateTime.ParseExact(currDate, dateTimeFormat,CultureInfo.GetCultureInfo("en-CA"),DateTimeStyles.AdjustToUniversal);
                dateTimes.Add(currentDateTime);
                match =  match.NextMatch();
            }
            foreach (var date in dateTimes)
            {
                Console.WriteLine(date);
            }
        }
    }
}
