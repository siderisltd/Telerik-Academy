//Problem 5. Boolean Variable
//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console.


using System;

class Program
{
    static void Main()
    {
        bool isFemale = false;

        Console.WriteLine("Are you female ? ... press (1) for yes (2) for no\r\n");
        
        // I use the ConsoleKeyInfo class and create instance and read the key that is pressed

        ConsoleKeyInfo keyPressed = Console.ReadKey();
        Console.WriteLine();

        //If the key is equal to 1 or 2 this determines your gender

        if (keyPressed.Key == ConsoleKey.D1)
        {
            isFemale = true;
            Console.WriteLine("YOU ARE FEMALE - " + isFemale);
        }
        if (keyPressed.Key != ConsoleKey.D1 && keyPressed.Key != ConsoleKey.D2)
        {
            Console.WriteLine("WRONG KEY TRY WITH 1 OR 2 ONLY !");
        }
        else if (keyPressed.Key == ConsoleKey.D2)
        {
            Console.WriteLine("YOU ARE FEMALE - " + isFemale);
        }
    }
}
