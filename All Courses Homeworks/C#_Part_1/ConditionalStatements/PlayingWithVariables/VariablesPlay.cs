//Problem 9. Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
using System;

class VariablesPlay
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\r\n1 --> int\r\n2 --> double\r\n3 -->string ");
        byte input = byte.Parse(Console.ReadLine());
        int intVar;
        double doubleVar;
        string stringVar;
        switch (input)
        {
            case 1:
                Console.WriteLine("Please enter int:");
                intVar = int.Parse(Console.ReadLine());
                intVar += 1;
                Console.WriteLine(intVar);
                break;
            case 2:
                Console.WriteLine("Please enter a double:");
                doubleVar = double.Parse(Console.ReadLine());
                doubleVar += 1;
                Console.WriteLine(doubleVar);
                break;
            case 3:
                Console.WriteLine("Please enter a string:");
                stringVar = Console.ReadLine();
                Console.WriteLine(stringVar + "*");
                break;
            default:
                Console.WriteLine("Incorrect input");
                break;
        }
    }
}
