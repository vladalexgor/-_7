using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        //Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).
        //Для решения задачи можно использовать формулу Герона, где x, y, z – стороны треугольника, p – полупериметр
        static void Main(string[] args)
        {
            //Первый треугольник
            Console.WriteLine("Введите поочередно длины трех сторон первого треугольника:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double s1 = FindAreaTriangle(x1, y1, z1, out double S1);
            Console.WriteLine("Площадь первого треугольника: S1={0:f2}", s1);
            //Второй треугольник
            Console.WriteLine("Введите поочередно длины трех сторон второго треугольника:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double s2 = FindAreaTriangle(x2, y2, z2, out double S2);
            Console.WriteLine("Площадь второго треугольника: S2={0:f2}", s2);
            if (S1>S2)
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго треугольника.");
            }
            else if (S1<S2)
            {
                Console.WriteLine("Площадь первого треугольника меньше площади второго треугольника.");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны.");
            }
            Console.ReadKey();
        }
        static double FindAreaTriangle(double x, double y, double z, out double S)
        {
            double p = (x + y + z) / 2;
            S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
    }
}
