using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свой рост:");
            int userHeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите свой вес:");
            int userWeight = Convert.ToInt32(Console.ReadLine());

            float IMT = userWeight / userHeight ^ 2;

            Console.WriteLine("Ваш индекс массы тела равен: {0}", IMT);

            Console.ReadKey();

        }
    }
}
