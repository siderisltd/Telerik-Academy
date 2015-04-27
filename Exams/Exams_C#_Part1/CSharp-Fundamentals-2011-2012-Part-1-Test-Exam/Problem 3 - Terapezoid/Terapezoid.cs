using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int bottomWidth = n * 2;
        int heigth = n + 1;
        int dotsoninside = n - 1;
        int dotsonoutside = n - 1;
        Console.Write(new string('.',n));
        Console.WriteLine(new string('*', n));
        for (int i = 1; i < heigth - 1; i++)
        {
            Console.Write(new string('.', dotsoninside));
            Console.Write("*");
            Console.Write(new string('.', dotsonoutside));
            Console.Write("*");
            dotsoninside--;
            dotsonoutside++;
            Console.WriteLine();
        }
        Console.WriteLine(new string('*', bottomWidth));

    }
}