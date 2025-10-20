using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VariiMN.Sprint3.Task2.V6.Lib
{
    public class DataService : ISprint3Task2V6
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 1;
            do
            {
                result *= (Math.Pow(value, startValue) + 1) * Math.Cos(4);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(result, 3);
        }
    }
}
