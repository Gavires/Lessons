using Lessons.LessonsTopic1Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Topic1.Lessons
{
    public class Lesson4 : BaseModel
    {   
        public Lesson4 () : base ()
        {
            TopicId = 4;
            TitleLesson = "Условные конструкции. Практика";
            TitleTask = "Решить практические задания из видео лекции использовав свое решение.";
            TextTask = "4.1: Используйте все отношения к числам (+ - * / ) и выведите значение True." +
                "4.2: Определение високосного года" +
                "4.3: Вычислить площадь фигур Треугольник, Квадрат, Круг";
        }

        private bool OutputTrue()
        {
            return (0 + 0 - 0) * 0 / 1 == 0;
        }

        private string IsLeapYear()
        {
            var year = CheckInputPositiveNumber();
            return year.ToString();
        }
    }
}
