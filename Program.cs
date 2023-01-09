/*
1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1



using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число:");
            int threeDigitNumber = int.Parse(Console.ReadLine()); // читаем трёхзначное число с клавиатуры

            int secondDigit = threeDigitNumber % 100 / 10; // вычисляем вторую цифру

            Console.WriteLine("Вторая цифра числа {0}: {1}", threeDigitNumber, secondDigit);
        }
    }
}





2.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

using System;
 
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine()); // читаем число с клавиатуры
 
            if (number > 99 && number < 1000) // проверяем, что число трёхзначное
            {
                int thirdDigit = number % 10; // вычисляем третью цифру
 
                Console.WriteLine("Третья цифра числа {0}: {1}", number, thirdDigit);
            }
            else
            {
                Console.WriteLine("В числе {0} третьей цифры нет.", number);
            }
        }
    }
}


3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет


using System;
 
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели (1-7):");
            int dayOfWeek = int.Parse(Console.ReadLine()); // читаем номер дня недели с клавиатуры
 
            if (dayOfWeek == 6 || dayOfWeek == 7) // проверяем, является ли день выходным
            {
                Console.WriteLine("Это выходной день.");
            }
            else
            {
                Console.WriteLine("Это рабочий день.");
            }
        }
    }
}
*/