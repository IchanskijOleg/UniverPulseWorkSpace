using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoLinledList park = new AutoLinledList();
            park.AddFirst(new Bus(1, "Vasya", 111));
            park.AddLast(new Bus(2, "Tasya", 112));
            park.AddFirst(new Bus(3, "Masya", 113));
            foreach (var item in park)
            {
                Console.WriteLine(item.ToString());  
            }
           // park.Print();
           //IEnumerator iter = park

            Console.ReadKey();
        }
    }
}
