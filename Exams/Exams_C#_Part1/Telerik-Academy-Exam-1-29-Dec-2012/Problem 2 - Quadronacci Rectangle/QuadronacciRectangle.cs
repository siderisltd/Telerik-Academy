using System;

class Program
{
    static void Main()
    {
        long firstNumber = long.Parse(Console.ReadLine());
        long secondNumber =long.Parse(Console.ReadLine());
        long thirdNumber = long.Parse(Console.ReadLine());
        long fourthNumber =long.Parse(Console.ReadLine());
       
        long rows = long.Parse(Console.ReadLine());
        long col = long.Parse(Console.ReadLine());
        long counter = 0;
        Console.Write("{0} {1} {2} {3}", firstNumber, secondNumber, thirdNumber, fourthNumber);
        for (int i = 0; i < rows; i++)
        {
            if (i == 0)
            {
                for (int a = 4; a < col; a++)
                {
                    counter++;
                    long next = firstNumber + secondNumber + thirdNumber + fourthNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = fourthNumber;
                    fourthNumber = next;
                    Console.Write(" "+next);
                }
            }
            else
            {
                for (int a = 0; a < col; a++)
                {
                    counter++;
                    long next = firstNumber + secondNumber + thirdNumber + fourthNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = fourthNumber;
                    fourthNumber = next;
                    if (a == 0)
                    {
                        Console.Write(next);
                    }
                    else
                    {
                        Console.Write(" " + next);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}