//Problem 2. Reverse string
//Write a program that reads a string, reverses it and prints the result at the console.


using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        TextReverse(text);
    }

    private static void TextReverse(string text)
    {
        string result = string.Empty;
        for (int i = text.Length - 1; i >= 0; i--)
        {
            result += text[i];
        }
        Console.WriteLine(result);
    }
}

