using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_App2
{
    class Program
    {
        //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число, равное длине ребра куба:");
            double N = Convert.ToDouble(Console.ReadLine());
            //V - объем куба, PP - площадь поверхности куба.
            Cube(N, out double V, out double PP);
            Console.WriteLine("Объем куба: V={0:f2}", V);
            Console.WriteLine("Площадь поверхности куба: PP={0:f2}", PP);
            Console.ReadKey();
        }
        static void Cube(double N, out double V, out double PP)
        {
            V = Math.Pow(N, 3);
            PP = 6 * N * N;
        }
    }
}
