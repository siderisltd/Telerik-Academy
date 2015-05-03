//Problem 10. Student groups extensions
//Implement the previous using the same query expressed with extension methods.

using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentGroupExtensions
{
    static class MainClass
    {
        static void Main()
        {
            List<Students> students = new List<Students>();
            students.Add(Students.gancho);
            students.Add(Students.gosho);
            students.Add(Students.ivan);
            students.Add(Students.pesho);
            List<Students> SortedStudents = SortByGroupNumber(students);

            foreach (var student in SortedStudents)
            {
                Console.Write(student.FirstName + " " + student.LastName + " ID : {0}", student.GropuNumber);
                Console.WriteLine();
            }

        }
        public static List<Students> SortByGroupNumber(this List<Students> list)
        {
            List<Students> newList = new List<Students>();
            foreach (var student in list)
            {
                if (student.GropuNumber == 2)
                {
                    newList.Add(student);
                }
            }
            newList = newList.OrderBy(x => x.FirstName).ToList();
            return newList;
        }
    }
}
