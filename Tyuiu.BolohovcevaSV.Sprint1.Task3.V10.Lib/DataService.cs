using System;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task3.V10.Lib
{
    public class DataService
    {
        public string NumberToMoney(double number)
        {
            number = Math.Round(number, 3);

            int rubles = (int)number;
            int kopecks = (int)((number - rubles) * 100);

            return $"{number.ToString(System.Globalization.CultureInfo.InvariantCulture)} руб. - это {rubles} руб. {kopecks} коп.";
        }
    }
}
