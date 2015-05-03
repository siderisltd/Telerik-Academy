//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, 
//last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintInformation
{
    static void Main()
    {
        Console.Write("Please enter company name : ");
        string companyName = Console.ReadLine();
        Console.Write("Please enter company adress : ");
        string companyAdress = Console.ReadLine();
        Console.Write("Please enter company phone number : ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Please enter company fax number : ");
        string faxNumber = Console.ReadLine();
        Console.Write("Please enter company web page : ");
        string companyWebPage = Console.ReadLine();
        Console.Write("Please enter company Manager first name : ");
        string companyManagerFirstName = Console.ReadLine();
        Console.Write("Please enter company Manager last name : ");
        string companyManagerLastName = Console.ReadLine();
        Console.Write("Please enter company Manager age : ");
        int companyManagerAge = int.Parse(Console.ReadLine());
        Console.Write("Please enter company Manager phone number : ");
        string companyManagerPhone = Console.ReadLine();


        Console.WriteLine(companyName);
        Console.WriteLine("Adress:" + companyAdress);
         Console.WriteLine("Tel:"+ String.Format("{0:(###) ###-####}",phoneNumber));
        Console.WriteLine("Fax:"+ String.Format("{0:(###) ###-####}",faxNumber));
        Console.WriteLine("Web site:" + companyWebPage);
        Console.WriteLine("Manager:" + companyManagerFirstName + " " + 
            companyManagerLastName + "(age:" + companyManagerAge + "," + "tel." +
             String.Format("{0:(###) ###-####}", companyManagerPhone + ")"));




    }
}
