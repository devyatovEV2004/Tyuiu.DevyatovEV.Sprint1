using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint1.Task3.V1.Lib;

namespace Tyuiu.DevyatovEV.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCylinderVolume1()
        {
            DataService ds = new DataService();
            double r = 1.0;
            double h = 1.0;
            double res = ds.CylinderVolume(r, h);
            double wait = 3.142; // π * 1² * 1 = 3.14159... → 3.142
            Assert.AreEqual(wait, res);
        }


    }
}