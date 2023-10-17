using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint2.Task4.V28.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 8;
            double wait = 5.378;
            double res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(wait, res);

        }
    }
}
