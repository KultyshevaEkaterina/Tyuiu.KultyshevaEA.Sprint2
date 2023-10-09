using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint2.Task4.V10.Lib;

namespace Tyuiu.KultyshevaEA.Sprint2.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest

    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 9;
            double res = ds.Calculate(x, y);
            double wait = 1.037;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 6;
            double res = ds.Calculate(x, y);
            double wait = 55;
            Assert.AreEqual(wait, res);
        }
    }
}
