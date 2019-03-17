using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp03
{
    class Program
    {

        static void Main(string[] args)
        {


            int[] mas = { 1, 9, 5, 0 };
            Array.Sort(mas);

            foreach (var item in mas)
            {
                Console.Write(item + ", ");
            }
            //Product[] product = new Product[]
            //{
            //    new Product() { Id = 1, Count=10, Name = "Apple",Price = 20 }
            //}; 
            //теж саме тільки по іншому записано
            Product[] product = {
                                new Product() { Id = 1, Count=10, Name = "Apple1",Price = 20 },
                                new Product() { Id = 2, Count=20, Name = "Apple5",Price = 25 },
                                new Product() { Id = 3, Count=15, Name = "Apple7",Price = 10 },
                                new Product() { Id = 4, Count=40, Name = "Apple4",Price = 20 }
                                };
            //Array.Sort(product);
            Array.Sort(product, new CompareByCount());
            Array.Sort(product, new CompareByPrice());
            Array.Sort(product, new CompareByName());

            Console.WriteLine("\n" + new string('-', 40));

            foreach (var item in product)
            {
                Console.WriteLine(item + ", ");
            }
            Console.WriteLine(new string('-',50));
            Product p1 = new Product() { Id = 1, Count = 10, Name = "Apple1", Price = 20 };
            Product p2 = p1.Clone() as Product;
            Console.WriteLine(p2);

            Console.ReadKey();
        }
    }
}
