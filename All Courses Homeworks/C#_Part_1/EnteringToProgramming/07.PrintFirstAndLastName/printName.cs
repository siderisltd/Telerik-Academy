//Problem 7. Print First and Last Name
//Create console application that prints your first and last name, each at a separate line.


using System;

class printName
{
    static void Main()
    {
        //Getting information

        Console.Write("What is your first name : ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name : ");
        string lastName = Console.ReadLine();

        //Printing result
        Console.WriteLine(firstName + " " + lastName);
    }
}
