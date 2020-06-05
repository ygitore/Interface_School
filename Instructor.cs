using System;
using System.Collections.Generic;

namespace School
{
    // An Instructor IS A Person, a Learner and a Teacher
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
            foreach (Lesson lesson in _lessons)
            {
                Console.WriteLine(lesson);
            }
        }
        public void Teach(Lesson lesson, ILearner learner)
        {
            learner.Learn(lesson);
        }
    }
}