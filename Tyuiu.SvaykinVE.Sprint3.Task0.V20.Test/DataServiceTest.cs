using System.Resources;
using Tyuiu.SvaykinVE.Sprint3.Task0.V20.Lib;
namespace Tyuiu.SvaykinVE.Sprint3.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int start = 1;
            int end = 14;
            double res = ds.GetMultiplySeries (x, start, end);
            Assert.AreEqual(287.18, res);
        }
    }
}
