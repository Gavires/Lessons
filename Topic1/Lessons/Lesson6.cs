using Lessons.LessonsTopic1Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Topic1.Lessons
{
    public class Lesson6 : BaseModel
    {
        public Lesson6() : base()
        {
            TopicId = 5;
            TitleLesson = "Циклы. Практика.\n";
            TitleTask = "Решить практические задания из видео лекции использовав свое решение.\n";
            TextTask = "Написать программу, которая будет принимать числа до тех пор, пока не будет введен  “0”,\n " +
                "после получения будет выводиться сумма полученных чисел.";
        }

        public void OutputSolutionOfTask6()
        {
            WritelineTask();
            Console.WriteLine($"Задача 6: результат = {SummNumbers()}");
        }

        public double SummNumbers()
        {
            Console.WriteLine("Ввод числа");
            var summ = 0.0;
            var b = 0.0;
            do
            {
                b = CheckInputValidDoubleNumber();
                summ += b;
            } while (b != 0);

            //var a = CheckInputValidDoubleNumber();
            //while ( a != 0)
            //{
            //    summ += a;
            //    a = CheckInputValidDoubleNumber();
            //}
            return summ;
        }

    }
}
