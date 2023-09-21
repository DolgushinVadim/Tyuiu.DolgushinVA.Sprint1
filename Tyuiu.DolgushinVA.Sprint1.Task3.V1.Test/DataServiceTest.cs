using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint1.Task3.V1.Lib;
namespace Tyuiu.DolgushinVA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 10;
            double h = 4;
            double wait = 400 * Math.Round(Math.PI, 3);
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait, res);
        }
    }
}
