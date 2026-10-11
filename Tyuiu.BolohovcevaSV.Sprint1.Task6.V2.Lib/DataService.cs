using System;
using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            return value.Contains("Hello");
        }
    }
}
