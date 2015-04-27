//Problem 5. Order students
//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first 
//name and last name in descending order.
//Rewrite the same with LINQ.

namespace OrderStudents
{
    using System;
    using System.Linq;

    class LinqQuery
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
            //With Lambda expression

            //var sorted = students.OrderByDescending(x => x.FirstName).ThenByDescending(y => y.LastName);

            //With Linq

            var sorted =
                from st in students
                orderby st.FirstName descending, st.LastName descending
                select st;


            foreach (var student in sorted)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
