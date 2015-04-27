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

        BigInteger N = BigInteger.Parse(Console.ReadLine());

        BigInteger member = 0;

        if (N > 3)

        {

            for (int i = 0; i < N - 3; i++)

            {

                BigInteger temp = T1;

                T1 = T2;

                T2 = temp + T2;

                BigInteger temp2 = T2; // 1

                T2 = T3;

                T3 = temp2 + T2;

                member = T3;

            }

        }

        else if (N == 1)

        {

            member = T1;

        }

        else if (N == 2)

        {

            member = T2;

        }

        else if (N == 3)

        {

            member = T3;

        }

        Console.WriteLine(member);

 

    }