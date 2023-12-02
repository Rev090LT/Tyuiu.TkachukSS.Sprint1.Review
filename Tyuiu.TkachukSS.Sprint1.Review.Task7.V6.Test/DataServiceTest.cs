using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint1.Review.Task7.V6.Lib;
namespace Tyuiu.TkachukSS.Sprint1.Review.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(4, 4);
            Assert.AreEqual(-766.725570678711, -766.725570678711);
        }
    }
}
