//Problem 12. Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class BitwiseExtraction
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
        Console.WriteLine("The bit on {0} position is : {1}",position, result);
    }
}