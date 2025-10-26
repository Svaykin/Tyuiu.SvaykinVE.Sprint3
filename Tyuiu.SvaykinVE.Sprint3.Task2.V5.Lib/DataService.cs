using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SvaykinVE.Sprint3.Task2.V5.Lib
{
    public class DataService : ISprint3Task2V5
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res += (Math.Pow(value, i) + 1) * Math.Cos(i);
            }
            return Math.Round(res, 3);
        }
    }
}
