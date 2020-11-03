using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryСsharpGeekbrainsLessons;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(1, 1);

            Complex complex2 = new Complex(2, 2);


            Complex result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            Geek.Pause();

        }

        public static int SumOddNumber()
        {
            int Sum = 0, Num;
            bool flag;
            while (true)
            {
                do
                {
                    Console.Write("Введите число: ");
                    flag = int.TryParse(Console.ReadLine(), out Num);
                    if (flag) { IncorData(); }
                } while (!flag)


                ;
                
                if (Num == 0) { break; } 
                else if(Num%2 == 1 && Num>0){ Sum += Num; }               
            }

            return Sum;
        }

        private static void IncorData()
        {
            Console.WriteLine("\nВВЕДИТЕ ЧИСЛО!!!");
        }
    }
}
