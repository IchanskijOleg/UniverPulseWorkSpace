using System;
using System.Collections;
using System.Collections.Generic;

namespace AutoPark
{
    internal class EnumeratorAutoLinledList : IEnumerator 
    {
        AutoLinledList list;
        AutoNodeLinkedList current;

        public object Current
        {
            get
            {
                //while (current.Data.Id%2 != 0)
                //{
                //}
                return current.Data;
            }
        }

        public EnumeratorAutoLinledList(AutoLinledList list)
        {
            this.list = list;
        }
        //public Bus Current
        //{
        //    get
        //    {
        //        );
        //    }
        //}

        //object IEnumerator.Current => current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (current == null)
                current = list.Head;
            else
                current = current.Next;
            return current != null;
        }

        public void Reset()
        {
            current = list.Head;
        }
    }
}