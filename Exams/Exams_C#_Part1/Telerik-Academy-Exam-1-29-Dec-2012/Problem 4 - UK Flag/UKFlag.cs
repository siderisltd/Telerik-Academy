using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int symbol = 1;
        int outerdots = 0;
        int innerdots = (n - 3) / 2;
        if (n % 2 != 0)
        {
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', outerdots));
                Console.Write(new string('\\', symbol));
                Console.Write(new string('.', innerdots));
                Console.Write("|");
                Console.Write(new string('.', innerdots));
                Console.Write(new string('/', symbol));
                Console.Write(new string('.', outerdots));
                outerdots++;
                innerdots--;
                Console.WriteLine();
            }
            Console.Write(new string('-', n / 2));
            Console.Write("*");
            Console.WriteLine(new string('-', n / 2));
            outerdots = 0;
            innerdots = (n - 3) / 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', innerdots));
                Console.Write(new string('/', symbol));
                Console.Write(new string('.', outerdots));
                Console.Write("|");
                Console.Write(new string('.', outerdots));
                Console.Write(new string('\\', symbol));
                Console.Write(new string('.', innerdots));
                outerdots++;
                innerdots--;
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("N must be ODD!!!");
        }
    }
}