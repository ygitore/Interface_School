using System;

namespace School
{
    public class Lesson
    {
        public string Topic { get; set; }
        public string Content { get; set; }

        public override string ToString()
        {
            return Topic;
        }
    }
}