using System;
using SchoolInterface;
using System.Collections.Generic;

namespace School
{
    class School
    {
        static void Main()
        {
            var teacher = new Teacher();
            teacher.Name = "Ivan Ganchev";
            teacher.NumberOfExercises = 4;
            teacher.NumberOfLectures = 10;
            teacher.Text = "SomeText";

            var student = new Student();
            student.Name = "Gancho Penev";
            student.UniqueClassNumber = "A723BG";

            List<Person> testList = new List<Person>();
            testList.Add(new Teacher());
            testList.Add(new Student());


        }
    }
}
