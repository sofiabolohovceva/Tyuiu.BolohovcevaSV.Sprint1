using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint1.Task6.V2.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(true, ds.CheckHello("Hello, world!"));
            Assert.AreEqual(true, ds.CheckHello("Say Hello"));
            Assert.AreEqual(false, ds.CheckHello("Привет"));
            Assert.AreEqual(false, ds.CheckHello(""));
        }
    }
}
