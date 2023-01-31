using Lessons.Topic1.Lessons;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lesson1 = new Lesson1();
            lesson1.OutputSolutionOfTask1();

            var lesson2 = new Lesson2();
            lesson2.OutputSolutionOfTask2();

            var lesson3 = new Lesson3();
            lesson3.OutputSolutionOfTask3();
        }
    }
}