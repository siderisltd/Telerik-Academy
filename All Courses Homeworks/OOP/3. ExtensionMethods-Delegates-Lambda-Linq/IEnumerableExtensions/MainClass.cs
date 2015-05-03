//Problem 2. IEnumerable extensions
//Implement a set of extension methods for IEnumerable<T> that implement the following 
//group functions: sum, product, min, max, average.

namespace IEnumerableExtensions
{
    using System;

    internal class MainClass
    {
        private static void Main()
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(arr.Average());
        }
    }
}
