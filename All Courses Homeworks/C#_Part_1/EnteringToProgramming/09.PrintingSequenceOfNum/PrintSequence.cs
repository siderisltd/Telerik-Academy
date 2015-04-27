//Problem 9. Print a Sequence
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...


using System;

class PrintSequence
{
    static void Main()
    {
        int numbersToPrint = 10;

        for (int member = 2; member < numbersToPrint + 2; member++)
        {
            if (member % 2 == 0)
            {
                Console.Write(member);
            }
            if (member % 2 != 0)
            {
                Console.Write("-"+member);
            }
            if (member != numbersToPrint + 1)
            {
                Console.Write(",");
            }
            else if (member == numbersToPrint + 1)
            {
                Console.WriteLine();
                Console.ReadLine();
            }
        }

    }
}

