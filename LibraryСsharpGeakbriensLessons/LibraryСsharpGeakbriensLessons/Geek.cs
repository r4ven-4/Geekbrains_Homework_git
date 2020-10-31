using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryСsharpGeekbrainsLessons
{
    public class Geek
    {
        public static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        public static void Pause()
        {
            Console.WriteLine("\nНажмите любую кнопку для продолжения/завершения работы программы...");
            Console.ReadKey();
        }
        public static double Sqr(double a)
        {
            return a * a;
        }

    }
}
