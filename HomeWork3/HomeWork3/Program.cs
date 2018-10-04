using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{

    class Program
    {
        //Павлов Василий
        //1. Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения
        //оптимизированной и не оптимизированной программы.Написать функции сортировки, которые
        //возвращают количество операций.
        public static int[] Create(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
            return arr;
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int a = arr[i];
                Console.Write(a + " ");
            }
        }
        public static long count = 0;
        static public int[] BubbleSort(int[] arr) //  Пузырек
        {
            int t;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    count ++;
                    if (arr[j] > arr[j + 1])
                    {
                        count++;
                        t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;                        
                    }
                }
            }
            return arr;
        }

        static public int[] BubbleSort2(int[] arr) // Оптимизированный пузырек
        {
            bool flag = true;
            int t;
            for (int i = 0; (i < arr.Length) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    count++;
                    if (arr[j] > arr[j + 1])
                    {
                        count++;
                        t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;                        
                        flag = true;
                    }
                }
            }
            return arr;
        }
        public static int[] Sort1(int[] arr) //Сортировка методом выбора
        {
            int jmin;
            for (int i = 0; i < arr.Length; i++)
            {
                jmin = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    count++;  
                    if (arr[j] < arr[jmin])
                    {
                        jmin = j;
                        count++;
                    }
                    int t = arr[i];
                    arr[i] = arr[jmin];
                    arr[jmin] = t;                    
                }
            }            return arr;        }
        public static int[] Sort2(int[] arr) //Сортировка вставками
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int q = arr[i];
                int j = i;
                count++;
                while (j > 0 && arr[j - 1] > q)
                {
                    int t = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = t;
                    j--;
                    count++;
                }
            }
            return arr;
        }
        //***************************************************************************
        //2. *Реализовать шейкерную сортировку.
        public static int[] ShakerSort(int[] arr)
        {
            int begin, end;
            for(int i = 0; i<(arr.Length/2) ; i++)
            {
                begin = 0;
                end = arr.Length - 1;
                count++;
                do
                {
                    count += 2;
                    if (arr[begin] > arr[begin + 1])
                    {
                        int t = arr[begin];
                        arr[begin] = arr[begin + 1];
                        arr[begin + 1] = t;
                        //count++;
                    }
                    begin++;
                    if (arr[end - 1] > arr[end])
                    {
                        int r = arr[end - 1];
                        arr[end - 1] = arr[end];
                        arr[end] = r;
                        //count++;
                    }
                    end--;
                } while (begin <= end);
            }
            return arr;
        }
        //*********************************************************************
        //3. Реализовать бинарный алгоритм поиска в виде функции, которой передается отсортированный
        //массив.Функция возвращает индекс найденного элемента или -1, если элемент не найден.
        public static int Search(int[] arr, int value)
        {
            int L, R, M;
            L = 0;
            R = arr.Length - 1;
            M = L + (R - L)/2;            while (R >= L && arr[M] != value)
            {
                if (value > arr[M])
                {
                    L = M + 1;
                }
                else
                {
                    R = M - 1;
                }
                M = L + (R - L) / 2;
            }
            if (arr[M] == value) return M + 1;
            else return -1;
        }
        //**************************************************************************************************
        static void Main(string[] args)
        {            
            int[] m = new int[100];
            Create(m);
            
            
            //StreamWriter sw = new StreamWriter("text.txt");
            //sw.WriteLine(m.Length);
            //foreach (int i in m)
            //{
            //    sw.WriteLine(i);
            //}
            //sw.Close();
            
            //StreamReader sr = new StreamReader("text.txt");
            //int c = Int32.Parse(sr.ReadLine());
            //int[] p = new int[c];
            //for (int i = 0; i <c; i++)
            //{
            //    p[i] = Int32.Parse(sr.ReadLine());
            //}
            //sr.Close();


            BubbleSort(m);
            //BubbleSort2(m);
            //Sort1(m);
            //Sort2(m);
            //ShakerSort(m);
            int q = Search(m, 30);
            Print(m);
            Console.WriteLine();
            Console.WriteLine(count);
            Console.WriteLine(q);
            Console.ReadKey();
        }
    }
}
