using System;

namespace Zaytseva.Lab2.Exersise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны три стороны треугольника, найти периметр и площадь.
            Console.WriteLine("Введите стороны треугольника");
            int a, b, c, P, S, p;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            // Периметр.
            P = a + b + c;
            Console.WriteLine("периметр: " + P);

            // Полупериметр.
            p = (1 / 2) * (a + b + c);
            Console.WriteLine("полупериметр: " + p);

            // Площадь.
            int v = p * (p - a);
            int d = (p - b);
            int f = (p - c);

            S = Math.Sqrt(​v * d * f);
            Console.WriteLine("площадь: " + S);

        }
    }
}