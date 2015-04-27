using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        long transformationsCounter = 0;
        string num = Console.ReadLine();
        fuckYou:
        BigInteger product = 1;
        List<BigInteger> sums = new List<BigInteger>();
        bool check = false;

        for (int i = 0; i <= num.ToString().Length; i++)
        {
            BigInteger sum = 0;
            BigInteger currentDigit = new long();
            // zapochvame s mahane na poslednata cifra v dqsno 
            BigInteger number = BigInteger.Parse(num);
            number /= 10;
            num = number.ToString();

            //kakvito i kalkulacii se pravqt s number i posle gi priravnqvam s num
            if (i == num.ToString().Length)
            {
                check = true;
            }
            // kalkulirame sumata na chetnite pozicii startnati ot 0 i broim ot lqvo na dqsno
            for (int j = 0; j < num.ToString().Length; j++)
            {
                if (j % 2 == 0)
                {
                    currentDigit = BigInteger.Parse(num[j].ToString());
                 if (currentDigit != 0)
                {
                    sum += currentDigit;
                }
                }
                else
                {

                }
            }
            // tupchem gi v lista sum
            if (sum != 0)
            {
                sums.Add(sum);
            }

            // proverka dali e edna cifra ostanala i ako e ostanala i = 5 slagame i to si izliza avtomatichno
            if (i != num.ToString().Length)
            {
                i = 0;
            }
            if (check == true)
            {
                break;
            }
        }

        // posle edin foreach cikul da obiloli lista ot long i da namerim sumata na chislata 
        foreach (var item in sums)
        {
            product *= item;
        }

        // sled cikula uvelichavame countera na interaciite
        transformationsCounter++;

        // proverka, ako chisloto e s edna cifra spirame i vadim 1.transformaciite  2.rezultata
        if (product == 0 || product == 1 || product == 2 || product == 3 || product == 4 || product == 5 || product == 6 || product == 7 || product == 8 || product == 9 )
        {
            Console.WriteLine(transformationsCounter);
            Console.WriteLine(product);
        }

        else if (transformationsCounter == 10)
        {
            Console.WriteLine(product);
        }
        
        else if (transformationsCounter < 10)
        {
            num = product.ToString();
            goto fuckYou;
        }

        // a ako ne e s edna cifra i transformaciite sa po malko /ili ravno ne se znae/ ot 10tata transformaciq 
        //vzema novo chislo i zapochva 

       
    }
}
