using Lessons.LessonsTopic1Core.Validations;
using Lessons.Topic1.Lessons;
using Lessons.Topic2.Lessons;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Topic1
            //var lesson1 = new Lesson1();
            //lesson1.OutputSolutionOfTask1();

            //var lesson2 = new Lesson2();
            //lesson2.OutputSolutionOfTask2();

            //var lesson3 = new Lesson3(new ValidationMethods());
            //lesson3.OutputSolutionOfTask3();

            //var lesson4 = new Lesson4(new ValidationMethods());
            //lesson4.OutputSolutionOfTask4();

            //var lesson5 = new Lesson5();
            //lesson5.OutputSolutionOfTask5();

            //var lesson6 = new Lesson6(new ValidationMethods());
            //lesson6.OutputSolutionOfTask6();

            #endregion

            #region Topic2
            //var lesson7 = new Lesson7();
            //lesson7.OutputSolutionOfTask7();

            //var lesson8 = new Lesson8();
            //lesson8.OutputSolutionOfTask8();

            var lesson9 = new Lesson9();
            lesson9.OutputSolutionOfTask9();

            #endregion

        }
    }
}