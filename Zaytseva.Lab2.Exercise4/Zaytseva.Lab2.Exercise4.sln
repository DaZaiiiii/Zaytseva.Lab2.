using System;

namespace Zaytseva.Lab2.Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Журнал
            Console.WriteLine("Цифровая модель журнала");

            // Заданные атрибуты цифровой модели
            // Название журнала.
            Console.WriteLine("Название журнала: elle");
            // Длина журнала (см).            
            double Length;
            // Ширина журнала (см). 
            double Width;
            // Высота журнала (см).
            double High;
            // Количество страниц. 
            int PageCount;
            // Количество месяцев гарантии качества страниц.
            int MonthCount;

            // Вычисляемые атрибуты цифровой модели
            // Площадь страницы.
            double Square;
            // Объем журнала.
            double Volume;
            // Количество краски, необходимой для печати (мл).
            double PaintDemand;
            // Количество клея для проклейки страниц (мл).
            double GlueDemand;

            // Ввод информации в программу.         
            Console.WriteLine("Введите длину:");
            string LengthStr = Console.ReadLine();
            Length = Convert.ToDouble(LengthStr);

            Console.WriteLine("Введите ширину:");
            string WidthStr = Console.ReadLine();
            Width = Convert.ToDouble(WidthStr);

            Console.WriteLine("Введите высоту:");
            string HighStr = Console.ReadLine();
            High = Convert.ToDouble(HighStr);

            Console.WriteLine("Введите кол-во страниц:");
            string PageCountStr = Console.ReadLine();
            PageCount = Convert.ToInt32(PageCountStr);

            Console.WriteLine("Введите кол-во месяцев гарантии:");
            string MonthCountStr = Console.ReadLine();
            MonthCount = Convert.ToInt32(MonthCountStr);

            // Расчет вычисляемых атрибутов.
            Square = Length * Width;
            Volume = Square * High;
            PaintDemand = (0.5 * PageCount + 0.1 * Volume) * MonthCount;
            GlueDemand = 0.1 * High + 0.5 * PageCount + 0.1 * MonthCount;

            // Команда ожидает ввода символа с клавиатуры.
            Console.ReadKey();
            // Очистить консоль от текста.
            Console.Clear();


            // Вывод информации на консоль.
            Console.WriteLine("Название журнала: elle");
            Console.WriteLine("Кол-во страниц: " + PageCount);

            Console.WriteLine("Длина: " + Length + " cм.");
            Console.WriteLine("Ширина: " + Width + " cм.");
            Console.WriteLine("Высота: " + High + " см.");

            Console.WriteLine("Площадь: " + Square + " cм^2.");
            Console.WriteLine("Объем: " + Volume + " cм^3.");
            
            Console.WriteLine("Гарантия качества страниц: " + MonthCount + " мес.");
            
            Console.WriteLine("Кол-во краски для печати: " + PaintDemand + " мл.");
            Console.WriteLine("Кол-во клея для переплета: " + GlueDemand + " мл.");
        }
    }
}
