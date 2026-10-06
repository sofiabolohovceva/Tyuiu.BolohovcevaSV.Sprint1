using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint1.Task4.V7.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            double x = 4;
            double y = 1;

            double wait = 3.000;
            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}


