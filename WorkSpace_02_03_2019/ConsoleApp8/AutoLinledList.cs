using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class AutoLinledList : IEnumerable
    {
        public AutoNodeLinkedList Head { get; set; }
        public AutoNodeLinkedList Tail { get; set; }
        public void AddFirst(Bus data)
        {
            AutoNodeLinkedList node = new AutoNodeLinkedList { Data = data };
            if (Head == null) { Head = node; Tail = node; }
            else
            {
                node.Next = Head;
                Head.Prev = node;
                Head = node;
            }
        }
        public void AddLast(Bus data)
        {
            AutoNodeLinkedList node = new AutoNodeLinkedList { Data = data };
            if (Head == null) { Head = node; Tail = node; }
            else
            {
                //AutoNodeLinkedList current = Head;
                //while (current.Next != null)
                //{ 
                //    current = current.Next;
                //}
                //current.Next = node;
                //node.Prev = current;
                Tail.Next = node;
                node.Prev = Tail;
                Tail = node;
            }
        }
        public Bus GetDataByRoute(int route)
        {
            AutoNodeLinkedList current = Head;
            while (current != null)
            {
                if (current.Data.Route == route) return current.Data;
                current = current.Next;
            }
            return null;
        }
        public void RemoveDataByRoute(int route)
        {
            AutoNodeLinkedList current = Head;
            while (current != null)
            {

                if (current == Head)
                {
                    
                }
                else
                 if (current == Tail)
                {

                }
                else
                if (current.Data.Route == route)
                {
                    //current.Data.Route == current.Next;
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
 
                }
                current = current.Next;
            }
 
        }
        public void Print()
        {
            AutoNodeLinkedList current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new EnumeratorAutoLinledList(this);
        }

        //IEnumerator<Bus> IEnumerable<Bus>.GetEnumerator()
        //{
        //    return new EnumeratorAutoLinledList(this);
        //}
    }
}
