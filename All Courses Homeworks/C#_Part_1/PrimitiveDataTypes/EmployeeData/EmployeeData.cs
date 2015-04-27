//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//    First name
//    Last name
//    Age (0...100)
//    Gender (m or f)
//    Personal ID number (e.g. 8306112507)
//    Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive 
//data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
    static void Main()
    {

        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 99;
        char gender = 'm';
        long personalID = 8306112507;
        int uniqueEmployeeNumber = 27569999;

        Console.WriteLine("|-----------------------------------------------------------------------|");
        Console.WriteLine(" First name  | Last Name |  Age     | Gender  | Personal ID  | UEN");
        Console.WriteLine("|-----------------------------------------------------------------------|");
        Console.WriteLine(String.Format(" {0,-7}     | {1,-7}   |  {2,-7} | {3,-7} | {4,-12} | {5,-12}", 
            firstName, lastName, age, gender, personalID, uniqueEmployeeNumber));
        Console.WriteLine("|-----------------------------------------------------------------------|");

        //Console.WriteLine("First name: " + firstName);
        //Console.WriteLine("Last name: " + lastName);
        //Console.WriteLine("Age: " + age);
        //Console.WriteLine("Gender: " + gender);
        //Console.WriteLine("Personal ID: " + personalID);
        //Console.WriteLine("Unique Employee Number: " + uniqueEmployeeNumber);
    }
}
