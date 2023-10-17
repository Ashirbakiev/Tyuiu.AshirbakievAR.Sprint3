using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint3.Task3.V11.Lib;

namespace Tyuiu.AshirbakievAR.Sprint3.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            char c = 'q';
            char v = '7';
            Assert.AreEqual("s7wre7 v7w77 7", ds.ReplaceCharOnNum("sqwreq vqwqq q", c, v));
        }
    }
}
