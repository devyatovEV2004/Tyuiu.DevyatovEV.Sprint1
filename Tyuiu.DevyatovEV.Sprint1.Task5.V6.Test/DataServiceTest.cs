using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.DevyatovEV.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateDay1()
        {
            DataService ds = new DataService();
            int k = 1;
            int res = ds.Calculate(k);
            int wait = 1; // 1 января - понедельник
            Assert.AreEqual(wait, res);
        }


    }
}