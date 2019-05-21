using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp131
{
    public class Buffer
    {
        int value;
        bool empty = true;
        public void Put(int v) //ложить
        {
            lock (this) //Monitor.Enter(this);
            {
                while (!empty) Monitor.Wait(this);

                value = v;
                Console.WriteLine("Put = {0}", v);
                empty = false;
                Monitor.PulseAll(this);
            }//Monitor.Exit(this);

        }
        public int Get() //извлекать
        {
            Monitor.Enter(this);
            while (empty) Monitor.Wait(this);

            Console.WriteLine("Get = {0}", value);
            empty = true;
            //data value;
            Monitor.PulseAll(this);

            Monitor.Exit(this);
            return value;
        }
    }
}
