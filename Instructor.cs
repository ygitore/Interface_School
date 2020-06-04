using System;
using System.Collections.Generic;

namespace School
{
    public class Instructor : Person
    {
        public decimal Salary { get; set; }
        public string Specialty { get; set; }

        public void Teach(Lesson lesson, Student student)
        {
            student.Learn(lesson);
        }
    }
}