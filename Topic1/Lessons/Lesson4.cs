using Lessons.LessonsTopic1Core.Models;
using Lessons.LessonsTopic1Core.Validations;
using static System.Math;

namespace Lessons.Topic1.Lessons
{
    public class Lesson4 : BaseModel
    {
        private string YesLeapYear { get; set; } = "Введенный год високосный";

        private string NoLeapYear { get; set; } = "Введенный год не является високосным";

        public ValidationMethods _validationMethods { get; set; }

        public Lesson4(ValidationMethods validationMethods) : base()
        {
            TopicId = 4;
            TitleLesson = "Условные конструкции. Практика";
            TitleTask = "Решить практические задания из видео лекции использовав свое решение.\n";
            TextTask = "4.1: Используйте все отношения к числам (+ - * / ) и выведите значение True.\n" +
                "4.2: Определение високосный года\n" +
                "4.3: Вычислить площадь фигур Треугольник, Квадрат, Круг\n";
            _validationMethods = validationMethods;
        }

        public void OutputSolutionOfTask4()
        {
            WritelineTask();
            Console.WriteLine($"Подзадача 4.1: результат = {OutputTrue()}");
            Console.WriteLine($"Подзадача 4.2: результат = {(IsLeapYear() ? YesLeapYear : NoLeapYear)}");
            Console.WriteLine($"Подзадача 4.3: результат = {AreaOfFigure()}");
        }

        private bool OutputTrue() => (0 + 0 - 0) * 0 / 1 == 0;

        private bool IsLeapYear()
        {
            Console.WriteLine("Подзадача 4.2:");
            var year = _validationMethods.CheckInputPositiveIntNumber();
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    { return true; }
                    else
                    { return false; }
                }
                else
                { return true; }
            }
            else
            { return false; }
        }

        private string AreaOfFigure()
        {
            Console.WriteLine("Подзадача 4.3:");
            Console.WriteLine("Введите фигуру");
            var figure = _validationMethods.CheckInputValidString();
            switch (figure.ToLower())
            {
                case "треугольник":
                    return $"Площадь треугольника = {AreaTriangle()}";
                case "квадрат":
                    return $"Площадь квадрата = {AreaSquare()}";
                case "круг":
                    return $"Площадь круга = {AreaСircle()}";
                default:
                    Console.WriteLine("Неверный ввод фигуры");
                    return "0";
            }
        }

        private double AreaTriangle()
        {
            Console.WriteLine("Ввод основания треугольника");
            var footing = _validationMethods.CheckInputValidDoubleNumber();
            Console.WriteLine("Ввод высоты треугольника");
            var height = _validationMethods.CheckInputValidDoubleNumber();
            return footing * height / 2;
        }

        private double AreaSquare()
        {
            Console.WriteLine("Ввод стороны квадрата");
            var side = _validationMethods.CheckInputValidDoubleNumber();
            return side * side;
        }

        private double AreaСircle()
        {
            Console.WriteLine("Ввод радиуса круга");
            var radius = _validationMethods.CheckInputValidDoubleNumber();
            return PI * (radius * radius);
        }
    }
}
