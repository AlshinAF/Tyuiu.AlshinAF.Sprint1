using Tyuiu.AlshinAF.Sprint1.Task7.V2.Lib;
namespace Tyuiu.AlshinAF.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 5.0;
            double wait = 11.704;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}