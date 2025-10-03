using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint1.Task4.V17.Lib;

namespace Tyuiu.DevyatovEV.Sprint1.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 10.0;
            double y = 1.0;
            double res = ds.Calculate(x, y);
            // 1 / √(10 - 5*1) = 1 / √5 = 1 / 2.23607 ≈ 0.447 → 0.447
            double wait = 0.447;
            Assert.AreEqual(wait, res, 0.001);
        }


    }
}