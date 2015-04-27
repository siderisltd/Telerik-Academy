//Problem 1. Leap year
//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;
using System.Threading;
using System.Globalization;

class Program
{
    
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Input date in format dd/M/yyyy separated by / : ");
        string dateAsString = Console.ReadLine();

        DateTime date = DateTime.ParseExact(dateAsString,"dd/M/yyyy", CultureInfo.InvariantCulture);
        string isLeap = "No";
        string nextLeapYear = string.Empty;
        int currentYear = date.Year;
        if (DateTime.IsLeapYear(date.Year))
        {
            isLeap = "Yes";
        }
        else
        {
            while (nextLeapYear == string.Empty)
            {
                currentYear++;
                if (DateTime.IsLeapYear(currentYear))
                {
                    nextLeapYear = currentYear.ToString();
                }
            }
        }
        
        Console.WriteLine("{0:dd/M/yyyy}"+" -->"+"Is leap Year :"+ isLeap, date);
        Console.WriteLine("Next leap year will be : " + nextLeapYear);

    }
}

