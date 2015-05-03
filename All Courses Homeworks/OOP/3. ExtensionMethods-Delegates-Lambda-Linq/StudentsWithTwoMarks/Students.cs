namespace StudentsWithTwoMarks
{
    using System;
    using System.Collections.Generic;

    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public int GropuNumber { get; set; }
        public List<string> Marks { get; set; }

        public Students()
        {
            this.Marks = new List<string>();
        }

    }
}