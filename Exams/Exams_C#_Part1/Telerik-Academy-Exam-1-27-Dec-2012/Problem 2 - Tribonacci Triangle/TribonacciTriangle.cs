using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger T1 = BigInteger.Parse(Console.ReadLine());
        BigInteger T2 = BigInteger.Parse(Console.ReadLine());
        BigInteger T3 = BigInteger.Parse(Console.ReadLine());
        BigInteger L = BigInteger.Parse(Console.ReadLine());
        BigInteger member = 0;
        if (L > 1)
        {
            if (L == 2)
            {
                Console.WriteLine("{0}", T1);
                Console.WriteLine("{0}" + " " + "{1}", T2, T3);
            }
            if (L >= 3)
            {
                Console.WriteLine("{0}", T1);
                Console.WriteLine("{0}" + " " + "{1}", T2, T3);
            }

            for (int i = 0; i < L - 2; i++)
            {
                for (BigInteger a = 0; a <= i + 2; a++)
                {

                    BigInteger temp = T1;
                    T1 = T2;
                    T2 = temp + T2;
                    BigInteger temp2 = T2; // 1
                    T2 = T3;
                    T3 = temp2 + T2;
                    member = T3;
                    Console.Write(member + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Error can't be less than 1");
            return;
        }
    }
}