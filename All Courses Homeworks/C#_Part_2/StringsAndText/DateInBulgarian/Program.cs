//Problem 17. Date in Bulgarian
//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and
//prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Threading;
using System.Globalization;

namespace DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");
            var culture = new System.Globalization.CultureInfo("bg-BG");
            Console.WriteLine("Enter date in format [dd.MM.yyyy HH:mm:ss] ex. \"26.08.1993 13:00:00");
            string date = Console.ReadLine();//"26.08.1993 13:00:00";
            DateTime selectedDate = DateTime.ParseExact(date, String.Format("dd.MM.yyyy HH:mm:ss"), culture);
            var day = culture.DateTimeFormat.GetDayName(selectedDate.DayOfWeek);
            Console.WriteLine("Before adding : {0} {1}", selectedDate, day);
            selectedDate = selectedDate.AddHours(6);
            selectedDate = selectedDate.AddMinutes(30);
            day = culture.DateTimeFormat.GetDayName(selectedDate.DayOfWeek);
            Console.WriteLine("After adding : {0} {1}",selectedDate,day);
        }
    }
}
