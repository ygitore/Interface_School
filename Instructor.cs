using System;
using System.Collections.Generic;

namespace School
{
    public class Instructor : Person, ILearner, ITeacher
    {
        private List<Lesson> _lessons = new List<Lesson>();
        public decimal Salary { get; set; }
        public string Specialty { get; set; }

        public void Learn(Lesson lesson)
        {
            _lessons.Add(lesson);
        }

        public void PrintKnowledge()
        {
            Console.WriteLine($"Instructor, {FirstName} {LastName}, has learned:");
            foreach (Lesson lesson in _lessons)
            {
                Console.WriteLine(lesson);
            }
            Console.WriteLine();
        }

        public void Teach(Lesson lesson, ILearner learner)
        {
            learner.Learn(lesson);
        }
    }
}