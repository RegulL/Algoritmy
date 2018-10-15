using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    //Павлов Василий
    //1. Реализовать перевод из десятичной в двоичную систему счисления с использованием стека
    class Program
    {
        public static int[] Stack1 = new int[100];
        public static int N = -1;
        public static void Push(int a)
        {
            if (N < 100)
            {
                N++;
                Stack1[N] = a;
            }
            else Console.WriteLine("Stack overflow!");
        }
        public static int Pop()
        {
            if (N != -1)
            {
                return Stack1[N--];
            }
            else
            {
                Console.WriteLine("Stack is Empty!!!");
                return 0;
            }
        }
        public static void Numbers(int a)
        {
            int b;
            while (a != 0)
            {
                b = a % 2;
                Push(b);
                a = a / 2;
            }
        }
        static void Main(string[] args)
        {
            int q;
            Numbers(153);
            while (N != -1)
            {
                q = Pop();
                Console.Write(q);
            }
            Console.ReadKey();
        }
    }
}
