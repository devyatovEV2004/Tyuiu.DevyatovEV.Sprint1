using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint1.Task1.V2.Lib;

namespace Tyuiu.DevyatovEV.Sprint1.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double res = ds.Calculate(x, y);
            double wait = 0.333; // 1*2/(5+1) = 2/6 = 0.333...
            Assert.AreEqual(wait, res, 0.001);
        }


    }
}