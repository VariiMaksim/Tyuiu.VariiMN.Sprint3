using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VariiMN.Sprint3.Task0.V2.Lib
{
    public class DataService : ISprint3Task0V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MultiplySeries = 0;
            int i;
            for (i  = startValue; i <= stopValue; i++)
            {
                double k = (i / Math.Pow(Math.Sin(1), -7));
                MultiplySeries = MultiplySeries + Math.Pow(k, -2);
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
