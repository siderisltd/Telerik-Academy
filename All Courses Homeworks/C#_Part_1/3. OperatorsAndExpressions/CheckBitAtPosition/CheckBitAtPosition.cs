//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
//in given integer number n, has value of 1.

using System;


namespace CheckBitAtPosition
{
    class CheckBitAtPosition
    {
        static void Main()
        {
            Console.Write("Give me number : ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Give me position : ");
            int position = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(number,2).PadLeft(32,'0'));

            int mask = 1;
            mask = mask << position;
            int result = mask & number;
            result = result >> position;
            Console.WriteLine("\r\nbit @ p == 1 ?\r\n");
            switch (result)
            {
                case 1:
                    Console.WriteLine("true");
                    break;
                case 0:
                    Console.WriteLine("false");
                    break;
                default:
                    break;
            }
        }
    }
}