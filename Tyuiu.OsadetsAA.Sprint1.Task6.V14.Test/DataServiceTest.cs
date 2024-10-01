using Tyuiu.OsadetsAA.Sprint1.Task6.V14.Lib;
namespace Tyuiu.OsadetsAA.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string a = "אבגדהוזח";
            bool res = ds.CheckLowerCaseRusLetters(a);
            bool wait = true;
            Assert.AreEqual(res, wait);

        }
    }
}