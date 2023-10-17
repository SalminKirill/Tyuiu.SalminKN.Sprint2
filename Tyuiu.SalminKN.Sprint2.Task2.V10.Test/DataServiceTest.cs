using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint2.Task2.V10.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 4;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
