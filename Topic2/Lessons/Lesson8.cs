using Lessons.LessonsTopic1Core.Models;

namespace Lessons.Topic2.Lessons
{
    public class Lesson8 : BaseModel
    {
        private int[] IntMass { get; set; } = { 1, 2, 3, 4, 5 };

        private int LengthMass { get; set; }

        public Lesson8() : base()
        {
            TopicId = 8;
            TitleLesson = "Создание двумерного массива и работа с ним. Практика.\n";
            TitleTask = "Решить практические задания из видео лекции использовав свое решение.\n";
            TextTask = "Задача 8.1: Вывести элементы массива на экран.\n" +
                       "Задача 8.2: Вывести элементы массива на экран в обратном порядке.\n" +
                       "Задача 8.3: Вывести четные элементы масcива.\n" +
                       "Задача 8.4: Вывести элементы массива с интервалом 2.\n" +
                       "Задача 8.5: Вывводить элементы массива пока не встретится 0.\n" +
                       "Задача 8.6: Создайте массив от 1 до 5,\n" +
                       "добавьте в начало массива '0'. В конец '6'. Удалите '3'.\n";
            LengthMass = IntMass.Length;
        }

        public void OutputSolutionOfTask8()
        {
            WritelineTask();
            Console.WriteLine("Задание 8.1: результат:");
            WriteLineMassNormal(IntMass);
            Console.WriteLine("Задание 8.2: результат:");
            WriteLineMassNegative(IntMass);
            Console.WriteLine("Задание 8.3: результат:");
            WriteLineMassEvenElements(IntMass);
            Console.WriteLine("Задание 8.4: результат:");
            WriteLineMassIntervalsTwo(IntMass);
            Console.WriteLine("Задание 8.5: разультат:");
            WriteLineMassToZero(IntMass);
            Console.WriteLine("Задание 8.6: результат:");
            WriteLineMassNormal(WriteLineMassEdit(IntMass));
        }

        private void WriteLineMassNormal(int[] intMass)
        {
            for (var i = 0; i < intMass.Length; i++)
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

        private void WriteLineMassEvenElements(int[] intMass)
        {
            for (var i = 0; i < LengthMass; i++)
            {
                if (intMass[i] % 2 == 0)
                {
                    Console.WriteLine($"\t\t\t{intMass[i]}");
                }
            }
        }

        private void WriteLineMassIntervalsTwo(int[] intMass)
        {
            for (var i = 0; i < LengthMass; i += 2)
            {
                Console.WriteLine($"\t\t\t{intMass[i]}");
            }
        }

        private void WriteLineMassToZero(int[] intMass)
        {
            for (var i = 0; i < LengthMass; i++)
            {
                if (intMass[i] == 0)
                {
                    break;
                }
                Console.WriteLine($"\t\t\t{intMass[i]}");
            } 
        }

        private int[] WriteLineMassEdit(int[] intMass)
        {
            int[] massRes = new int[intMass.Length + 1];
            massRes[0] = 0;
            massRes[massRes.Length - 1] = 6;
            var j = 1;

            for(var i = 0; i < intMass.Length; i++)
            {
                if (intMass[i] == 3)
                {
                    continue;
                }
                massRes[j++] = intMass[i];
            }
            return massRes;
        }
    }
}
