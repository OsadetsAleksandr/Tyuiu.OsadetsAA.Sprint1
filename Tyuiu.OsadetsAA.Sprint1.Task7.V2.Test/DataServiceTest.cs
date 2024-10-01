using Tyuiu.OsadetsAA.Sprint1.Task7.V2.Lib;
namespace Tyuiu.OsadetsAA.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            var res = ds.Calculate(x, y);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}