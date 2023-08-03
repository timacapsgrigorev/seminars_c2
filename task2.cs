//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// -------------------------- Начало программы ----------------------------------
using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки A (x, y, z):");
            double ax = double.Parse(Console.ReadLine());
            double ay = double.Parse(Console.ReadLine());
            double az = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты точки B (x, y, z):");
            double bx = double.Parse(Console.ReadLine());
            double by = double.Parse(Console.ReadLine());
            double bz = double.Parse(Console.ReadLine());

            #region Расчет расстояния и вывод результата
            double distance = CalculateDistance(ax, ay, az, bx, by, bz);
            Console.WriteLine($"Расстояние между точками A и B: {distance:F2}");
            #endregion
        }

        #region Метод для вычисления расстояния между точками
        static double CalculateDistance(double ax, double ay, double az, double bx, double by, double bz)
        {
            double deltaX = bx - ax;
            double deltaY = by - ay;
            double deltaZ = bz - az;

            double distanceSquared = deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ;
            double distance = Math.Sqrt(distanceSquared);

            return distance;
        }
        #endregion
    }
}
// -------------------------- Конец программы ----------------------------------
