using Tyuiu.SvaykinVE.Sprint3.Task7.V16.Lib;
namespace Tyuiu.SvaykinVE.Sprint3.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] expectedValues = { -36.41, -22.07, 5.68, 16.72, 8.35, -0.5, 9.63, 16.29, 5.01, -22.4, -36.3 };
            double[] actual = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(expectedValues, actual);
        }
    }
}
