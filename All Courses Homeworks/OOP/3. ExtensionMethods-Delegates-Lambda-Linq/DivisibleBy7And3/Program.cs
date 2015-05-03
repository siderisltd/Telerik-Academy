//Problem 6. Divisible by 7 and 3
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.


namespace DivisibleBy7And3
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 123, 2134, 4, 324, 24, 2, 342, 4, 324, 324, 324, 324, 234, 32, 42 };

            var divisible = numbers.Where(x => x % 3 == 0 || x % 7 == 0).OrderBy(y => y).ToArray();

            var divisibleLinq =
                from num in numbers
                where num % 3 == 0 || num % 7 == 0
                orderby num
                select num;
            Console.WriteLine("With lambda expression");
            Console.WriteLine();
            foreach (var num in divisible)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine("LINQ");
            Console.WriteLine();
            foreach (var num in divisibleLinq)
            {
                Console.WriteLine(num);
            }

        }
    }
}
