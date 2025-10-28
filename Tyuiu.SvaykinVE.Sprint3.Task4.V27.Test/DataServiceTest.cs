using Tyuiu.SvaykinVE.Sprint3.Task4.V27.Lib;
namespace Tyuiu.SvaykinVE.Sprint3.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = -5; 
            int b = 5;
            var res = ds.Calculate(a, b);
            Assert.AreEqual(-44.313, res);
        }
    }
}
