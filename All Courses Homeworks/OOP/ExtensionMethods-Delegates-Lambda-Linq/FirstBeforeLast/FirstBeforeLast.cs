//Problem 3. First before last
//Write a method that from a given array of students finds all students whose first 
//name is before its last name alphabetically.
//Use LINQ query operators.

namespace FirstBeforeLast
{
    using System;
    using System.Linq;

    class FirstBeforeLast
    {
        static void Main()
        {
            var students = new[] 
            {
                new {FirstName = "Ivan" , LastName = "Goshov"},
                new {FirstName = "Ivan" , LastName = "Penev"},
                new {FirstName = "Aleksandur" , LastName = "Malinov"},
                new {FirstName = "Gosho" , LastName = "Petkov"},
                new {FirstName = "Gancho" , LastName = "Slavov"},
                new {FirstName = "Ivan" , LastName = "Aleksiev"},
                new {FirstName = "Gancho" , LastName = "Shishkov"},
            };

            var sorted = students.Where(x => x.FirstName.CompareTo(x.LastName) < 0).OrderBy(y => y.LastName);

             foreach (var student in sorted)
             {
                 Console.WriteLine(student.FirstName + " " + student.LastName);
             }

        }
    }
}
