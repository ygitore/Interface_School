using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("School Days");
            Console.WriteLine();

            List<Student> students = GetStudents();
            List<Instructor> instructors = GetInstructors();
            List<Lesson> lessons = GetLessons();

            List<ILearner> allLearners = new List<ILearner>();
            foreach (Student student in students)
            {
                allLearners.Add(student);
            }
            foreach (Instructor instructor in instructors)
            {
                allLearners.Add(instructor);
            }

            Instructor anInstructor = instructors[0];
            foreach (Lesson aLesson in lessons)
            {
                foreach (ILearner learner in allLearners)
                {
                    anInstructor.Teach(aLesson, learner);
                }
            }

            foreach (ILearner learner in allLearners)
            {
                learner.PrintKnowledge();
            }

            Student firstStudent = students[0];
            List<ILearner> learners = new List<ILearner>();
            learners.Add(anInstructor);
            learners.Add(firstStudent);

            IEnumerable<ITeacher> teachers = new List<ITeacher>();
        }

        static List<Student> GetStudents()
        {
            return new List<Student>() {
                new Student() {
                    FirstName = "Betty",
                    LastName = "Nelson",
                    BirthDay = new DateTime(1990, 8, 8),
                    Cohort = "Cohort 4"
                },
                new Student() {
                    FirstName = "Roger",
                    LastName = "Wilson",
                    BirthDay = new DateTime(2000, 2, 28),
                    Cohort = "Cohort 20"
                },
                new Student() {
                    FirstName = "Jameka",
                    LastName = "Anderson",
                    BirthDay = new DateTime(1996, 3, 10),
                    Cohort = "Cohort 15"
                },
            };
        }

        static List<Instructor> GetInstructors()
        {
            return new List<Instructor>() {
                new Instructor()
                {
                    FirstName = "Lester",
                    LastName = "Marteen",
                    BirthDay = new DateTime(1986, 1, 30),
                    Specialty = "C#",
                    Salary = 1_000_000
                },
                new Instructor()
                {
                    FirstName = "Kira",
                    LastName = "Harima",
                    BirthDay = new DateTime(1978, 10, 31),
                    Specialty = "SQL",
                    Salary = 770_000
                }
            };
        }

        static List<Lesson> GetLessons()
        {
            return new List<Lesson>() {
                new Lesson() {
                    Topic = "Inheritance",
                    Content = "a way to share logic between classes"
                },
                new Lesson() {
                    Topic = "SELECT Statement",
                    Content = "A SQL command used to query data"
                },
                new Lesson() {
                    Topic = "foreach loop",
                    Content = "A loop for iterating over collections"
                },
                new Lesson() {
                    Topic = "Relational Database",
                    Content = "A data storage tool that keeps data in grids called 'Tables'"
                }
            };
        }
    }
}
