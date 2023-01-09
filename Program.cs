﻿/*
1.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да



using System;
 
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число:");
            int number = int.Parse(Console.ReadLine()); // читаем пятизначное число с клавиатуры
 
            if (number > 9999 && number < 100000) // проверяем, что число пятизначное
            {
                // сравниваем первую и последнюю цифры, вторую и четвертую
                if (number / 10000 == number % 10 && number % 10000 / 1000 == number % 100 / 10)
                {
                    Console.WriteLine("Число {0} является палиндромом.", number);
                }
                else
                {
                    Console.WriteLine("Число {0} не является палиндромом.", number);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели непятизначное число.");
            }
        }
    }
}


2.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


using System;
 
namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Введите координаты двух точек
            Console.WriteLine("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter z1: ");
            double z1 = double.Parse(Console.ReadLine());
 
            Console.WriteLine("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter z2: ");
            double z2 = double.Parse(Console.ReadLine());
 
            // Вычислите расстояние между точками
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
 
            // Выведите результат
            Console.WriteLine("Distance between the points: " + distance);
        }
    }
}


3.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125




using System;
 
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
 
            Console.WriteLine("Number\t\tCube");
            Console.WriteLine("------\t\t-----");
 
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\t\t{1}", i, i * i * i);
            }
        }
    }
}

*/