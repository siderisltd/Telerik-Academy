//Problem 14. Modify a Bit at Given Position

//    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value 
//v at the position p from the binary representation of n while preserving all other bits in n.



using System;


namespace CheckBitAtPosition
{
    class CheckBitAtPosition
    {
        static void Main()
        {
            Console.Write("Give me number : ");
            int number = int.Parse(Console.ReadLine());
            int newnumber = new int();
            Console.Write("Give me bit value 0 or 1 : ");
            int bitValue = int.Parse(Console.ReadLine());
            while (bitValue != 0 && bitValue != 1)
            {
                Console.Write("Bit value must be 0 or 1 : ");
                bitValue = int.Parse(Console.ReadLine());
            }
            int mask;
            int bitOnPosition;
            Console.Write("Give me position : ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));


            mask = 1;
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
            mask = mask << position;
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
            bitOnPosition = mask & number;
            bitOnPosition = bitOnPosition >> position;
            Console.WriteLine(Convert.ToString(bitOnPosition, 2).PadLeft(32, '0'));

            if (bitOnPosition != bitValue)
            {
                bitOnPosition = bitOnPosition << position;
                newnumber = bitOnPosition ^ number;
                Console.WriteLine("New number result : " + newnumber);
            }
            else if (bitOnPosition == bitValue)
            {
                bitOnPosition = bitOnPosition << position;
                newnumber = bitOnPosition | number;
                Console.WriteLine("New number result : "+ newnumber);
            }

            else
            {
                Console.WriteLine("Something's wrong !");
            }
        }
    }
}