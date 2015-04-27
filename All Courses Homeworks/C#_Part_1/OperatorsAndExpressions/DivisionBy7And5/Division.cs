//Problem 3. Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
//by 7 and 5 at the same time.
//Examples:


using System;

class Division
{
    static void Main()
    {
        int imputNumber = int.Parse(Console.ReadLine());

        if (imputNumber % 7 == 0 && imputNumber % 5 == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
