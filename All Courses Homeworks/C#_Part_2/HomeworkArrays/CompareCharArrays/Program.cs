//Problem 3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter).


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first char array : ");
        string first = Console.ReadLine();
        Console.Write("Enter second char array : ");
        string second = Console.ReadLine();
        int length = new int();
        int maxLength = new int();
        int next = 0;
        if (first.Length >= second.Length)
        {
            length = second.Length;
            maxLength = first.Length;
        }
        else
        {
            length = first.Length;
            maxLength = second.Length;
        }
        for (int i = 0; i < length; i++)
        {
                if ((first[i] == second[i]))
                {
                    Console.WriteLine("first[{0}] //{1}// = second[{2}] //{3}//", i, first[i], i, second[i]);
                }
                else 
                {
                    Console.WriteLine("first[{0}] //{1}// != second[{2}] //{3}//", i, first[i], i, second[i]);
                }
                next = i;
        }
        for (int i = next; i < maxLength; i++)
        {
            Console.WriteLine("Line - {0} - They are no equal from now on and this is the difference in the characters because one of"+
            "the arrays is larger tham the other",i+1);
        }
    }
}
