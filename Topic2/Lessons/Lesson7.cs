using Lessons.LessonsTopic1Core.Models;
using Lessons.LessonsTopic1Core.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Topic2.Lessons
{
    public class Lesson7 : BaseModel
    {
        private int[] IntMass { get; set; } = new int[] { 1, 2, 3, 4, 5};

        private string[] StringMass { get; set; } = new string[] {"Я ", "ученик ", "Синергии ", "номер ", "один" };

        private readonly string StringTask = "один";

        public Lesson7 () : base ()
        {
            TopicId = 7;
            TitleLesson = "Создание двумерного массива и работа с ним. Практика.\n";
            TitleTask = "Познакомиться с массивами и работой с ними.\n";
            TextTask = "Задача 1.1: Создайте два массива: числовой и строчный. \n" +
                "Числовой массив должен создать в себе числа от 1 до 5. \n" +
                "Строчный же, должен содержать в себе следующую строку “Я ученик Синергии номер один\n " +
                "Используя полученные знания, заметите слово “один” на любую цифру из числового массива.\n";
        }

        public void OutputSolutionOfTask7()
        {
            WritelineTask();
            Console.WriteLine($"Задание 7.1: результат = {WriteLineStringMass(ReplacingStringElement())}");
        }

        private string[] ReplacingStringElement()
        {
            for (var i = 0; i < StringMass.Length; i++)
            {
                if (StringMass[i].Contains(StringTask))
                {
                    var random = new Random().Next(0, 4);
                    StringMass[i] = IntMass[random].ToString();
                }
            }
            return StringMass;
        }

        private string WriteLineStringMass(string[] stringMass)
        {
            var result = new StringBuilder();
            for (var i = 0; i < stringMass.Length; i++)
            {
                result.Append(StringMass[i]);
            }
            return result.ToString();
        }
    }
}
