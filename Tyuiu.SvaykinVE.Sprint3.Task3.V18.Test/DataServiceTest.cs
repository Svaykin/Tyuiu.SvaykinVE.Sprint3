using Tyuiu.SvaykinVE.Sprint3.Task3.V18.Lib;
namespace Tyuiu.SvaykinVE.Sprint3.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "4n5nvf 56 bgy";
            char replaceChr = 'n';

            string wait = "nnnnvf nn bgy";
            string res = ds.ReplaceNumOnChar(str, replaceChr);

            Assert.AreEqual(wait, res);
        }
    }
}
