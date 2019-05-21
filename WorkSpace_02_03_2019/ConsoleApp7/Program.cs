using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<int> st; st.
            StackVagon train = new StackVagon();
            StackVagon pass = new StackVagon();
            StackVagon cargo = new StackVagon();
            Random r = new Random();
            //Creator.Create(out train, 10);
            using(StreamReader sr = new StreamReader(@"D:\train.txt"))
            while (!sr.EndOfStream)
            {
                int type = int.Parse(sr.ReadLine());
                train.Push(new Vagon((VagonEnum)type));
            }
            //while (!train.IsFull())
            //{
            //    train.Push(new Vagon((VagonEnum)(r.Next(0, 2))));
            //}
            //train.Push(new Vagon((VagonEnum)(r.Next(0, 2))));
            train.Print();

            while (!train.IsEmpty())
            {
                if (train.Peek().Type.Equals(VagonEnum.Cargo))
                {
                    cargo.Push(train.Pop());
                }
                else
                {
                    pass.Push(train.Pop());
                }                
            }
            train.Print();
            cargo.Print();
            pass.Print();
            Creator.SaveToFile(pass, @"D:\pass.txt");
            Creator.SaveToFile(cargo, @"D:\cargo.txt");

            Console.ReadLine();
        }
    }
}
