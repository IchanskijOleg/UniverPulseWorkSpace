using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp03
{
    class Product : IComparable<Product>, ICloneable
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public CCity city { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Count}, {Name}, {Price}";
        }

        public int CompareTo(Product other)
        {
            if ((Price - other.Price) > 0.0001)
            {
                return (int)(Price - other.Price);
            }
            else
            {
                return Count - other.Count;
            }
        }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        //public int CompareTo(object obj)
        //{
        //    return Count - (obj as Product).Count;
        //}
    }
}
