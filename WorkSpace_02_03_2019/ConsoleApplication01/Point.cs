using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Point : AbstractFigure
    {
        public Point(int x, int y)
        {
            Y = y;
            X = x;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}"; //String.Format()
        }
    }
}
