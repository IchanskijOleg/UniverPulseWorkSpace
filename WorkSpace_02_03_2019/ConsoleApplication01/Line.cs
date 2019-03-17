using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Line : AbstractFigure
    {

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
        //public Line(int x1, int y1, int x2, int y2)//композицыя
        //{
        //    Start = new Point(x1, y1);
        //    End = new Point(x2, y2);
        //}
        public Point Start { get; set; }
        public Point End { get; set; }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(Start.X - End.X, 2) + Math.Pow(Start.Y - End.Y, 2));
        }

        public override string ToString()
        {
            return $"{Start}, {End}";
        }
    }
}
