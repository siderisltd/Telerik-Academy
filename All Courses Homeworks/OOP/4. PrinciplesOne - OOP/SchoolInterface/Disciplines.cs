using System;

namespace SchoolInterface
{
    public abstract class Disciplines : Person
    {
         public int NumberOfLectures { get; set; }
         public int NumberOfExercises { get; set; }
    }
}
