using System;
using System.Threading;
using System.Globalization;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string number = Console.ReadLine();
        double n = double.Parse(number);
        int result = 0;
        if (n <= 9 && n >= 0)
        {
            result = (int)n;
        }
        while (n > 9 || n < 0)
        {
            result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (!(number[i] == '.' || number[i] == '-'))
                {
                    result += int.Parse(number[i].ToString());

                }
            }
            n = result;
            number = n.ToString();
        }
        Console.WriteLine(result);
    }
}