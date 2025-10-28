using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SvaykinVE.Sprint3.Task5.V11.Lib
{
    public class DataService : ISprint3Task5V11
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            { 
                for (j = startValue2; j <= stopValue2; j++)
                { res += Math.Sin(j) + (x / 2); }
            }
            return Math.Round(res,3);
        }
    }
}
