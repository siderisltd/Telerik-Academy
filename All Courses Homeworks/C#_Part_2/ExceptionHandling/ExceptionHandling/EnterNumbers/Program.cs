//Problem 2. Enter numbers
//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//    If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;
using System.Collections.Generic;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static List<int> numbers = new List<int>();

        static void Main()
        {
            int start = 1;
            int end = 100;
            Console.WriteLine("If you want to enter 10 numbers enter ([Y]) otherways you will enter one number");
            string moreNumbers = Console.ReadLine();
            int numbersToEnter = 1;
            if (moreNumbers == "Y" || moreNumbers == "y" )
            {
                numbersToEnter = 10;
            }
            ReadNumber(start,end,numbersToEnter);
            Console.Write("Numbers entered :");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        private static void ReadNumber(int start, int end, int numbersToEnter)
        {
            string num = string.Empty;
            int number = -1;
            for (int i = 1; i <= numbersToEnter; i++)
            {
                Console.WriteLine("Enter number between {0} and {1}", start, end);
                num = Console.ReadLine();
                bool isParse = int.TryParse(num, out number);
                if (isParse)
                {
                    number = int.Parse(num);
                }
                if ((number > start && number < end) && isParse)
                {
                    start = number;
                    Console.WriteLine("Correct number !");
                    numbers.Add(number);
                }
                if ((number < start || number > end) && isParse)
                {
                    throw new ArgumentOutOfRangeException("Number must be between start and end");
                }
                else if (isParse == false)
                {
                    throw new FormatException("This is not a digit");
                }
            }
        }
    }
}
