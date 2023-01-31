namespace Lessons.LessonsTopic1Core.Models
{
    public class BaseModel
    {
        /// <summary>
        /// Номер Темы
        /// </summary>
        public int TopicId { get; set; }

        public int TaskId { get; set; }

        public string? TitleTopic { get; set; }

        public string? TaskTitle { get; set; }

        public string? TaskText { get; set; }

        /// <summary>
        /// Выводит на экран номер урока и задание
        /// </summary>
        public void WritelineTask()
        {
            Console.WriteLine();
            Console.WriteLine($"Урок {TopicId}: {TaskTitle}");
            Console.WriteLine($"Задание: {TaskText}");
        }

        public int CheckInputPositiveNumber()
        {
            int number;
            bool isValid;
            do
            {
                Console.WriteLine("Введите неотрицательное число");
                isValid = int.TryParse(Console.ReadLine(), out number);
                if (!isValid)
                {
                    Console.WriteLine("Неверный ввод!!!");
                }
            } while (!isValid || number < 0);
            return number;
        }
    }
}