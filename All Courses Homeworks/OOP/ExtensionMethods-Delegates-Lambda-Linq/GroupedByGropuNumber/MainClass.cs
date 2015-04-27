//Problem 16.* Groups
//Create a class Group with properties GroupNumber and DepartmentName.
//Introduce a property GroupNumber in the Student class.
//Extract all students from "Mathematics" department.
//Use the Join operator.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupedByGroupNumber
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
                ivan.FN = 122106;
                ivan.GropuNumber = 2;
                ivan.Tel = "0886758569";
                ivan.Marks.Add("Very Good (5)");
                ivan.Marks.Add("Good (4)");
                ivan.Marks.Add("Excellent (6)");
                ivan.Email = "vankata@yahoo.bg";
                ivan.GroupNumber = 12334;
                ivan.DepartmentName = "Mathematics";
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
                ilian.GroupNumber = 1234534;
                ilian.DepartmentName = "IT";
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
                gosho.GroupNumber = 1234534;
                gosho.DepartmentName = "Mathematics";
            }
            students.Add(ivan);
            students.Add(gosho);
            students.Add(ilian);


            var sortedSt =
                from st in students
                where st.GroupNumber == 1234534
                select new
                {
                    FullName = st.FirstName + " " + st.LastName
                };

            foreach (var student in sortedSt)
            {
                Console.WriteLine(student.FullName);
            }
        }
    }
}