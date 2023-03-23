using Lessons.LessonsTopic1Core.Models;
using Lessons.LessonsTopic1Core.Validations;

namespace Lessons.Topic1.Lessons
{
    public class Lesson6 : BaseModel
    {
        public ValidationMethods _validationMethods { get; set; }
        public Lesson6(ValidationMethods validationMethods) : base()
        {
            TopicId = 5;
            TitleLesson = "Циклы. Практика.\n";
            TitleTask = "Решить практические задания из видео лекции использовав свое решение.\n";
            TextTask = "Задача 6.1: написать программу, которая будет принимать числа до тех пор, пока не будет введен  “0”,\n " +
                "после получения будет выводиться сумма полученных чисел.\n" +
                "Задача 6.2: написать программу, которая будет выводит сумму вклада под проценты от суммы которой ввел пользователь\n" +
                "Задача 6.3: написать программу, которая будет выводить наим. число d, которое делится нацело на введенные 2 числа a и b\n" +
                "Задача 6.4: написать программу, которая будет выводить произведение всех чисел из отрезка [a,b] * [c,d], где a<b, c<d\n";
            _validationMethods = validationMethods;
        }

        public void OutputSolutionOfTask6()
        {
            WritelineTask();
            Console.WriteLine($"Задача 6.1: результат = {SummNumbers()}");
            Console.WriteLine($"Задача 6.2: результат = {DepositPercentage()} рублей");
            Console.WriteLine($"Задача 6.3: результат = {MultiplicationSegments()}");
            Console.WriteLine($"Задача 6.4: результат = {MultiplicationIntervals()}");
        }

        private double SummNumbers()
        {
            Console.WriteLine("Ввод числа");
            var summ = 0.0;
            double b;
            do
            {
                b = _validationMethods.CheckInputValidDoubleNumber();
                summ += b;
            } while (b != 0);
            return summ;
        }

        private double DepositPercentage()
        {
            //деньги * ставку * дни / 365
            var sum = _validationMethods.CheckInputValidDoubleNumber("Введите сумму вклада");
            var percent = _validationMethods.CheckInputValidDoubleNumber("Введите проценты по вкладу");
            var days = _validationMethods.CheckInputPositiveIntNumber("Введите колличество дней");
            return sum * percent * days / 365;
        }

        private double MultiplicationSegments()
        {
            var numberOne = _validationMethods.CheckInputPositiveIntNumber("Введите первое целое число:");
            var numberTwo = _validationMethods.CheckInputPositiveIntNumber("Введите втрое целое число ");
            var flagNumber = numberTwo >= numberOne;
            double resOne = flagNumber ? numberTwo / numberOne : numberOne / numberTwo;
            var numberMax = flagNumber ? numberTwo : numberOne;
            var numberMin = !flagNumber ? numberTwo : numberOne;
            if (resOne % 10 == 0)
            {
                return numberMax;
            }
            else
            {
                var delta = numberMax - numberMin;

                //Проверяем деление наименьшего числа нацело на дельту чисел a и b
                if (numberMin % delta == 0)
                {
                    return numberMax * (numberMin / delta);
                }
                else //значит одно из чисел простое или разницей чисел невозмоно собрать наименьшее 
                {
                    return numberOne * numberTwo;
                }
            }
        }

        private int MultiplicationIntervals()
        {
            #region Ввод интервалов
            var oneIntervalsFrom = _validationMethods.CheckInputPositiveIntNumber("Введите начальное значение первого интревала");
            var oneIntervalsTo = _validationMethods.ValidInputIntervals(oneIntervalsFrom, "Введите конечное значение первого интревала");
            var twoIntervalsFrom = _validationMethods.CheckInputPositiveIntNumber("Введите начальное значение второго интревала");
            var twoIntervalsTo = _validationMethods.ValidInputIntervals(twoIntervalsFrom, "Введите конечное значение второго интревала");
            #endregion

            var result = 1;

            for (var i = oneIntervalsFrom; i <= oneIntervalsTo; i++)
            {
                var mult = 1;
                for (var j = twoIntervalsFrom; j <= twoIntervalsTo; j++)
                {
                    mult *= j * i;
                }
                result *= mult;
            }
            return result;
        }
    }
}
