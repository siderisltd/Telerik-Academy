//Problem 11. Extract students by email
//Extract all students that have email in abv.bg.
//Use string methods and LINQ.


using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsByEmail
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            students.Add(Students.gancho);
            students.Add(Students.gosho);
            students.Add(Students.ivan);
            students.Add(Students.pesho);

            List<Students> sortedStudents = students.Where(x => x.Email.Contains("abv.bg") && x.Email.LastIndexOf("abv.bg") == x.Email.Length - 6).ToList();

            foreach (var student in sortedStudents)
            {
                Console.Write(student.FirstName + " " + student.LastName + " ID : {0}", student.GropuNumber);
                Console.WriteLine();
            }
        }
    }
}
