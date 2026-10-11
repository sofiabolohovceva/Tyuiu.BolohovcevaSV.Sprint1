using System;
using Tyuiu.BolohovcevaSV.Sprint1.Task6.V2.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 1 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант №2                                                              *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая проверяет, есть ли в строке слово Hello.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            bool result = ds.CheckHello(text);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(result
                ? "Слово Hello есть в строке."
                : "Слова Hello нет в строке.");

            Console.ReadKey();
        }
    }
}