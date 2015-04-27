using System;
using System.Globalization;
using System.Threading;

class NextDate
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        DateTime now = new DateTime(year,month,day);
        DateTime add = now.AddDays(1);
        Console.WriteLine("{0:d.M.yyy}",add);
    }
}