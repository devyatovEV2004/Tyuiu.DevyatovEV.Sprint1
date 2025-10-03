using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DevyatovEV.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length == 1)
            {
                return true;
            }

            string lowerValue = value.ToLower();

            for (int i = 1; i < lowerValue.Length; i++)
            {
                if (lowerValue[i] < lowerValue[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}