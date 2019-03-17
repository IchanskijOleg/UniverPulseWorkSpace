using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class ColorLine : Line, IColorAble
    {
        public ColorLine(Point start, Point end, string color) : base(start, end)
        {
            Color = color;
        }

        public string Color { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, {Color}";
        }
    }
}
