using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp13
{
    public class Value
    {
        public int Data = 10;
    }

    public class Program
    {
        static void PrintY(string name)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("y");
            }
        }

        static void PrintX(string name)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("x");
            }
        }

        static void Print()
        {
            PrintX("x");
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Start");

            Value data = new Value { Data = 1 };

            string x = "2";
            Thread th1 = new Thread(() => { PrintX(x); });
            Thread th2 = new Thread(() => { PrintY(x); });

            th1.IsBackground = true;
            th2.IsBackground = true;

            th1.Start();
            th2.Start();
            Thread.Sleep(2000);

            th1.Join();
            th2.Join();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("End");

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                int i1 = i;
                new Thread(() => Console.Write(i1)).Start();
            }

            Console.ReadKey();
        }
    }
}
