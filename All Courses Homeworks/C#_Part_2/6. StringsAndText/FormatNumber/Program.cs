//Problem 11. Format number
//Write a program that reads a number and prints it as a decimal 
//number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.


using System;
using System.Linq;
using System.Text;

namespace FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            long number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15} : {1}","Decimal",number);
            Console.WriteLine("{0,15} : {1}","Hex", ToHex(number));
            int percentage = (int)number;
            if (percentage >= 100)
            {
                percentage = 100;
            }
            Console.WriteLine("{0,15} : {1:P}","Percentage", number);
            Console.WriteLine("{0,15} : {1:E}","Scientific notation",number);
        }
        public static string ToHex(long decNumber)
        {
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
            return result;
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
}
