using System;
using Tyuiu.BolohovcevaSV.Sprint1.Task2.V27.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task2.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 1 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание №2                                                              *");
            Console.WriteLine("* Вариант №27                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТБ-26-1*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экранe              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int x;
            Console.WriteLine("Введите значение х:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Периметр квадрата со стороной x = " + ds.CalculateSquarePerimetr(x));
            Console.ReadLine();
        }
    }
}