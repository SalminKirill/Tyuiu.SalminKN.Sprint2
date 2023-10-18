using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint2.Task7.V5.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int x = 5;
            int y = 6;
            bool wait = false;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
