using System;

class Program
{
    static void Main()
    {
        //input
        string input = (Console.ReadLine());
        int digit = new byte();
        int sum = 0;
        int counter = 0;

        for (int i = input.Length - 1; i >= 0 ; i--)
        {
            if (int.TryParse(Convert.ToString(input[i]), out digit) && i % 2 == 1)
            {
                sum += digit;
                counter++;
            }
        }
        Console.WriteLine("{0} {1}",counter,sum);
    }
}
