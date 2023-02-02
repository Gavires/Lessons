using Lessons.LessonsTopic1Core.Models;

namespace Lessons.Topic1.Lessons
{
    public class Lesson5 : BaseModel
    {
        public Lesson5() : base()
        {
            TopicId = 5;
            TitleLesson = "Циклы\n";
            TitleTask = "Познакомиться с циклами.\n";
            TextTask = "Напиши код, который выведет числа от 0 до 20, но только нечётные числа.";
        }

        public void OutputSolutionOfTask5()
        {
            WritelineTask();
            Console.WriteLine("результат:");
            OutputOddNumbers();

        }

        private void OutputOddNumbers()
        {
            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
