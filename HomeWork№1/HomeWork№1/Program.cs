using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryСsharpGeakbriensLessons;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.Write("Введите свое имя:");
            string userName = Console.ReadLine();

            Console.Write("Введите свою фамилию:");
            string userLastName = Console.ReadLine();

            Console.Write("Введите свой возраст:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите свой рост:");
            int userHeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите свой вес:");
            int userWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Имя " + userName + " Фамилия " + userLastName + " Возраст " + userAge + " Рост " + userHeight + " Вес " + userWeight);

            Console.WriteLine("Имя: {0}; Фамилия: {1}; Возраст: {2}; Рост:{3}; Вес: {4}.", userName, userLastName, userAge, userHeight, userWeight);

            Console.WriteLine($"Имя: {userName}; Фамилия: {userLastName}; Возраст: {userAge}; Рост:{userHeight}; Вес: {userWeight}.");


            Geek.Pause();

        }

       
        

    }
}
