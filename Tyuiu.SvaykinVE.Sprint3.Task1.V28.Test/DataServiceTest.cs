using Tyuiu.SvaykinVE.Sprint3.Task1.V28.Lib;
namespace Tyuiu.SvaykinVE.Sprint3.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 0.5;
            int start = 1;
            int end = 18;
            double res = ds.GetSumSeries(a, start, end);
            Assert.AreEqual(-0.186, res);
        }
    }
}
