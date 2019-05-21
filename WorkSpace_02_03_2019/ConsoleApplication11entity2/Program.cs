using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11entity2
{
    class Program
    {
        static void Main(string[] args)
        {
            BusesContext park = new BusesContext();

            foreach (var item in park.buses)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
