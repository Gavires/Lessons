using Lessons.LessonsTopic1Core.Models;
using Lessons.LessonsTopic1Core.Validations;

namespace Lessons.Topic2.Lessons
{
    public class Lesson12 : BaseModel
    {
        private readonly ValidationMethods _validationMethods;
        public Lesson12(ValidationMethods validationMethods) : base()
        {
            TopicId = 12;
            TitleLesson = "Методы. Params. Практика.\n";
            TitleTask = "Решить практические задания из видео лекции использовав свое решение.\n";
            TextTask = "Задача 12.1: Написать функцию (метод) f(x).\n" +
                                    "Которая на интервале: \n" +
                                    "(-бесконечность, -3) -> 1 - (x - 10)^2\n" +
                                    "[-3;10] -> -x/2\n" +
                                    "(10, + бесконечность) -> x - 4\n" +
                       "Задача 12.2: Написать метод, который вычисляет растояние между двумя точками на плоскости\n" +
                       "Задача 12.3: Написать метод, который возвращает среднее арифметическое массива типа float\n" +
                       "Задача 12.4: Заполнить массив случайными числами, и найти в этом массиве минимальное число\n" +
                       "задача 12.5: Необходимо удалить i - элемент из массива целых чисел\n";
            _validationMethods = validationMethods;
        }

        public void OutputSolutionOfTask12()
        {
            WritelineTask();
            Console.WriteLine($"Задание 12.1: результат: {Function(_validationMethods.InputValidDoubleNumber())}");
            

        }

        private double Function(double x)
        {
            if (x > double.NegativeInfinity && x < -3 )
            {
                return FunctionVarikOne(x);
            }
            else if (x >= -3 && x <= 10)
            {
                return FunctionVarikTwo(x);
            }
            else if (x > 10 && x < double.PositiveInfinity)
            {
                return FunctionVarikThree(x);
            }
            return x;
        }

        private double FunctionVarikOne(double parametr) => 1 - Math.Pow(parametr - 10, 2);

        private double FunctionVarikTwo(double parametr) => -parametr / 2;

        private double FunctionVarikThree(double parametr) => parametr - 4;
    }
}
