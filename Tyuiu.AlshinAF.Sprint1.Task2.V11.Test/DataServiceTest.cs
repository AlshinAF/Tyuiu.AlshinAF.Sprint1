using Tyuiu.AlshinAF.Sprint1.Task2.V11.Lib;

namespace Tyuiu.AlshinAF.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 3;
            var res = ds.ConvertHoursMinutesToSeconds(x, y);
            Assert.AreEqual(7380, res);
        }
    }
}