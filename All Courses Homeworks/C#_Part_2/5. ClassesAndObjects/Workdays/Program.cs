//Problem 5. Workdays
//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list 
//of public holidays specified preliminary as array.


using System;
using System.Threading;
using System.Globalization;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string[] officialHolidays = { "01/1", "02/3", "03/3", "10/4", "11/4", 
                                        "12/4", "13/4", "01/5", "06/6", "21/9", "22/9", 
                                            "24/12", "25/12", "26/12", "31/12" };
        DateTime today = DateTime.Now;
        Console.Write("Timespan Date  dd/M : ");
        string date = Console.ReadLine();
        DateTime givenDate = DateTime.ParseExact(date, "dd/M", CultureInfo.InvariantCulture);
        int interval = givenDate.DayOfYear - today.DayOfYear;

        Console.WriteLine("All days are : {0}", interval);
        Console.WriteLine("Business Days are : {0}", BusinessDays(today, givenDate, officialHolidays));

        // TODO ! - string[] holidays
    }
    public static int BusinessDays(DateTime today, DateTime givenDate, string[] holidays)
    {
        int businessDays = new int();
        while (today <= givenDate)
        {
            if (today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday)
            {

            }
            else
            {
                businessDays++;
            }
            for (int i = 0; i < holidays.Length; i++)
            {
                DateTime comparingDate = DateTime.ParseExact(holidays[i], "dd/M", CultureInfo.InvariantCulture);
                if (today.Date == comparingDate)
                {
                    businessDays--;
                }
            }
            today = today.AddDays(1);
        }
        return businessDays;
    }
}

