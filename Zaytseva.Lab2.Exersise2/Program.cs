using System;

namespace Zaytseva.Lab2.Exersise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            // f(x) = 1/43,0 + ln(|3x/4|) + x/7 + min(x,-3) + cos(x/3)/sin(x/3) + x^x

            // Выводим информацию на консоль.
            Console.WriteLine("Введите x:");

            // Ждем от пользователя ввода строки.
            string xstr = Console.ReadLine();

            // Конвертируем строковой тип в тип double.
            double x = Convert.ToDouble(xstr);

            // Объявляем y.
            double y;
            y = 1 / 43,0 + Math.Log(Math.Abs(x / 3)) + x / 7 + Math.Min(x, -3) + Math.Cos(x / 3) / Math.Sin(x / 3) + Math.Pow(x, x);

            // Выводим информацию о значение y.
            Console.WriteLine(y);
        }
    }
}

