using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint1.Task7.V17.Lib;

namespace Tyuiu.DevyatovEV.Sprint1.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 0.0;
            double y = 0.0;
            double res = ds.Calculate(x, y);
            // Числитель: 1 + sin√(0 + 1) = 1 + sin(1) = 1 + 0.84147 = 1.84147
            // Знаменатель: cos(0 - 4) = cos(-4) = -0.65364
            // Результат: 1.84147 / -0.65364 ≈ -2.817 → -2.817
            double wait = -2.817;
            Assert.AreEqual(wait, res, 0.001);
        }


    }
}