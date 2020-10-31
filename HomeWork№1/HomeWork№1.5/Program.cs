using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryСsharpGeakbriensLessons;

namespace HomeWork_1._5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите свое имя:");
            string userName = Console.ReadLine();

            Console.Write("Введите свою фамилию:");
            string userLastName = Console.ReadLine();

            Console.Write("Введите свой город:");
            string userTown = Console.ReadLine();

            string ms = userLastName + " " + userName + ", " + userTown;

            Console.WriteLine(ms);

            Console.ReadLine();
            Console.Clear();

            Console.SetCursorPosition((Console.WindowWidth / 2)-(ms.Length/2), Console.WindowHeight / 2);
            Console.WriteLine(ms);

            Console.ReadLine();
            Console.Clear();

            Geek.Print(ms, (Console.WindowWidth / 2) - (ms.Length / 2), Console.WindowHeight / 2);


            Geek.Pause();
        }
    }
}
