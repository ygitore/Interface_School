using System;
using System.Collections.Generic;

namespace School
{
    // A Student IS A Person, a Learner and a Teacher
    public class Student : Person, ILearner, ITeacher
    {
        private List<Lesson> _lessons = new List<Lesson>();

        public string Cohort { get; set; }

        public void Learn(Lesson lesson)
        {
            _lessons.Add(lesson);
        }

        public void PrintKnowledge()
        {
            Console.WriteLine($"The student, {FirstName} {LastName}, is proud to have learned:");
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