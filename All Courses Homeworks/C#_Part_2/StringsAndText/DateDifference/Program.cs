//Problem 16. Date difference
//Write a program that reads two dates in the format: day.month.year and 
//calculates the number of days between them.

//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace DateDifference
{
    class DateDifference
    {
        static void Main()
        {
            Console.WriteLine("Press [1] instead of firstDate if you want to compare a date with today");
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("BG-bg");
            Console.Write("Enter first date in format dd.MM.yyyy /ex.27.02.2006/ : ");
            string dateOne = Console.ReadLine();
            Console.Write("Enter first date in format d.MM.yyyy /ex.3.03.2006/ : ");
            string dateTwo = Console.ReadLine();
            DateTime firstDate;
            if (dateOne == "1")
            {
                firstDate = DateTime.Now;
                dateOne = DateTime.Now.Date.ToString();
                dateOne = dateOne.Remove(9);
            }
            else
            {
                firstDate = DateTime.ParseExact(dateOne, "dd.MM.yyyy", CultureInfo.CreateSpecificCulture("BG-bg"));
            }
           
            DateTime secondDate = DateTime.ParseExact(dateTwo, "d.MM.yyyy", CultureInfo.CreateSpecificCulture("BG-bg"));
            int yearsDifference = 0;
            ulong dateDifference = 0;
            int secondDateBigger = secondDate.DayOfYear - firstDate.DayOfYear;
            int firstDateBigger = secondDate.DayOfYear - firstDate.DayOfYear;

            if (secondDate.Year > firstDate.Year)
            {
                yearsDifference = secondDate.Year - firstDate.Year;
                int isLeap = secondDate.Year;
                while (yearsDifference > 0)
                {
                    if (DateTime.IsLeapYear(isLeap))
                    {
                         dateDifference += 366;
                    }
                    else
                    {
                        dateDifference += 365;
                    }
                    isLeap--;
                    yearsDifference--;
                }
               
            }

            else if (secondDate.Year < firstDate.Year)
            {
                yearsDifference = firstDate.Year - secondDate.Year;
                int isLeap = firstDate.Year;
                while (yearsDifference > 0)
                {
                    if (DateTime.IsLeapYear(isLeap))
                    {
                        dateDifference += 366;
                    }
                    else
                    {
                        dateDifference += 365;
                    }
                    isLeap--;
                    yearsDifference--;
                }
            }



            Console.WriteLine(secondDate.DayOfYear);
            Console.WriteLine(firstDate.DayOfYear);

            if (secondDate.DayOfYear > firstDate.DayOfYear)
            {
                if (DateTime.IsLeapYear(secondDate.Year))
                {
                    secondDate = secondDate.AddDays(1);
                }
                dateDifference += (ulong)(secondDate.DayOfYear - firstDate.DayOfYear);
            }
            else
            {
                if (DateTime.IsLeapYear(firstDate.Year))
                {
                    firstDate = firstDate.AddDays(1);
                }
                dateDifference += (ulong)(firstDate.DayOfYear - secondDate.DayOfYear);
            }
            Console.Clear();

            Console.WriteLine("Distance between {0} & {1} is ",dateOne, dateTwo);
            Console.WriteLine("There are: " + (dateDifference) + " Days");
            Console.WriteLine("There are: " + (dateDifference * 24) + " Hours");
            Console.WriteLine("There are: " + ((dateDifference * 24)*60) + " Minutes");
            Console.WriteLine("There are: " + (((dateDifference * 24) * 60)*60) + " Seconds");

        }
    }
}
