using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint3.Task4.V14.Lib;

namespace Tyuiu.AshirbakievAR.Sprint3.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();
            Assert.AreEqual(6.263,ds.Calculate(-5,5));
        }
    }
}
