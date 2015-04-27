//Problem 15.* Bits Exchange
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;


namespace CheckBitAtPosition
{
    class CheckBitAtPosition
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n,2).PadLeft(32,'0'));
            uint mask = 7;
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
            uint firstBits = (n & (mask << 3)) >> 3;
            Console.WriteLine(Convert.ToString(firstBits, 2).PadLeft(32, '0'));
            uint secondBits = (n & (mask << 3)) >> 3;
            Console.WriteLine(Convert.ToString(secondBits, 2).PadLeft(32, '0'));

            n = n & ~(mask << 3);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                n = n & ~(mask << 24);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            n = n | (firstBits << 24);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            n = n | (secondBits << 3);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            Console.WriteLine(n);

        }
    }
}