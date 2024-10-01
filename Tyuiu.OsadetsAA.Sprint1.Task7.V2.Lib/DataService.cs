using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.OsadetsAA.Sprint1.Task7.V2.Lib
{
    public class DataService : ISprint1Task7V2
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round(((Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y))) * Math.Tan(x * y), 3);
            return res;
        }
    }
}
