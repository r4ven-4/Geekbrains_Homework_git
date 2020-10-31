using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а, затем введите число b.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a = {0}; b = {1}.", a, b);

            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a = {0}; b = {1}.", a, b);

            Console.ReadKey();

            // Задание №4*

            Console.WriteLine("Введите число а, затем введите число b.");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a = {0}; b = {1}.", a, b);

            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;

            Console.WriteLine("a = {0}; b = {1}.", a, b);

            Console.ReadKey();
        }
    }
}
