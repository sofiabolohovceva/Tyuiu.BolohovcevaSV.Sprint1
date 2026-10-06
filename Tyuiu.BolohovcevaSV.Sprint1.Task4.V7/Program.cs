using System;
using Tyuiu.BolohovcevaSV.Sprint1.Task4.V7.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 1 | Выполнила: Болоховцева С. В. | СМАРТБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант №7                                                              *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТБ-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y, z;

            Console.Write("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());

            z = ds.Calculate(x, y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Результат: {z:F3}");

            Console.ReadKey();
        }
    }
}