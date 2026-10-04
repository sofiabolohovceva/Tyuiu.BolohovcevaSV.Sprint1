using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            number = Math.Round(number, 2);

            int rub = (int)number;

            int kop = (int)Math.Round((number - rub) * 100);

            if (kop == 100)
            {
                rub++;
                kop = 0;
            }

            return $"{rub} руб. {kop} коп.";
        }
    }
}
