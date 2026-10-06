using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BolohovcevaSV.Sprint1.Task5.V4.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SecondsToHours()
        {
            DataService ds = new DataService();

            int k = 13257;
            int wait = 3;

            int res = ds.SecondsToHours(k);

            Assert.AreEqual(wait, res);
        }
    }
}
