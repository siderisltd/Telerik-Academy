//Problem 10.* Beer Time
//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
//a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time 
//according to the definition above or invalid time if the time cannot be parsed. 
//Note: You may need to learn how to parse dates and times.
using System;
using System.Globalization;

class Programa
{
    static void Main()
    {
        //Не разбирам, защо с && не изкарва конкретен резултат, а на теория би трябвало. 
        
        CultureInfo currentCulture = CultureInfo.InvariantCulture;
        DateTime first = DateTime.ParseExact("01:00 PM", "hh:mm tt", currentCulture);
        DateTime second = DateTime.ParseExact("03:00 AM", "hh:mm tt", currentCulture);
            string time = "01:00 PM";
            DateTime userTime = DateTime.ParseExact(time, "hh:mm tt", currentCulture);
            if (userTime.TimeOfDay > first.TimeOfDay || userTime.TimeOfDay < second.TimeOfDay)
            {
                Console.WriteLine("BeerTime");
            }
            else
            {
                Console.WriteLine("NON BeerTime");
            }
    }
}
