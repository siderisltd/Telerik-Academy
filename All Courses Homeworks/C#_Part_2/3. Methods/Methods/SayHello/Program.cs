//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.


using System;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        Console.WriteLine(PrintExpression(name));
    }
    static string PrintExpression(string name)
    {
        name = "Hello, " + name + "!";
        return name;
    }
}

