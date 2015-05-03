using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypes
{
    class Person
    {
        private string name;
        object age;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public object Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.age == null)
            {
                this.age = "Unspecified";
            }
            return ("Name : " + this.name + "  Age : " + this.age).ToString();
        }

    }
}
