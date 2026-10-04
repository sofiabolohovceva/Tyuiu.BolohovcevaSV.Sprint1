using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BolohovcevaSV.Sprint1.Task3.V10.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 69.6;

            var res = ds.NumberToMoney(x);

            Assert.AreEqual("69 руб. 60 коп.", res);
        }
    }
}
