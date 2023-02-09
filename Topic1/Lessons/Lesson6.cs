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
            TextTask = "Задача 6.1: написать программу, которая будет принимать числа до тех пор, пока не будет введен  “0”,\n " +
                "после получения будет выводиться сумма полученных чисел." +
                "Задача 6.2: написать проограмму которая будет выводит сумму вклада под проценты от суммы которой ввел пользователь";
        }

        public void OutputSolutionOfTask6()
        {
            WritelineTask();
            Console.WriteLine($"Задача 6.1: результат = {SummNumbers()}");
            Console.WriteLine($"Задача 6.2: результат = {DepositPercentage()} рублей");
        }

        private double SummNumbers()
        {
            Console.WriteLine("Ввод числа");
            var summ = 0.0;
            double b;
            do
            {
                b = CheckInputValidDoubleNumber();
                summ += b;
            } while (b != 0);
            return summ;
        }

        private double DepositPercentage()
        {
            //деньги * ставку * дни / 365
            var sum = CheckInputValidDoubleNumber("Введите сумму вклада");
            var percent = CheckInputValidDoubleNumber("Введите проценты по вкладу");
            var days = CheckInputPositiveIntNumber("Введите колличество дней");
            return sum * percent * days / 365;
        }

    }
}
