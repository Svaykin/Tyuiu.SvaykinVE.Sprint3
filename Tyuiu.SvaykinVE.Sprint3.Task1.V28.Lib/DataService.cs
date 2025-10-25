using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SvaykinVE.Sprint3.Task1.V28.Lib
{
    public class DataService : ISprint3Task1V28
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            int i = startValue;
            while (i <= stopValue)
            {
                res = res + ((Math.Pow(value,i) + 0.25)*Math.Cos(i));
                i++;
            }
            return Math.Round(res,3);
        }
    }
}
