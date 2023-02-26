using Lessons.LessonsTopic1Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
                "Задача 6.2: написать программу, которая будет выводит сумму вклада под проценты от суммы которой ввел пользователь" +
                "Задача 6.3: написать программу, которая будет выводить наим. число d, которое делится нацело на введенные 2 числа a и b" +
                "Задача 6.4: написать программу, которая будет выводить произведение всех чисел из отрезка [a,b] * [c,d], где a<b, c<d";
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

        private void MultiplicationSegments()
        {
            var numberOne = CheckInputPositiveIntNumber("Введите первое целое число:");
            var numberTwo = CheckInputPositiveIntNumber("Введите втрое целое число ");
            var flagNumber = numberTwo >= numberOne;
            double resOne =  flagNumber ? numberTwo / numberOne : numberOne / numberTwo;
            var result = 0;
            if (resOne % 10 == 0)
            {
                result = flagNumber ? numberTwo : numberOne;
            }
            else
            {

            }
            
        }

    }
}
