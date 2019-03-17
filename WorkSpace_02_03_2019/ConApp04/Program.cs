using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp04
{
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
            int[] mas = { 1, 0, 6 };
            Sort(mas);

        }
    }
}
