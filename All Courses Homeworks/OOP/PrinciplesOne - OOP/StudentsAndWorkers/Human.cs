using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public abstract class Human
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Human()
        {

        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

    }
}
