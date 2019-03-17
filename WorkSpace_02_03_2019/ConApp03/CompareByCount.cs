using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp03
{
    class CompareByCount : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Count - y.Count;
        }
    }
}
