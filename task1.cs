//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// -------------------------- Начало программы ----------------------------------
using System;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число:");
            string input = Console.ReadLine();

            #region Проверка на палиндром и вывод результата
            if (IsPalindrome(input))
            {
                Console.WriteLine("Да, число является палиндромом.");
            }
            else
            {
                Console.WriteLine("Нет, число не является палиндромом.");
            }
            #endregion
        }

        #region Метод для проверки на палиндром
        static bool IsPalindrome(string numberStr)
        {
            // Проверяем, что введенная строка состоит из пяти символов
            if (numberStr.Length != 5)
            {
                return false;
            }

            // Переворачиваем строку с помощью Reverse()
            char[] charArray = numberStr.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);

            // Сравниваем исходную строку с перевернутой
            return numberStr == reversedStr;
        }
        #endregion
    }
}
// -------------------------- Конец программы ----------------------------------