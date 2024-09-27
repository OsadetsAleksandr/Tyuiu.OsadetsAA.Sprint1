using Tyuiu.OsadetsAA.Sprint1.Task2.V6.Lib;
namespace Tyuiu.OsadetsAA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1000;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(1, res);
        }
    }
}