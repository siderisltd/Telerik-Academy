using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSpaces = n - 1;
        int topDots = n;
        int eks = 1;
        int topSlashes = n - 2;

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string(' ',leftSpaces));
            Console.Write(new string(':', topDots));
            leftSpaces--;
            topDots = 1;
            if (i != 0)
            {
                    Console.Write(new string('/', topSlashes));
                    Console.Write(new string(':', topDots));

            }
            if (i == 1)
            {
                Console.Write(':');
            }
            if (i > 1)
            {
                Console.Write(new string('X', eks));
                Console.Write(':');
                eks++;
            }
            Console.WriteLine();
        }
        topDots = n;
        leftSpaces = n - 2;
        topDots--;
        for (int i = 0; i < n; i++)
        {
            Console.Write(':');
            if (i == 0 || i == n-1)
            {
                Console.Write(new string(':', topDots));
            }
            else
            {
                Console.Write(new string(' ', topDots - 1));
                Console.Write(':');
            }
            if (eks != 0)
            {
              Console.Write(new string('X', eks));
              eks--;
            }
            if (i != n-1)
            {
                Console.Write(':');
            }
            Console.WriteLine();
        }
    }
}