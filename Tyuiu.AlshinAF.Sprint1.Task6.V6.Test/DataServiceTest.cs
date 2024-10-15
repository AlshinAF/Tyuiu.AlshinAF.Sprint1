using Tyuiu.AlshinAF.Sprint1.Task6.V6.Lib;
namespace Tyuiu.AlshinAF.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "123 233 45";
            DataService ds = new DataService(); 
            string res = ds.DeleteFirstLetter(strTest);
            string wait = "23 33 5";
            Assert.AreEqual(wait, res);
        }
    }
}