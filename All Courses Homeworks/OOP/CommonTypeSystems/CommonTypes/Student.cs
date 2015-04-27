namespace CommonTypes
{
    using System;
    using System.Linq;

    #region enumerations
    public enum Specialities
    {
        IT,
        ComputerScience,
        BulgarianLingwistigs,
        AmericanSucking,
        PublicFucking
    }
    public enum Universities
    {
        NBU,
        SU,
        VTU,
        MTM,
        Telerik,
        SoftUni
    }
    public enum Faculties
    {
        BaseFaculty,
        MainCorpus,
        FacultyOfEngineering
    }
    #endregion enumerations

    public class Student : ICloneable , IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public Specialities Speciality { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }

        //Equals(), ToString(), GetHashCode() and operators == and !=.

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Clone()
        {
            var newStudent = new Student();
            newStudent.Address = this.Address;
            newStudent.Course = this.Course;
            newStudent.Email = this.Email;
            newStudent.Faculty = this.Faculty;
            newStudent.FirstName = this.FirstName;
            newStudent.LastName = this.LastName;
            newStudent.MiddleName = this.MiddleName;
            newStudent.MobilePhone = this.MobilePhone;
            newStudent.Speciality = this.Speciality;
            newStudent.SSN = this.SSN;
            newStudent.University = this.University;
            return newStudent;
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName.CompareTo(otherStudent.FirstName) > 0)
            {
                return 1;
            }
            else if (this.FirstName.CompareTo(otherStudent.FirstName) < 0)
            {
                return -1;
            }
            else if (this.FirstName.CompareTo(otherStudent.FirstName) == 0)
            {
                if (this.SSN.CompareTo(otherStudent.SSN) < 0)
                {
                    return -1;
                }
                else if (this.SSN.CompareTo(otherStudent.SSN) > 0)
                {
                    return 1;
                }
                else if (this.SSN.CompareTo(otherStudent.SSN) == 0)
                {
                    return 0;
                }
            }
            throw new FieldAccessException();
            
        }
    }
}
