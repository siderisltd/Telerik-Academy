using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        int sumEven = 0;
        int sumOdd = 0;
        if (n < 0)
        {
            n *= -1;
        }
        while (n != 0)
        {
            int digit = (int)(n % 10);
            n /= 10;
            if (digit % 2 == 0)
            {
                sumEven += digit;
            }
            else
            {
                sumOdd += digit;
            }
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("straight {0}",sumEven);
        }
        else if (sumEven < sumOdd)
        {
            Console.WriteLine("left {0}", sumOdd);
        }
        else if (sumOdd < sumEven)
        {
            Console.WriteLine("right {0}",sumEven);
        }
    }
}
