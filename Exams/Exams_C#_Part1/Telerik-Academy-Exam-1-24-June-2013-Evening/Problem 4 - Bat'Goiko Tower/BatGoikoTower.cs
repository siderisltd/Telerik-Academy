using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outerDots = n - 1;
        int innerDots = 0;

            for (int s = 0; s < n; s++)
            {
                if (s == 1 || s == 3 || s == 6 || s == 10 || s == 15 || s == 21 || s == 28 || s == 36)
                {
                    Console.Write(new string('.', outerDots));
                    Console.Write("/");
                    Console.Write(new string('-', innerDots));
                    Console.Write("\\");
                    Console.Write(new string('.', outerDots));
                    outerDots--;
                    innerDots += 2;
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('.', outerDots));
                    Console.Write("/");
                    Console.Write(new string('.', innerDots));
                    Console.Write("\\");
                    Console.Write(new string('.', outerDots));
                    outerDots--;
                    innerDots += 2;
                    Console.WriteLine();
                }

            }

    }
}