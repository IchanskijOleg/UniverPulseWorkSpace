using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class StackVagon
    {
        private Vagon[] mas;
        private int top;

        public StackVagon()
        {
            mas = new Vagon[10];
            top = -1;
        }

        public Vagon Pop() //выталкивать
        {
            if (!IsEmpty())
            {
                Vagon v = mas[top];
                mas[top] = null;
                top--;
                //return mas[top--];
                return v;
            }
            else
            {
                return null;
            }
        }

        //заталкивать
        public void Push(Vagon v)
        {
            //if (!IsFull())
            //{
            //    mas[++top] = v;
            //}
            //else
            //{
            //    //throw new IndexOutOfRangeException();
            //    //throw new StackVagonException();
            //    EnsureCapasity();
            //}
            // переписали
            if (IsFull())
            {
                EnsureCapasity(); // добавляємо 
            }
            mas[++top] = v;

        }
        //показывать вехний елемент
        public Vagon Peek() { return mas[top]; }

        public bool IsEmpty() { return top == -1; }

        public bool IsFull() { return top == mas.Length - 1; }

        public int Count() { return top + 1; }

        public void Print()
        {
            Console.WriteLine(new string('-', 25));
            foreach (var item in mas)
            {
                Console.Write(item + ", ");
            }
            //for (int i = 0; i < Count(); i++)
            //{
            //    Console.Write(mas[i] + ", ");
            //}
            Console.WriteLine();
            Console.WriteLine(new string('-', 25));
        }
        private void EnsureCapasity()
        {
            Vagon[] temp = new Vagon[mas.Length * 2];
            Array.Copy(mas, temp, mas.Length);
            mas = temp;
        }
    }
}
