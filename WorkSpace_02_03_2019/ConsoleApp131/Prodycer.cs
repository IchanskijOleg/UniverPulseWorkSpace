using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp131
{
    public class Prodycer
    {
        Buffer buf;
        public Prodycer(Buffer buf)
        {
            this.buf = buf;
            new Thread(Run).Start();
        }
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                buf.Put(i);
            }
        }
    }
}
