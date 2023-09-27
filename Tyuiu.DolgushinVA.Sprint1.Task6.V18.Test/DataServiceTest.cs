using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint1.Task6.V18.Lib;
namespace Tyuiu.DolgushinVA.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string value = "105";
            Assert.AreEqual(true, ds.CheckNumber(value));
        }
    }
}
