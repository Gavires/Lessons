/*Тема 1 Введение в C#, работа с циклами и конструкциями
    * Урок 2 Типы данных 
        * Задание: Напишите код, который будет: 
          Складывать два числа 51 и 18
          Вычитать из 132 63
          Умножить 7 на 2
*/

using Lessons.LessonsTopic1Core.Models;

namespace Lessons.Topic1.Lessons
{
    public class Lesson2 : BaseModel
    {
        public Lesson2() : base() 
        {
            TopicId = 2;  
            TaskTitle = "Познакомиться с типами данных.";  
            TaskText = "Напишите код, который будет:";  
        }

        /// <summary>
        /// Возвращает сумму 2 чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int SummNumber(int a, int b) => a + b;

        /// <summary>
        /// Возвращает разницу двух чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int DifferenceNumbers(int a, int b) => a - b;

        /// <summary>
        /// Возвращает разницу двух чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int ProductNumbers(int a, int b) => a * b;

        /// <summary>
        /// Выводит на экран сумму, разницу и произведение 2 чисел
        /// </summary>
        public void OutputSolutionOfTask2()
        {
            WritelineTask();
            Console.WriteLine($"Складывать два числа 51 и 18:\n результат = { SummNumber(51, 18)}");
            Console.WriteLine($"Вычитать из 132 63:\n результат = {DifferenceNumbers(132, 63)}");
            Console.WriteLine($"Умножить 7 на 2:\n результат = {ProductNumbers(7, 2)}");
            Console.ReadKey();
        }
    }
}
