//Problem 1. Square root
//Write a program that reads an integer number and calculates and prints its square root.
//    If the number is invalid or negative, print Invalid number.
//    In all cases finally print Good bye.
//Use try-catch-finally block.

using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                uint number = uint.Parse(Console.ReadLine());
                uint sqrt = number * number;
                Console.WriteLine(sqrt);
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not a digit");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number must be between {0} and {1}", uint.MinValue, uint.MaxValue);
            }
            catch (Exception)
            {
                Console.WriteLine("Fatal error!");
            }
            finally
            {
                Console.WriteLine("Good  bye");
            }
        }
    }
}
