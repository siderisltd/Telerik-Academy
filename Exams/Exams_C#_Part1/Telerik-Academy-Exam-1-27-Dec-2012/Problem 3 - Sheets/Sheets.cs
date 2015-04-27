using System;
class Sheets
{
    static void Main()
    {
        ushort N = ushort.Parse(Console.ReadLine());
        if (N < 1024)
        {
            Console.WriteLine("A0");
        }
        if (N == 1024 || N > 1024)
        {
            N -= 1024;
        }
        if (N < 512)
        {
            Console.WriteLine("A1");
        }
        if (N == 512 || N > 512)
        {
            N -= 512;
        }
        if (N < 256)
        {
            Console.WriteLine("A2");
        }
        if (N == 256 || N > 256)
        {
            N -= 256;
        }
        if (N < 128)
        {
            Console.WriteLine("A3");
        }
        if (N == 128 || N > 128)
        {
            N -= 128;
        }
        if (N < 64)
        {
            Console.WriteLine("A4");
        }
        if (N == 64 || N > 64)
        {
            N -= 64;
        }
        if (N < 32)
        {
            Console.WriteLine("A5");
        }
        if (N == 32 || N> 32)
        {
            N -= 32;
        }
        if (N < 16)
        {
            Console.WriteLine("A6");
        }
        if (N == 16 || N> 16)
        {
            N -= 16;
        }
        if (N < 8)
        {
            Console.WriteLine("A7");
        }
        if (N == 8 || N> 8)
        {
            N -= 8;
        }
        if (N < 4)
        {
            Console.WriteLine("A8");
        }
        if (N == 4 || N> 4)
        {
            N -= 4;
        }
        if (N < 2)
        {
            Console.WriteLine("A9");
        }
        if (N == 2 || N> 2)
        {
            N -= 2;
        }
        if (N < 1)
        {
            Console.WriteLine("A10");
        }
        if (N == 1 || N> 1)
        {
            N -= 1;
        }
    }
}