namespace Lessons.LessonsTopic1Core.Validations
{
    public class ValidationMethods
    {
        public int ValidInputIntervals(int intervalFrom, string text)
        {
            int intervalTo;
            do
            {
                intervalTo = CheckInputPositiveIntNumber(text);
            }
            while (CheckIntervalTo(intervalFrom, intervalTo));

            return intervalTo;
        }

        public int CheckInputPositiveIntNumber(string write = "")
        {
            int number;
            bool isValid;
            do
            {
                if (!string.IsNullOrEmpty(write))
                {
                    Console.WriteLine(write);
                }
                Console.WriteLine("Введите неотрицательное число");
                isValid = int.TryParse(Console.ReadLine(), out number);
                Valid(isValid);
            } while (!isValid || number < 0);

            return number;
        }

        public double CheckInputValidDoubleNumber(string write = "")
        {
            double result;
            do
            {
                result = CheckInputValidDoubleNumber(write, "Введите неотрицательное число");
            } 
            while (result < 0);
            
            return result;
        }

        public double InputValidDoubleNumber(string info = "Введите число")
        {
            double number;
            bool isValid;
            do
            {
                if (!string.IsNullOrEmpty(info))
                {
                    Console.WriteLine(info);
                }
                isValid = double.TryParse(Console.ReadLine(), out number);
                Valid(isValid);
            } while (!isValid);
            return number;
        }

        private double CheckInputValidDoubleNumber(string write = "", string info = "")
        {
            if (!string.IsNullOrEmpty(write))
            {
                Console.WriteLine(write);
            }

            return InputValidDoubleNumber(info);
        }

        public string CheckInputValidString()
        {
            string str;
            bool isValid;
            do
            {
                str = Console.ReadLine();
                isValid = !string.IsNullOrEmpty(str);
                Valid(isValid);

            } while (!isValid);

            return str;
        }

        private void Valid(bool valid)
        {
            if (!valid)
            {
                Console.WriteLine("Неверный ввод!!!");
            }
        }

        private bool CheckIntervalTo(int from, int to)
        {
            if (from > to)
            {
                Console.WriteLine("Конечное значение интеревала не может быть меньше или равно начальному значению");
                Console.WriteLine($"Введите значние большее {from}");
                return true;
            }

            return false;
        }
    }
}
