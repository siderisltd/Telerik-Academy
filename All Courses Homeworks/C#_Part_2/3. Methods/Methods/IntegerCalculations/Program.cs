//Problem 14. Integer calculations
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] {' ', ',' },StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        Console.WriteLine("Minimal = "+ Minimum(numbers)+"\n\rMaximum = "+
            Maximum(numbers) + "\n\rAverage = " + Average(numbers) + "\n\rSum = " +
            Sum(numbers) + "\n\rProduct = " + Product(numbers));
    }

    private static int Product(int[] numbers)
    {
        int product = 1;
        foreach (var num in numbers)
        {
            product *= num;
        }
        return product;
    }

    private static int Sum(int[] numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    private static float Average(int[] numbers)
    {
        float average = 0;

        foreach (var num in numbers)
        {
            average += num;
        }
        average /= 2;

        return average;
    }

    private static int Maximum(int[] numbers)
    {
        int maximum = int.MinValue;

        foreach (var num in numbers)
        {
            if (num > maximum)
            {
                maximum = num;
            }
        }

        return maximum;
    }

    private static int Minimum(int[] numbers)
    {
        int minimum = int.MaxValue;

        foreach (var num in numbers)
        {
            if (num < minimum)
            {
                minimum = num;
            }
        }

        return minimum;
    }
}
