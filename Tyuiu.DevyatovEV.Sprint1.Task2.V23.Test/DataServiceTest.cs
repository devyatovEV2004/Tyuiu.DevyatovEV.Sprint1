using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint1.Task2.V23.Lib;

namespace Tyuiu.DevyatovEV.Sprint1.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertMinutesToSeconds1()
        {
            DataService ds = new DataService();
            int minutes = 1;
            int res = ds.ConvertMinutesToSeconds(minutes);
            int wait = 60; // 1 * 60 = 60
            Assert.AreEqual(wait, res);
        }


        }
    }