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
      
        Console.Write("Timespan Date  dd/M : ");
        string date = Console.ReadLine();
        DateTime givenDate = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("day :"+ givenDate.Day + "month : " + givenDate.Month + "y :" + givenDate.Year);



       
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

