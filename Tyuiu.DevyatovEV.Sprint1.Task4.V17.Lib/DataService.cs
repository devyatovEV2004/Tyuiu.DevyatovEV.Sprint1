using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DevyatovEV.Sprint1.Task4.V17.Lib
{
    public class DataService : ISprint1Task4V17
    {
        public double Calculate(double x, double y)
        {
            double expression = x - 5 * y;

            if (expression <= 0)
            {
                throw new ArgumentException("Подкоренное выражение (x - 5y) должно быть положительным");
            }

            double result = 1 / Math.Sqrt(expression);

            return Math.Round(result, 3);
        }
    }
}