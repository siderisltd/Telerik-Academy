using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string num = Console.ReadLine();

        BigInteger number = BigInteger.Parse(num);
        BigInteger n = number;
        
        BigInteger momentResult = 0;
        BigInteger result = 0;
        BigInteger counter = 0;
        for (BigInteger i = 1; i <= num.Length; i++)
        {
            BigInteger lastDigit;
            counter++;
            if (counter % 2 == 0)
            {
                lastDigit = number % 10;
                momentResult = lastDigit * lastDigit * counter;
                number /= 10;
            }
            else
            {
                lastDigit = number % 10;
                momentResult = lastDigit * (counter * counter);
                number /= 10;
            }
            result += momentResult;
        }

        BigInteger macigDigit = result % 10;

        Console.WriteLine(result);
        BigInteger R = result % 26;
        R = R + 1;
        R += 64;
        if (R > 90)
        {
            R = (R + 64) % 90;           
        }
        if (macigDigit<=0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence",n);
            return;
        }
        for (int i = 1; i <= macigDigit; i++)
        {
            char character = (char)R;
            Console.Write(character);
            R++;
            if (R > 90)
            {
                R = (R + 64) % 90;
            }
        }

    }
}