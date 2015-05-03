using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StudentsAndWorkers
{
    class MainClass
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(320.43m, 7) { Grade = 2, FirstName = "Gancho", LastName = "Aleksiev" });
            students.Add(new Student(220.43m, 5) { Grade = 3, FirstName = "Ivan", LastName = "Kondov" });
            students.Add(new Student(120.43m, 2) { Grade = 4, FirstName = "Pencho", LastName = "Penev" });
            students.Add(new Student(50m, 7) { Grade = 1, FirstName = "Kaloyan", LastName = "Bahnev" });
            students.Add(new Student(110.24m, 2) { Grade = 3, FirstName = "Ivalin", LastName = "Genchev" });
            students.Add(new Student(200.20m, 7) { Grade = 2, FirstName = "Pencho", LastName = "Penchev" });
            students.Add(new Student(124.12m, 4) { Grade = 3, FirstName = "Solomon", LastName = "Hristov" });
            students.Add(new Student(140.43m, 8) { Grade = 2, FirstName = "Petur", LastName = "Velikov" });
            students.Add(new Student(212.23m, 12) { Grade = 3, FirstName = "Stefan", LastName = "Slavchev" });
            students.Add(new Student(160.10m, 7) { Grade = 2, FirstName = "Ciceron", LastName = "Kolev" });

            var sortedStudentsByGrade = students.OrderBy(x => x.Grade);

            List<Student> newStudents = new List<Student>();
            newStudents.Add(new Student("Pencho", "Ganchev", 3, 112.23m, 6));
            newStudents.Add(new Student("Ivan", "Ganchev", 2, 123.43m, 6));
            newStudents.Add(new Student("Iliqn", "Skenderov", 1, 111.43m, 4));
            newStudents.Add(new Student("Kaloqn", "Iliev", 2, 111.43m, 3));
            newStudents.Add(new Student("Elena", "Luybenova", 4, 456.12m, 6));
            newStudents.Add(new Student("Sinan", "Pehlivanov", 1, 99.43m, 2));
            newStudents.Add(new Student("Aleksandur", "Hinkov", 3, 113.43m, 6));
            newStudents.Add(new Student("Stela", "Sandoval", 4, 107.43m, 8));
            newStudents.Add(new Student("Jones", "Ken", 1, 56.20m, 4));
            newStudents.Add(new Student("Jess", "Pitsburg", 2, 123.43m, 3));

            var sortedNewStudensByMoneyPerHour =
                from student in newStudents
                orderby student.MoneyPerHour() descending
                select student;

            var mergedList = new List<Student>();

            foreach (var student in sortedStudentsByGrade)
            {
                mergedList.Add(student);
            }
            foreach (var student in sortedNewStudensByMoneyPerHour)
            {
                mergedList.Add(student);
            }

            var finalSortedList = mergedList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            
            foreach (var student in finalSortedList)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
