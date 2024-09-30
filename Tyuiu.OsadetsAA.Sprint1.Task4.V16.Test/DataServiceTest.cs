using Tyuiu.OsadetsAA.Sprint1.Task4.V16.Lib;
namespace Tyuiu.OsadetsAA.Sprint1.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double wait = 0.125;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}