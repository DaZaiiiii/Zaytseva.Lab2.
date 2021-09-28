using System;

namespace задание3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // f(x, y, z) = 1 / 43 + ln(| y * 3/4 |) + z / 7 + min(x, -3)

            // Выводим информацию на консоль.
            Console.WriteLine("Введите x:");

            // Ждем от пользователя ввода строки для x.
            string xstr = Console.ReadLine();

            Console.WriteLine("Введите y:");
            // Ждем от пользователя ввода строки для y.
            string ystr = Console.ReadLine();

            Console.WriteLine("Введите z:");
            // Ждем от пользователя ввода строки для z.
            string zstr = Console.ReadLine();

            // Конвертируем строковой тип в тип double.
            double x = Convert.ToDouble(xstr);
            // Конвертируем строковой тип в тип double.
            double y = Convert.ToDouble(ystr);
            // Конвертируем строковой тип в тип double.
            double z = Convert.ToDouble(zstr);

            // Объявляем f.
            double f;
            f = (1 / 43) + Math.Log(Math.Abs(y * 3 / 4)) + z / 7 + Math.Min(x, -3);

            // Выводим информацию о значение f.
            Console.WriteLine(f);
        }
    }
}
