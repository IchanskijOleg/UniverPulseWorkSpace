using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class ColorPoint : Point, IColorAble
    {

        public ColorPoint(int x, int y, string color) : base(x, y)
        {
            Color = color;
        }

        public string Color { get; set; }

        public override string ToString()
        {
            return $"{base.ToString() }, { Color}";
        }
    }
}
