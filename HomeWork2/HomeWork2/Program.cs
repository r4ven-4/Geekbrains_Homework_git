using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryСsharpGeekbrainsLessons;

//Романов Сергей Александрович

namespace HomeWork_2
{
    class Program
    {
        static public string UserLogin = "root", UserPassword = "Geekbrains";
        static void Main(string[] args)
        {

            Geek.Pause();
        }

        static int Min(int a, int b, int c)
        {

            int min;

            if (a < b && a < c)
            {
                min = a;
            }
            else
            {
                if (b < c)
                {
                    min = b;
                }
                else
                {
                    min = c;
                }
            }

            return min;
        }
        static int CountNumber(int Num)
        {
            //  Метод возвращает количество цифр в числе
            int i = 0;
            while (Num != 0)
            {
                Num /= 10;
                i++;

            }
            return i;
        }

        static bool CheckLogin(string Login, string Password)
        {
            return Login == UserLogin && Password == UserPassword;
        }

        static void LogIN()
        {
            int TryCount = 0;
            string Login;
            string Password;

            do
            {
                TryCount++;

                Console.Write("Введите логин:");
                Login = Console.ReadLine();

                Console.Write("Введите пароль:");
                Password = Console.ReadLine();

                if (CheckLogin(Login, Password) == true)
                {
                    Console.WriteLine($"Авторизация прошла успешно. Добро пожаловать, {UserLogin}.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Неправильный логин или пароль. Повторите ввод. У вас ещё {3 - TryCount} попытки.");

                }

            } while (TryCount != 3);
        }

        static void IMT()
        {
            Console.Write("Введите свой рост:");
            double userHeight = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Введите свой вес:");
            double userWeight = Convert.ToDouble(Console.ReadLine());

            double IMT = userWeight / Geek.Sqr(userHeight); //Geek.Sqr вазврашает квадрат аргумента.

            Console.Write($"\nВаш индекс массы тела равен: {IMT}. ");

            if (IMT >= 18.5 && IMT <= 25)
            {
                Console.WriteLine("У вас нормальный вес");
            }
            else if (IMT > 25)
            {
                double NormWeight = userWeight - 25 * Geek.Sqr(userHeight);
                Console.WriteLine($"У вас избыточная масса тела.\nВам необходимо похудеть на {NormWeight} килограммов.");

            }
            else
            {
                double NormWeight = 18.5 * Geek.Sqr(userHeight) - userWeight;
                Console.WriteLine($"У вас недостаточная масса тела.\nВам необходимо поправиться на {NormWeight} килограммов.");
            }


        }

        static void GoodNumber()
        {
            DateTime time = DateTime.Now;
            int GoodNumber = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                //if (i % SumNum(i) == 0)
                //{
                //    GoodNumber++;
                //    Console.WriteLine(i);
                //}
                if (i % RecSum(i) == 0)
                {
                    GoodNumber++;
                    //Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Число «Хороших» чисел в диапазоне от 1 до 1 000 000 000 равно: {GoodNumber}.");
            Console.WriteLine($"Время работы программы: { DateTime.Now - time}.");
        }

        public static int SumNum(int i)
        {
            int j = 0;
            while (i != 0)
            {
                j = j + i % 10;
                i /= 10;
            }
            return j;
        }

        public static void SumOddNum()
        {
            int enter;
            int Sum = 0;
            while (true)
            {
                enter = Convert.ToInt32(Console.ReadLine());
                if (enter == 0)
                {
                    break;
                }
                else if (enter % 2 == 1)
                {
                    Sum += enter;
                }

            }
            Console.WriteLine($"Сумма нечетных чисел: {Sum}.");

        }

        static void Loop(int a, int b)
        {
            Console.Write($"{a}, ");
            if (a < b) Loop(a + 1, b);
        }

        static long RecSum(long a)
        {
            if (a == 0) return 0;
            else return RecSum(a / 10) + a % 10;
        }

    }

    //class User
    //{
    //    static public string Login = "root", Password = "Geekbrains";
    //}

}
