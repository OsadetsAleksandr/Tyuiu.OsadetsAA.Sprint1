using Tyuiu.OsadetsAA.Sprint1.Task7.V2.Lib;
namespace Tyuiu.OsadetsAA.Sprint1.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = ("Спринт #1 | Выполнил: Осадец А. А. | ПКТб-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Осадец Александр Александрович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("    sinx + cosy");
            Console.WriteLine("z = -----------tgxy");
            Console.WriteLine("    cosx - siny");

            Console.WriteLine("Введите x: ");
            double x;
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y: ");
            double y;
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var z = ds.Calculate(x, y);
            Console.WriteLine(z);
        }
    }
}
