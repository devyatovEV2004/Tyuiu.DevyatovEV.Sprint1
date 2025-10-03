using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint1.Task6.V13.Lib;

namespace Tyuiu.DevyatovEV.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckWordsAlphabet_Ordered()
        {
            DataService ds = new DataService();
            string value = "abc";
            bool res = ds.CheckWordsAlphabet(value);
            Assert.IsTrue(res);
        }


    }
}