using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint3.Task6.V4.Lib;

namespace Tyuiu.AshirbakievAR.Sprint3.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(6, ds.GetSumTheDivisors(10, 15));
        }
    }
}
