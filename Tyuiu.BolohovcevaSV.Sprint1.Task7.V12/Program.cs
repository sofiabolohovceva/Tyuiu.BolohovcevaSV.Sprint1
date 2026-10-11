using System;
using Tyuiu.BolohovcevaSV.Sprint1.Task7.V12.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task7.V12
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант №12                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТБ-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных,вводимых пользователем.                    *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y, z;

            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());

            z = Math.Pow((x + 1) / (x - 1), x) + 18 * x * Math.Pow(y, 2);

            Console.WriteLine("Результат = " + Math.Round(z, 3));
            Console.ReadKey();
        }
    }
}