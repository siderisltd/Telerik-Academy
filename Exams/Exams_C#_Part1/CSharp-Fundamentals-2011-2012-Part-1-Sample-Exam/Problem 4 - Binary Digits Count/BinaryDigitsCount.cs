using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long bit = long.Parse(Console.ReadLine());
        long numbersCount = long.Parse(Console.ReadLine());
        long[] numbers = new long[numbersCount];
        for (long i = 0; i < numbers.Length; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        List<long> ones = new List<long>();
        List<long> zeros = new List<long>();
        for (long i = 0; i < numbers.Length; i++)
        {
            long bitone = 0;
            long bitzero = 0;
            long number = numbers[i];
            long counterCycles = 0;
            long temp = number;
            while (temp > 0)
            {
                temp >>= 1;
                counterCycles++;
            }
            for (int counter = 0; counter < counterCycles; counter++)
            {
                long mask = 1;
                mask = (mask << counter);
                long maskandnumber = mask & number;
                long currentBit = maskandnumber >> counter;
                if (currentBit == 1)
                {
                    bitone++;
                }
                if (currentBit == 0)
                {
                    bitzero++;
                }
            }

            ones.Add(bitone);
            zeros.Add(bitzero);
        }

        if (bit == 1)
        {
            foreach (var digits in ones)
            {
                Console.WriteLine(digits);
            }
        }
        else if (bit == 0)
        {
            foreach (var digits in zeros)
            {
                Console.WriteLine(digits);
            }
        }
    }
}