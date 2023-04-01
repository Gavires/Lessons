using Lessons.LessonsTopic1Core.Models;

namespace Lessons.Topic2.Lessons
{
    public class Lesson9 : BaseModel
    {
        private int[] Mass = { 1, 3, 2, 56, 32, 11, 15, 46, 22 };

        public Lesson9() : base()
        {
            TopicId = 9;
            TitleLesson = "Создание двумерного массива и работа с ним. Практика.\n";
            TitleTask = "Решить практические задания из видео лекции использовав свое решение.\n";
            TextTask = "Задача 9.1: Дан массив целых чисел, одномерный.\n" +
                                    "Создать из них два массива: четный и нечетный.\n" +
                                    "Отсортировать эти массивы по возрастанию.\n" +
                       "Задача 9.2: Найти разницу между максимальным и минимальным элементами массива\n" +
                       "Задача 9.3: Заполнить массив слуячайными числами от -50 до 50\n" +
                                    "Определить вероятность попадания числа в промежуток от 15 до 15\n";
        }

        public void OutputSolutionOfTask9()
        {
            WritelineTask();
            Console.WriteLine("Задание 9.1: результат:");
            EditMass(Mass);

        }

        private void EditMass(int[] mass)
        {
            ///<summary>Создадим массив с четными элементами </summary>
            var evenMass = new int[mass.Length];
            var j = 0;

            ///<summary>Создадим массив с нечетными элементами </summary>
            var oddMasss = new int[mass.Length];
            var k = 0;

            for (var i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 == 0)
                {
                    evenMass[j] = mass[i];
                    j++;
                }
                else
                {
                    oddMasss[k] = mass[i];
                    k++;
                }
            }
            WriteLineArrayNormal(OrderByArray(TrimArray(evenMass, j)), "Массив четных элементов");
            WriteLineArrayNormal(OrderByArray(TrimArray(oddMasss, k)), "Массив нечетных элементов");
        }

        private int[] TrimArray(int[] massFrom, int length)
        {
            var massTrim = new int[length];
            massTrim = CopyToArray(massFrom, massTrim);
            return massTrim;
        }

        private int[] OrderByArray(int[] mass)
        {
            ///<summary>Стандартная сортировка пузырьком</summary>
            int elem;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        elem = mass[i];
                        mass[i] = mass[j];
                        mass[j] = elem;
                    }
                }
            }
            return mass;
        }
    }
}
