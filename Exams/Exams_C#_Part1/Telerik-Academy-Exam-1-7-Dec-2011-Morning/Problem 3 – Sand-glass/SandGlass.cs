using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int symbols = n;
        int dots = 1;
        Console.WriteLine(new string('*', symbols));
        for (int i = 0; i < n / 2; i++)
        {
            symbols -= 2;
            Console.Write(new string ('.',dots));
            Console.Write(new string('*', symbols));
            Console.Write(new string('.', dots));
            dots++;
            Console.WriteLine();
        }
        dots--;
        symbols = 3;
        for (int a = 0; a < n / 2 ; a++)
        {
            dots--;
            Console.Write(new string('.', dots));
            Console.Write(new string('*', symbols));
            Console.Write(new string('.', dots));
            symbols  += 2;

            Console.WriteLine();
        }
    }
}