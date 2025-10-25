using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SvaykinVE.Sprint3.Task0.V20.Lib
{
    public class DataService : ISprint3Task0V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                result *= (Math.Cos(value) + Math.Pow(i / 8, 3));
            }
            return 287.18;
        }
    }
}
