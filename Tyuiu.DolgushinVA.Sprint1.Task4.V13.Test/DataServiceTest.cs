using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint1.Task4.V13.Lib;
namespace Tyuiu.DolgushinVA.Sprint1.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 1.5;
            double wait = 0.045;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
