//Problem 5. Larger than neighbours
//Write a method that checks if the element at given position in given array of 
//integers is larger than its two neighbours (when such exist).


using System;

namespace CheckPosition
{

    class Test
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 7, 4, 2, 4 };
            int position = int.Parse(Console.ReadLine());

            bool check = CheckArrAtPosition(array, position);

            Console.WriteLine(check);
        }

        public static bool CheckArrAtPosition(int[] array, int position)
        {
            bool check = false;
            // With this piece of code we check if there is no such a position it will cause IndexOutOfRangeException
            // if this exception is thrown it will return the boolean value of check
            try
            {
                if (array[position] > array[position + 1] && array[position] > array[position - 1])
                {
                    check = true;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return check;

            }
            return check;
        }
    }
}
