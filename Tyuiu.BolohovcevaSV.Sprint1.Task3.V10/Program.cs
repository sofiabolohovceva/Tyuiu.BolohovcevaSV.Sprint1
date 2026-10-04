using System;
using System.Globalization;
using Tyuiu.BolohovcevaSV.Sprint1.Task3.V10.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task3.V10
{
    internal class Program
    {
        static void Main(string args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 1 | Выполнила: Болоховцева С. В. | СМАРТБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант №10                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТБ-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая преобразует введенное с                     *");
            Console.WriteLine("* клавиатуры дробное число в денежный формат.                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите дробное число: ");
            string input = Console.ReadLine();

            double x = double.Parse(input, CultureInfo.InvariantCulture);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.NumberToMoney(x));
            Console.ReadKey();
        }
    }
}