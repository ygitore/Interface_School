namespace School
{
    public class Lesson
    {
        public string Topic { get; set; }
        public string Content { get; set; }

        // When you call Console.WriteLine() this ToString() method will be executed
        public override string ToString()
        {
            return Topic;
        }
    }
}