
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(GCD(45, 75));
    }
    public static int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        if (a == 0)
            return b;
        else
            return a;
    }
}