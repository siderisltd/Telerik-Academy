using System;

class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int heigth = (width * 2)-1;
        for (int i = 0; i <= heigth / 2; i++)
        {
            for (int a = 0; a < width; a++)
            {
                if (a == i)
                {
                    Console.Write("*");
                    a++;
                }
                if (a < width)
                {
                                    Console.Write(".");
                }
            }
            Console.WriteLine();

        }
        int var = width;
        for (int i = 0; i < heigth / 2; i++)
        {
            if (i + 1 == heigth / 2)
            {
                Console.Write("*");
            }
            for (int a = 0; a < width; a++)
            {
                if (a + 1 < width)
                {
                    Console.Write(".");
                }
                if (a == var - 3)
                {
                    Console.Write("*");
                    var--;
                }
            }
            Console.WriteLine();
        }
    }
}