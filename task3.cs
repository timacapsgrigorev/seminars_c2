//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// -------------------------- Начало программы ----------------------------------
using System;

namespace CubesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N:");
            int N = int.Parse(Console.ReadLine());

            #region Вывод таблицы кубов чисел от 1 до N
            Console.WriteLine("Таблица кубов чисел от 1 до N:");
            PrintCubesTable(N);
            #endregion
        }

        #region Метод для вывода таблицы кубов чисел
        static void PrintCubesTable(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                int cube = i * i * i;
                Console.Write(cube);

                if (i < N)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
        #endregion
    }
}
// -------------------------- Конец программы ----------------------------------