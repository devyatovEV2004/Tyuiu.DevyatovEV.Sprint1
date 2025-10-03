﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DevyatovEV.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            if (k < 1 || k > 365)
            {
                throw new ArgumentException("k должно быть в диапазоне от 1 до 365");
            }

            int n = ((k - 1) % 7) + 1;

            return n;
        }
    }
}