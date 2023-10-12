using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint2.Task5.V14.Lib;

namespace Tyuiu.KultyshevaEA.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1,1));
            Assert.AreEqual("Вторник", ds.FindDayName(2,2));
            Assert.AreEqual("Среда", ds.FindDayName(3,3));
            Assert.AreEqual("Четверг", ds.FindDayName(4,4));
            Assert.AreEqual("Пятница", ds.FindDayName(5,5));
            Assert.AreEqual("Суббота", ds.FindDayName(6,6));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7,7));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1,-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(365,365);
            });

        }
    }
}
