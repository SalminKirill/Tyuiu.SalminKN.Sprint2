using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint2.Task0.V0.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 15;
            int y = 16;
            bool[] res = new bool[6];
            res = ds.GetCompareOperation(x, y);
            bool[] wait = new bool[6] { true, true, true, true, true, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
