namespace GroupedByGroupNumberExtension
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
        private Group Group;

        public Students()
        {
            this.Marks = new List<string>();
            this.Group = new Group();
        }

        public int GroupNumber
        {
            get
            {
                return this.Group.GroupNumber;
            }
            set
            {
                this.Group.GroupNumber = value;
            }
        }
        public string DepartmentName
        {
            get
            {
                return this.Group.DepartmentName;
            }
            set
            {
                this.Group.DepartmentName = value;
            }
        }
       
       

     
    }
}