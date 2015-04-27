using System;

class Program
{
    static void Main()
    {
        string k = Console.ReadLine();
        int number = int.Parse(k);
        string result;

        for (int i = 0; i < 3; i++)
        {
            int lastDigit = number % 10;
            number = number / 10;
            result = lastDigit.ToString() + number.ToString();
            number = int.Parse(result);
        }
        Console.WriteLine(number);
    }
}