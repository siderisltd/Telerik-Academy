using System;

class Program
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal s = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal result = ((s * n) / 500) * p;
        Console.WriteLine("{0:F2}", result);

    }
}