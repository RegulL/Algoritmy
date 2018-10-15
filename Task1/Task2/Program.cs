using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //Павлов Василий 
    //2. Написать программу, которая определяет, является ли введенная скобочная
    //последовательность правильной. Примеры правильных скобочных выражений: (), ([])(), {}(),
    //([{}]), неправильных — )(, ())({), (, ])}), ([(]) для скобок [, (, {.
    //Например: (2+(2*2)) или [2/{5*(4+7)}].
    //4. *Реализовать алгоритм перевода из инфиксной записи арифметического выражения в
    //постфиксную.
    class Program
    {

        public static char[] Stack1 = new char[100];
        public static int N = -1;
        public static void Push(char a)
        {
            if (N < 100)
            {
                N++;
                Stack1[N] = a;
            }
            else Console.WriteLine("Stack overflow!");
        }
        public static char Pop()
        {
            if (N != -1)
            {
                return Stack1[N--];
            }
            else
            {
                //Console.WriteLine("Stack is Empty!!!");
                return ' ';
            }
        }
        public static char Peek()
        {
            if (N != -1)
            {
                return Stack1[N];
            }
            else
            {
                //Console.WriteLine("Stack is Empty!!!");
                return ' ';
            }
        }
        public static bool Control(char[] a) //Проверка скобок
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '(' || a[i] == '{' || a[i] == '[')
                {
                    Push(a[i]);
                }
                if (a[i] == ')')
                {
                    char q = Peek();
                    if (q == '(')
                    {
                        Pop();
                    }
                    else return false;
                }
                if (a[i] == '}')
                {
                    char q = Peek();
                    if (q == '{')
                    {
                        Pop();
                    }
                    else return false;
                }
                if (a[i] == ']')
                {
                    char q = Peek();
                    if (q == '[')
                    {
                        Pop();
                    }
                    else return false;
                }
            }
            return (N == -1) ? true : false;
        }
        public static char[] Postfix(char[] a) //Перевод из инфиксной в постфиксную запись
        {
            char[] arr = new char[100];
            int i = 0;
            int j = 0;
            if (Control(a))
            {
                while (i < a.Length)
                {
                    if (char.IsNumber(a[i]))
                    {
                        arr[j] = a[i];
                        i++;
                        j++;
                        continue;
                    }
                    if (a[i] == '#')
                    {
                        if (Peek() == '+' || Peek() == '-' || Peek() == '*' || Peek() == '/')
                        {
                            arr[j] = Pop();
                            j++;
                        }
                        if (Peek() == '#') return arr;
                        else
                        {
                            Push(a[i]);
                            i++;
                            continue;
                        }
                    }
                    if (a[i] == '+' || a[i] == '-')
                    {
                        if (Peek() == '#' || Peek() == '(')
                        {
                            Push(a[i]);
                            i++;
                            continue;
                        }
                        if (Peek() == '+' || Peek() == '-' || Peek() == '*' || Peek() == '/')
                        {
                            arr[j] = Pop();
                            j++;
                        }
                        else { Console.WriteLine("Error!"); break; }
                    }
                    if (a[i] == '*' || a[i] == '/')
                    {
                        if (Peek() == '#' || Peek() == '(' || Peek() == '+' || Peek() == '-')
                        {
                            Push(a[i]);
                            i++;
                            continue;
                        }
                        if (Peek() == '*' || Peek() == '/')
                        {
                            arr[j] = Pop();
                            j++;
                        }
                        else { Console.WriteLine("Error!"); break; }
                    }
                    if (a[i] == '(')
                    {
                        if (Peek() == '#' || Peek() == '(' || Peek() == '+' || Peek() == '-' || Peek() == '*' || Peek() == '/')
                        {
                            Push(a[i]);
                            i++;
                            continue;
                        }
                        else { Console.WriteLine("Error!"); break; }
                    }
                    if (a[i] == ')')
                    {
                        if (Peek() == '+' || Peek() == '-' || Peek() == '*' || Peek() == '/')
                        {
                            arr[j] = Pop();
                            j++;
                        }
                        if (Peek() == '(') { i++; Pop(); }
                    }
                    else { Console.WriteLine("Error!"); break; }
                }
                return arr;
            }
            return null;
        }

        static void Main(string[] args)
        {
            string s = "#(((1+2)+(3-4))-(5*6))/10#";
            char[] a = new char[s.Length];
            char[] b = new char[100];
            a = s.ToCharArray();
            b = Postfix(a);
            foreach (var el in b)
            {
                Console.Write(el);
            }
            Console.ReadKey();
        }
    }
}
