using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DevyatovEV.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            double denominator = Math.Cos(12 * y - 4);
            if (Math.Abs(denominator) < 0.0001)
            {
                throw new ArgumentException("Знаменатель равен нулю. Деление на ноль невозможно.");
            }

            // Вычисление числителя: 1 + sin√(x² + 1)
            double numerator = 1 + Math.Sin(Math.Sqrt(x * x + 1));

            // Вычисление результата
            double result = numerator / denominator;

            return Math.Round(result, 3);
        }
    }
}