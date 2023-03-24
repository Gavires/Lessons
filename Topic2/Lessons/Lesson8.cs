using Lessons.LessonsTopic1Core.Models;

namespace Lessons.Topic2.Lessons
{
    public class Lesson8 : BaseModel
    {
        private int[] IntMass { get; set; } = { 1, 3, 4, 2, 5, 6, 0, 8 };

        private int LengthMass { get; set; }

        public Lesson8() : base()
        {
            TopicId = 8;
            TitleLesson = "Создание двумерного массива и работа с ним. Практика.\n";
            TitleTask = "Решить практические задания из видео лекции использовав свое решение.\n";
            TextTask = "Задача 8.1: Вывести элементы массива на экран.\n" +
                       "Задача 8.2: Вывести элементы массива на экран в обратном порядке.\n";
            LengthMass = IntMass.Length;
        }

        public void OutputSolutionOfTask8()
        {
            WritelineTask();
            Console.WriteLine("Задание 8.1: результат:");
            WriteLineMassNormal(IntMass);
            Console.WriteLine("Задание 8.2: результат:");
            WriteLineMassNegative(IntMass);
        }

        private void WriteLineMassNormal(int[] intMass)
        {
            for (var i = 0; i < LengthMass; i++)
            {
                Console.WriteLine($"\t\t\t{intMass[i]}");
            }
        }

        private void WriteLineMassNegative(int[] intMass)
        {
            for (var i = LengthMass - 1; i >= 0; i--)
            {
                Console.WriteLine($"\t\t\t{intMass[i]}");
            }
        }
    }
}
