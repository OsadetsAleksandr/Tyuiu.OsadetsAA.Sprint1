using Tyuiu.OsadetsAA.Sprint1.Task1.V25.Lib;
namespace Tyuiu.OsadetsAA.Sprint1.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y, Math);
            Assert.AreEqual(1, res);
        }
    }
}