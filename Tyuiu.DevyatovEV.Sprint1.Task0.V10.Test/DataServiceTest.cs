using Tyuiu.DevyatovEV.Sprint1.Task0.V10.Lib;
namespace Tyuiu.DevyatovEV.Sprint1.Task0.V10.test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(-10.5, res);
        }
    }
}