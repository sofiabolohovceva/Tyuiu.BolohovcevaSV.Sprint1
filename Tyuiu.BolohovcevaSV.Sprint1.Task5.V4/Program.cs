using System;
using Tyuiu.BolohovcevaSV.Sprint1.Task5.V4.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task5.V4
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант №4                                                              *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТБ-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h)            *");
            Console.WriteLine("* прошло к этому моменту (например, h=3, если k=13257).                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество секунд:");
            int k = Convert.ToInt32(Console.ReadLine());

            int h = ds.SecondsToHours(k);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Количество полных часов: {h}");

            Console.ReadKey();
        }
    }
}