//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class BitwiseExtraction
{
    static void Main()
    {
        int number = 15;

        //Console.WriteLine(Convert.ToString(number,2).PadLeft(32,'0'));

        int mask = 1;
        int position = 3;
        mask = mask << position;
        int result = mask & number;
        result = result >> position;
        Console.WriteLine("The bit on 3rd position is : " + result);
    }
}