using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        //Павлов Василий
        //1. Реализовать функцию перевода из 10 системы в двоичную используя рекурсию.
        public static void Perevod(int a)
        {
            if (a == 1) a = 1;
            else Perevod(a / 2);
            Console.Write(a % 2);
        }
        //***************************************************************************
        //2. Реализовать функцию возведения числа a в степень b:
        //a.без рекурсии;
        public static double Squ1(double a, double b)
        {
            double c = a;
            if (b == 0)
            {
                if (a == 0) throw new Exception();
                return a = 1;
            }
            else if (b < 0)
            {
                b = -b;
                for (double i = 1; i < b; i++)
                {
                    a = a * c;
                }
                return 1 / a;
            }
            for (double i = 1; i < b; i++)
            {
                a = a * c;
            }
            return a;
        }

        //b.рекурсивно;
        public static double Squ2(double a, double b)
        {
            if (b == 0) return (a == 0) ? throw new Exception() : 1;
            if (b < 0) return (b == -1) ? 1 / a : 1 / a * Squ2(a, b + 1);
            return (b == 1) ? a : a * Squ2(a, b - 1);
        }

        //c. * рекурсивно, используя свойство чётности степени.
        public static int Squ3(int a, int b)
        {
            if (b == 0) return (a == 0) ? throw new Exception() : 1;
            if (b % 2 > 0) return (b == 1) ? a : a * Squ3(a * a, b / 2);
            else return (b == 1) ? a : Squ3(a * a, b / 2);            
        }

        //**********************************************************************

        static void Main(string[] args)
        {
            Perevod(58);
            Console.WriteLine();
            Console.WriteLine(Squ1(3, 4));
            Console.WriteLine(Squ2(2, 6));
            Console.WriteLine(Squ3(2, 6));
            Console.ReadKey();
        }
    }
}
