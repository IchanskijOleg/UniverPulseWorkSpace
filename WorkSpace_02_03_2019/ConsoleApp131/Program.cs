using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp131
{

    public class Program
    {
        static void Main(string[] args)
        {
            Buffer buf = new Buffer();
            Prodycer p = new Prodycer(buf);
            Customer c = new Customer(buf);
            Prodycer p1 = new Prodycer(buf);

            Console.ReadKey();
        }
    }
}
