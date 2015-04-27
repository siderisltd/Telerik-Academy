using System;
using System.Threading;
using System.Globalization;

class mathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        const double firstConst = 1337;
        const double secondConst = 128.523123123;
        double firstExpression = (n * n) + 1 / (m * p) + firstConst;
        double secondExpression = n - (secondConst * p);
        double result = firstExpression / secondExpression + Math.Sin((int)m % 180);
        Console.WriteLine("{0:F6}", result);
    }
}