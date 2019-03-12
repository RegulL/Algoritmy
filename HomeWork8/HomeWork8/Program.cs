using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{ 
    class Program
    {
        // Павлов Василий

        public static int[] CountingSort(int[] a)//1. Реализовать сортировку подсчетом.

        {
            int[] b = new int[1000];
            int i;
            for (i = 0; i < a.Length; i++)
            {
                b[a[i]]++;
            }
            int j;
            int q = 0;
            for (j = 0; j < b.Length; j++)
                for (i = 0; i < b[j]; i++)
                {
                    a[q++] = j;
                }
            return a;
        }
        public static void quickSort(int[] array, int first, int last)//2. Реализовать быструю сортировку.
        {
            int i = first, j = last, x = array[(first + last) / 2];

            do
            {
                while (array[i] < x)
                    i++;
                while (array[j] > x)
                    j--;
                if (i <= j)
                {
                    if (array[i] > array[j])
                    {
                        int t;
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }

                    i++;
                    j--;
                }
            } while (i <= j);
            if (i < last)
                quickSort(array, i, last);
            if (first < j)
                quickSort(array, first, j);
        }
        public static void MergeSort(ref int[] m, int l, int r)  //3. *Реализовать сортировку слиянием.
        {

            if (l < r)
            {
                int middle = (l + r) / 2;
                MergeSort(ref m, l, middle);
                MergeSort(ref m, middle + 1, r);
                int middle1 = middle + 1;
                int oldPosition = l;
                int size = r - l + 1;
                int[] temp = new int[size];
                int i = 0;
                while (l <= middle && middle1 <= r)
                {
                    if (m[l] <= m[middle1])
                        temp[i++] = m[l++];
                    else
                        temp[i++] = m[middle1++];
                }
                if (l > middle)
                    for (int j = middle1; j <= r; j++)
                        temp[i++] = m[middle1++];
                else
                    for (int j = l; j <= middle; j++)
                        temp[i++] = m[l++];
                Array.Copy(temp, 0, m, oldPosition, size);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 5, 6, 6, 1, 3, 2, 1, 2, 3, 1, 4, 7, 15, 24, 56, 66, 86, 1, 41, 51, 83, 92, 13, 22, 35, 24, 17, 16, 44, 45, 24, 17, 27, 47, 15 };
            arr = CountingSort(arr);
            //quickSort(arr, 0, arr.Length - 1);
            //MergeSort(ref arr, 0, arr.Length - 1);
            foreach (int el in arr)
            {
                Console.Write(el + " ");
            }
            Console.ReadKey();
        }
    }
}

