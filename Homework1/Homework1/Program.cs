using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {   //*******************************************************************************
        // Павлов Василий
        //14. * Автоморфные числа. Натуральное число называется автоморфным, если оно равно последним
        //цифрам своего квадрата.Например, 25 \ :sup: `2` = 625. Напишите программу, которая вводит
        //натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.
        static void Numbers(int N)
        {
            int a, i, b;
            for (i = 0; i < N; i++)
            {
                if (i == 0) { Console.WriteLine(i + " " + i); }
                else {
                    a = i * i;
                    if (i < 10)
                    {
                        if ((a % 10) == i) { Console.WriteLine(i + " " + a); }
                    }
                    else
                    {
                        b = i;
                        int c = 10;
                        while (b / 10 != 0)
                        {
                            b = b / 10;
                            c = c * 10;
                        }
                        if (a % c == i) { Console.WriteLine(i + " " + a); }
                    }
                }
            }
        }
        //*****************************************************************************

        //13. * Написать функцию, генерирующую случайное число от 1 до 100.
        //с использованием стандартной функции rand()
        //без использования стандартной функции rand()
        static void Rnd()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 101);
            Console.WriteLine(a);
        }

        public static int x = 1;        static int Rnd2()
        {

            int m = 101, a = 7, c = 6;
            x = ((a * x) + c) % m;
            return x;
        }
        //static void Rnd1(int x)
        //{
        //    int m = 101, a = 7, c = 6, x1;
        //    x1 = ((a * x) + c) % m;
        //    Console.WriteLine(x1);
        //}
        //************************************************
        //12. Написать функцию нахождения максимального из трех чисел
        static void Maximum(int a, int b, int c)
        {
            int max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            Console.WriteLine(max); 
        }
        //************************************************
        //11. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее арифметическое всех
        //положительных четных чисел, оканчивающихся на 8.

        static void Average()
        {
            int a;
            int count = 0;
            int sum = 0;
            do
            {
                a = Int32.Parse(Console.ReadLine());
                if (a > 0 && a % 10 == 8)
                {
                    sum = sum + a;
                    count++;
                }

            } while (a != 0);
            Console.WriteLine(sum / count);
        }
        //***********************************************

        static void Main(string[] args)
        {
            Numbers(9377);
            Rnd();
            Console.WriteLine(Rnd2());
            //int q = DateTime.Now.Millisecond / 100;
            //Rnd1(q);
            Maximum(52, 150, 25);
            Average();
            Console.ReadKey();
        }
    }
}
