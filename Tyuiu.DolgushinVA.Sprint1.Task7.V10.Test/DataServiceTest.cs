using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint1.Task7.V10.Lib;
namespace Tyuiu.DolgushinVA.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double wait = -1.95;
            var res = ds.Calculate (x);
            Assert.AreEqual(wait, res); 
        }
    }
}
