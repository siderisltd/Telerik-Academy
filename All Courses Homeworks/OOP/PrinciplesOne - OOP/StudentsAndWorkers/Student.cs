using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public int Grade { get; set; }

        public Student(decimal weekSalary, int workHoursPerDay)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public Student(string firstName, string lastName, int grade, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.Grade = grade;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public decimal MoneyPerHour()
        {
            return ((this.WeekSalary / this.WorkHoursPerDay) / 5);
        }
    }
}
