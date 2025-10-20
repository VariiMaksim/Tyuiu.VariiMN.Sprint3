﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VariiMN.Sprint3.Task4.V29.Lib
{
    public class DataService : ISprint3Task4V29
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    res += (Math.Cos(x) / x);
                }
            }
            return Math.Round(res, 3);

        }
    }
}
