//Problem 15.* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your age : ");
        int currentAge = int.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be : {0} years old", currentAge + 10);

    }
}