//Problem 5. Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7.


using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if ((number / 100) % 10 == 7)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
