using Lessons.LessonsTopic1Core.Models;
using Lessons.LessonsTopic1Core.Validations;

namespace Lessons.Topic1.Lessons
{
    public class Lesson3 : BaseModel
    {
        private string StrIfTrue { get; } = "Всё верно, Вы ученик университета Синергии";

        private string StrIfFalse { get; } = "Вы всё равно молодец";

        private string[] Seasons { get; } = { "Весна", "Лето", "Осень", "Зима" };

        public ValidationMethods _validationMethods { get; set; }

        public Lesson3(ValidationMethods validationMethods) : base()
        {
            TopicId = 3;
            TitleTask = "Познакомиться с конструкциями и условными выражениями";
            TextTask = "Напишите конструкцию if else, которая будет проверять пользовательскую строку на наличие строки “Я ученик”. " +
                       "Если данная строка будет присутствовать, то будет выводиться строка “Всё верно, Вы ученик университета Синергии”. " +
                       "Если данного совпадения не будет, то будет выводиться строка “Вы всё равно молодец”." +
                       "/////////" +
                       "Напиши программу, которая будет принимать число и выводить период года (весна, лето, осень или зима). " +
                       "То есть, пользователь вводит 5 и на экран выводится “Весна”.";
            _validationMethods = validationMethods;
        }

        public void OutputSolutionOfTask3()
        {
            WritelineTask();
            Console.WriteLine($"Подзадача 1: результат: {CheckString()}");
            Console.WriteLine($"Подзадача 2: результат: {DetermineSeasons(_validationMethods.CheckInputPositiveIntNumber())}");
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
            return Seasons[numberSeasons - 1];
        }
    }
}
