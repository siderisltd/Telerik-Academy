//Problem 4. Age range
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.


using System;
using System.Collections.Generic;
using System.Linq;

namespace AgeRange
{
    class AgeRange
    {
        static void Main()
        {
            var students = new[] 
            {
                new {FirstName = "Ivan" , LastName = "Goshov", Age = 15},
                new {FirstName = "Ivan" , LastName = "Penev", Age = 18},
                new {FirstName = "Aleksandur" , LastName = "Malinov", Age = 21},
                new {FirstName = "Gosho" , LastName = "Petkov", Age = 22},
                new {FirstName = "Gancho" , LastName = "Slavov", Age = 12},
                new {FirstName = "Ivan" , LastName = "Aleksiev", Age = 11},
                new {FirstName = "Gancho" , LastName = "Shishkov", Age = 14},
            };

            var sorted = students.Where(x => x.Age >= 18 && x.Age <= 24);

            foreach (var student in sorted)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
