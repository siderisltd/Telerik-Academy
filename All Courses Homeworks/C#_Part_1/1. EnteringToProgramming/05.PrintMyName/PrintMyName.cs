//Problem 5. Print Your Name
//Modify the previous application to print your name.
//Ensure you have named the application well (e.g. “PrintMyName”).
//You should submit a separate project Visual Studio project holding the PrintMyName class as part of your homework.

using System;

class PrintMyName
{
    static void Main()
    {
        Console.Write("What is your name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Printing your name : {0}",name);
    }
}
