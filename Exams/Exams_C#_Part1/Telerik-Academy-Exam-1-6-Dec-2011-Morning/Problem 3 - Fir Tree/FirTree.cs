using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int bottom = n;
        int symbol = 1;
        int dots = n - 2;
        for (int i = 0; i < n-1; i++)
        {
            Console.Write(new string('.', dots));
            Console.Write(new string('*', symbol));
            Console.Write(new string('.', dots));
            symbol += 2;
            dots--;
            Console.WriteLine();
        }
        Console.Write(new string('.', bottom -2));
        Console.Write("*");
        Console.WriteLine(new string('.', bottom - 2));

    }
}