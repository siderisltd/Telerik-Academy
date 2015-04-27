//Problem 3. Decimal to hexadecimal
//Write a program to convert decimal numbers to their hexadecimal representation.


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //long decNumber = 338583669684;
        long decNumber = long.Parse(Console.ReadLine());
        string result = "";
        int power = 0;
        bool isSmaller = true;
        long digit = 0;
        while (isSmaller) // From here we understand how much characters our number will have
        {
            isSmaller = decNumber > OnPower(16, power);
            power++;
        }
        power--;
        // original output is +1  so we decrease it once to know the correct ammount of characters in our hex num
        //Once we know that we can make a loop and check them !
        for (int i = power - 1; i >= 0; i--)
        {
            digit = (decNumber / OnPower(16, i));
            switch (digit)
            {
                case 10:
                    result += 'A';
                    break;
                case 11:
                    result += 'B';
                    break;
                case 12:
                    result += 'C';
                    break;
                case 13:
                    result += 'D';
                    break;
                case 14:
                    result += 'E';
                    break;
                case 15:
                    result += 'F';
                    break;
                default:
                    result += digit.ToString();
                    break;
            }
            decNumber -= digit * OnPower(16, i); // Refreshing the number

        }
        Console.WriteLine(result);
    }
    public static long OnPower(long number, long power) // Method returning the number X on power Y 
    {
        long result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }
        return result;
    }
}

