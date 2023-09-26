using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практос
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите программу, которую хотите запустить");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Закрыть программу");
            int x = int.Parse(Console.ReadLine());
            void game()
            {
                int ugaday = 0;
                Console.WriteLine("Угадайте число от 1 до 100");
                Random rnd = new Random();
                int randomnum = rnd.Next(1, 100);
                do
                {
                    ugaday = int.Parse(Console.ReadLine());
                    if (ugaday < randomnum)
                        Console.WriteLine("Загаданное число больше");
                    if (ugaday > randomnum)
                        Console.WriteLine("Загаданное число меньше");
                }
                while (ugaday != randomnum);
                Console.WriteLine("Угадал! Красаучик");

                Console.WriteLine("Выберите программу, которую хотите запустить");
                Console.WriteLine("1. Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Закрыть программу");
                x = int.Parse(Console.ReadLine());
            }
            void tablumng()
            {
                // заполнение цикла
                int[,] tablumn = new int[10, 10];
                for (int i = 1; i < 10; i++)
                    for (int j = 1; j < 10; j++)
                        tablumn[i, j] = i * j;
                // вывод цикла
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        Console.Write(tablumn[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Выберите программу, которую хотите запустить");
                Console.WriteLine("1. Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Закрыть программу");
                x = int.Parse(Console.ReadLine());
            }
            void delenchisel()
            {
                Console.WriteLine("Введите число");
                int num = int.Parse(Console.ReadLine());
                for (int i = 1; i <= num; i++)
                    if (num % i == 0)
                    {
                        Console.Write(i + "\t");
                    }
                Console.WriteLine("Введите число");
                num = int.Parse(Console.ReadLine());
            }
            do
            {
                if (x == 1)
                {
                    game();
                }
                if (x == 2)
                {
                    tablumng();
                }
                if (x == 3)
                {
                    delenchisel();
                }
            } while (x != 4);
        }
    }
}
