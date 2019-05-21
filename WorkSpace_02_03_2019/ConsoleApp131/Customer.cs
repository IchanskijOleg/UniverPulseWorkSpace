using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp131
{
    class Customer
    {
        public Buffer buf;
        public Customer(Buffer buf)
        {
            this.buf = buf;
            new Thread(Run).Start();
        }
        public void Run()
        {
            int sum = 0;
            while (true)
            {
                Interlocked.Add(ref sum, buf.Get());
                //sum += buf.Get();
                Console.WriteLine("sum = " + sum);
                if (sum >= 55*2) break;
            }
        }
    }
}
