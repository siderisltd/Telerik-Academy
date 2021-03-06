﻿
namespace ExtractMarks
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

        public static Students pesho = new Students()
        {
            FirstName = "Pesho",
            LastName = "Peshev",
            FN = 1233,
            GropuNumber = 2,

            Tel = "0993/123/432",
            Email = "pesho@abv.bg",


        };

        public static Students gosho = new Students
        {
            FirstName = "Gosho",
            LastName = "Peshev",
            FN = 1242,
            GropuNumber = 1,
            Tel = "0293/1213/432",
            //Marks = "Mark 2",
            Email = "gosho@gmail.bg",
        };

        public static Students ivan = new Students
        {
            FirstName = "Ivan",
            LastName = "Ganchev",
            FN = 1221,
            GropuNumber = 2,
            Tel = "0886758569",
            //Marks = "Mark 3",
            Email = "vankata@yahoo.bg",
        };

        public static Students gancho = new Students
        {
            FirstName = "Gancho",
            LastName = "Ganchev",
            FN = 1211,
            GropuNumber = 3,
            Tel = "0992234343",
            // Marks = "Mark 4",
            Email = "gancho@abv.bg",

        };
    }
}