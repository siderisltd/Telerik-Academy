//Problem 12. Extract students by phone
//Extract all students with phones in Sofia.
//Use LINQ.

using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsByPhone
{
    class MainClass
    {
        static void Main()
        {
            List<Students> students = new List<Students>();
            students.Add(Students.gancho);
            students.Add(Students.gosho);
            students.Add(Students.ivan);
            students.Add(Students.pesho);

            var sortedStudents = students.Where(x => x.Tel.IndexOf("02/") == 0);


            foreach (var student in sortedStudents)
            {
                Console.Write(student.FirstName + " " + student.LastName + " Phone : {0}", student.Tel);
                Console.WriteLine();
            }
        }
    }
}
