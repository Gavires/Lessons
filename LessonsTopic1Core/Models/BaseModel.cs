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
            Console.WriteLine($"Задание: {TextTask}");
        }

        public int CheckInputPositiveIntNumber()
        {
            int number;
            bool isValid;
            do
            {
                Console.WriteLine("Введите неотрицательное число");
                isValid = int.TryParse(Console.ReadLine(), out number);
                Valid(isValid);
            } while (!isValid || number < 0);

            return number;
        }

        public double CheckInputValidDoubleNumber()
        {
            double number;
            bool isValid;
            do
            {
                Console.WriteLine("Введите неотрицательное число");
                isValid = double.TryParse(Console.ReadLine(), out number);
                Valid(isValid);
            } while (!isValid || number < 0);

            return number;
        }

        public string CheckInputValidString()
        {
            string str;
            bool isValid;
            do
            {
                str = Console.ReadLine();
                isValid = !string.IsNullOrEmpty(str);
                Valid(isValid);

            } while (!isValid);

            return str;
        }

        private void Valid(bool valid)
        {
            if (!valid)
            {
                Console.WriteLine("Неверный ввод!!!");
            }
        }
    }
}