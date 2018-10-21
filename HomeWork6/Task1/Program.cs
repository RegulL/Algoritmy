using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    //Павлов Василий
    //1. Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе сумма кодов
    //символов.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();
            char[] a = new char[s.Length];
            a = s.ToCharArray();
            int q = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    q = q + (int)a[i] * a.Length;
                }
                else
                {
                    q =q + (int)a[i] * i * (i + a.Length);
                }
            }
           
            Console.WriteLine(q);
            Console.ReadKey();
        }
    }
}
