//Problem 15.* Number calculations
//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).


using System;
using System.Collections.Generic;


namespace NumberCalculations
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 6, 7 };
            UniMethod(numbers);
        }
        static List<T> UniMethod<T>(T number)
        {
            
            // TODO
        }
    }
}
