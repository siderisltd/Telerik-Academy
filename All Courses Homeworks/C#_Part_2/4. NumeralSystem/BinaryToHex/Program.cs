//Problem 6. binary to hexadecimal
//Write a program to convert binary numbers to hexadecimal numbers.

using System;

class Program
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        string reversedBinaryNumber = "";
        long result = 0;

        for (int a = binaryNumber.Length; a > 0; a--)  // This reverses the binary number for reading from right to left
        {
            reversedBinaryNumber += binaryNumber[a - 1];
        }

        for (int i = 0; i < binaryNumber.Length; i++)  // For loop to check all digits in the given string
        {
            long currentNumber = long.Parse(reversedBinaryNumber[i].ToString()); //getting the currentNumber as integer
            if (currentNumber != 0)
            {
                result += OnPower(2, i);
            }
        }
        Console.WriteLine(ToHex(result));

    }

    private static string ToHex(long num)
    {
       long decNumber = num;
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