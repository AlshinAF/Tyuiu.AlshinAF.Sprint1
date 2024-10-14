using Tyuiu.AlshinAF.Sprint1.Task4.V23.Lib;
namespace Tyuiu.AlshinAF.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = 6;
            double wait = 0.4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}