/*Тема 1 Введение в C#, работа с циклами и конструкциями
    * Урок 1 Введение в C#, работа с Visual studio 2022 
*/

using Lessons.LessonsTopic1Core.Models;

namespace Lessons.Topic1.Lessons
{
    public class Lesson1 : BaseModel
    {
        public Lesson1() : base()
        {
            TopicId = 1;
            TitleTask = "Вывести на консоль, какую среду разработки Вы выбрали для прохождения обучения";
            TextTask = "Создать файл с нужным расширением, написать код для вывода на экран.";
        }

        public string Text { get; private set; } = "visual studio 2022";

        /// <summary>
        /// Вывод текста на экран
        /// </summary>
        public void OutputSolutionOfTask1()
        {
            WritelineTask();
            Console.WriteLine($"результат = {Text}");
            Console.ReadKey();
        }
    }
}