using Tyuiu.AlshinAF.Sprint1.Task5.V5.Lib;
namespace Tyuiu.AlshinAF.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 32.597;
            DataService ds = new DataService();
            int res = ds.Calculate(x);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}