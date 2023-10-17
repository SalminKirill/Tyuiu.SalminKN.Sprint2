using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint2.Task3.V1.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = -17.027;
            double res = Math.Round(ds.Calculate(x), 3);
            Assert.AreEqual(wait, res);
        }
    }
}
