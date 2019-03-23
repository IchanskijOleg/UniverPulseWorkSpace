using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp04
{
    delegate void DelegateSort(int[] mas);

    class Program
    {
        static void BubbleSort(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length - 1 - i; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        int t = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = t;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
<<<<<<< HEAD
            int[] mas = { 1, 0, 6 };
            BubbleSort(mas);
=======
            Action<int[]> Sort = BubbleSort;
            DelegateSort Sort1 = BubbleSort;

            int[] mas = { 1, 2, -2, 3, 4, 5, -5, 6, 2 };
            Sort(mas);
            foreach (var item in mas)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            int[] mas1 = { 1, 2, -2, 3, 4, 5, -5, 6, 2 };
            Sort(mas1);
            foreach (var item in mas)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            int[] mas2 = { 1, 2, -2, 3, 4, 5, -5, 6, 2 };
            Sort(mas2);
            foreach (var item in mas)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            int[] mas3 = { 1, 2, -2, 3, 4, 5, -5, 6, 2 };
            Sort(mas3);
            foreach (var item in mas)
            {
                Console.Write(item + ", ");
            }

            Console.ReadKey();
>>>>>>> origin/master

        }
    }
}
