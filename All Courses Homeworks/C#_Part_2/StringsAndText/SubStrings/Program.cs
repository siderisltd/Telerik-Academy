//Problem 4. Sub-string in text
//Write a program that finds how many times a sub-string is contained in a given text
//(perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. 
//We don't have anything else. inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9

using System;

class Program
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else."+ 
        "inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if ((text[i] == 'I' || text[i] == 'i') &&( text[i + 1] == 'N' || text[i+1] == 'n'))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

