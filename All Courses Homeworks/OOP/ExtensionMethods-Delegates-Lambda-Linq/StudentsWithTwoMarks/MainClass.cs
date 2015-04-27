//Problem 13. Extract students by marks
//Select all students that have at least one mark Excellent (6) into a new anonymous class that
//has properties – FullName and Marks.
//Use LINQ.


using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentsWithTwoMarks
{
    class MainClass
    {
        static void Main()
        {
            List<Students> students = new List<Students>();
            Students ivan = new Students();
            {
                ivan.FirstName = "Ivan";
                ivan.LastName = "Ganchev";
                ivan.FN = 1221;
                ivan.GropuNumber = 2;
                ivan.Tel = "0886758569";
                ivan.Marks.Add("Very Good (5)");
                ivan.Marks.Add("Good (4)");
                ivan.Email = "vankata@yahoo.bg";
            }
            Students ilian = new Students();
            {
                ilian.FirstName = "Ilian";
                ilian.LastName = "Ganchev";
                ilian.FN = 1221;
                ilian.GropuNumber = 2;
                ilian.Tel = "0886758569";
                ilian.Marks.Add("Excellent (6)");
                ilian.Marks.Add("Very Good (5)");
                ilian.Marks.Add("Good (4)");
                ilian.Marks.Add("Excellent (6)");
                ilian.Email = "vankata@yahoo.bg";
            }
            Students gosho = new Students();
            {
                gosho.FirstName = "Georgi";
                gosho.LastName = "Gogov";
                gosho.FN = 2323;
                gosho.GropuNumber = 1;
                gosho.Tel = "08867343559";
                gosho.Marks.Add("Good (4)");
                gosho.Marks.Add("Very Good (5)");
                gosho.Marks.Add("Very Good (5)");
                gosho.Marks.Add("Good (4)");
                gosho.Email = "gogo@yahoo.bg";
            }
            students.Add(ivan);
            students.Add(gosho);
            students.Add(ilian);

            var sortedSt =
                from st in students
                where st.Marks.Count() == 2
                select new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = string.Join(" ", st.Marks)
                };

            foreach (var student in sortedSt)
            {
                Console.Write(student.FullName + "  Marks : ");
                Console.WriteLine(student.Marks);
            }
        }
    }
}
