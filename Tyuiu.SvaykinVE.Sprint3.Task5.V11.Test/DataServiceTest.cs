using Tyuiu.SvaykinVE.Sprint3.Task5.V11.Lib;
namespace Tyuiu.SvaykinVE.Sprint3.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int start1 = 1;
            int start2 = 1;
            int end1 = 3;
            int end2 = 10;
            double res = ds.GetSumSumSeries(x, start1, start2, end1, end2);
            Assert.AreEqual(64.234, res);
        }
    }
}
