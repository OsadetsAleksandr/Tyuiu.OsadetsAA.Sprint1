using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.OsadetsAA.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        public double ConvertMToKm(int value)
        {
            return Math.Round(Convert.ToDouble(value) / 1000, 3);
        }
    }
}
