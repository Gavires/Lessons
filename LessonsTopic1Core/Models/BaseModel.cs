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

        public string? TitleLesson { get; set; }

        public string? TitleTask { get; set; }

        public string? TextTask { get; set; }

        /// <summary>
        /// Выводит на экран номер урока и задание
        /// </summary>
        public void WritelineTask()
        {
            Console.WriteLine();
            Console.WriteLine($"Урок {TopicId}: {TitleTask}");
            Console.WriteLine($"Задание: \n{TextTask}");
        }
    }
}