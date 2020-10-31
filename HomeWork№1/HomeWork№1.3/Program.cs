using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;

            Console.WriteLine("Введите координаты точки 1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки 2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между ними равно: {0}", r);


            Console.ReadKey();
        }
    }
}
