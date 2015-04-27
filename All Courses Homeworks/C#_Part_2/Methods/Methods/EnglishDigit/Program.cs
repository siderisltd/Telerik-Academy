//Problem 3. English digit
//Write a method that returns the last digit of given integer as an English word.


using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string digit = EnglishDigit(number);
        Console.WriteLine(digit);
    }

    private static string EnglishDigit(int number)
    {
        string digit = "";
        int digitInt = number % 10;
        switch (digitInt)
        {
            case 1:
                digit = "one";
        break;
            case 2:
        digit = "two";
        break;
            case 3:
        digit = "three";
        break;
            case 4:
        digit = "four";
        break;
            case 5:
        digit = "five";
        break;
            case 6:
        digit = "six";
        break;
            case 7:
        digit = "seven";
        break;
            case 8:
        digit = "eight";
        break;
            case 9:
        digit = "nine";
        break;
        }
        return digit;
    }
}

