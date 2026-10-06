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

            Assert.AreEqual("30.5 руб. - это 30 руб. 50 коп.", ds.NumberToMoney(30.5));
        }
    }
}
