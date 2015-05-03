//Problem 9. Student groups
//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.

using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGroup
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

            var sortedStudents = students.Where(x => x.GropuNumber == 2).OrderBy(x => x.FirstName);

            foreach (var student in sortedStudents)
            {
                Console.Write(student.FirstName + " ");
                Console.Write(student.LastName);
                Console.WriteLine(" ID : {0}",student.GropuNumber);
                Console.WriteLine();
            }
        }
    }
}
