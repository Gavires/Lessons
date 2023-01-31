using Lessons.LessonsTopic1Core.Models;

namespace Lessons.Topic1.Lessons
{
    public class Lesson3 : BaseModel
    {
        private string StrIfTrue { get; } = "Всё верно, Вы ученик университета Синергии";

        private string StrIfFalse { get; } = "Вы всё равно молодец";

        private string[] Seasons { get; } = { "Весна", "Лето", "Осень", "Зима" };

        public Lesson3() : base()
        {
            TopicId = 3;
            TaskTitle = "Познакомиться с конструкциями и условными выражениями";
            TaskText = "Напишите конструкцию if else, которая будет проверять пользовательскую строку на наличие строки “Я ученик”. " +
                       "Если данная строка будет присутствовать, то будет выводиться строка “Всё верно, Вы ученик университета Синергии”. " +
                       "Если данного совпадения не будет, то будет выводиться строка “Вы всё равно молодец”." +
                       "/////////" +
                       "Напиши программу, которая будет принимать число и выводить период года (весна, лето, осень или зима). " +
                       "То есть, пользователь вводит 5 и на экран выводится “Весна”.";
        }

        public void OutputSolutionOfTask3()
        {
            WritelineTask();
            Console.WriteLine($"Подзадача 1: результат: {CheckString()}");
            Console.WriteLine($"Подзадача 2: результат: {DetermineSeasons(CheckInputPositiveNumber())}");
        }

        private string CheckString()
        {
            Console.WriteLine("Введите строку");
            var str = Console.ReadLine();
            if (str != null)
            {
                if (str.Contains("Я ученик"))
                {
                    return StrIfTrue;
                }
            }
            return StrIfFalse;
        }

        private string DetermineSeasons(int numberSeasons)
        {
            while (numberSeasons > 4)
            {
                numberSeasons -= 4;
            }
            return Seasons[numberSeasons - 1 ];
        }
    }
}
