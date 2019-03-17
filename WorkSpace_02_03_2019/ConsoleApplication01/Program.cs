using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(3, 3);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            ColorPoint cp1 = new ColorPoint(2, 2, "Red");
            Console.WriteLine(cp1);

            Line l1 = new Line(p1, p2); //агрегация по ссылке
            //Line l2 = new Line(4, 4, 5, 5); //композиция по значению
            Line l2 = new Line(new Point(4, 4), new Point(5, 5));
            Console.WriteLine(l1);
            Console.WriteLine(l2);

            ColorLine cl1 = new ColorLine(p1, p2, "Green");
            Console.WriteLine(cl1);

            Triangle tr = new Triangle(p1, p2, new Point(3, 1));
            Console.WriteLine("Length AC=" + tr.GetLengthAC());
            Console.WriteLine("Length AB=" + tr.GetLengthAB());
            Console.WriteLine("Length BC=" + tr.GetLengthBC());

            Console.WriteLine(new string('-',40));
            AbstractFigure[] masFig = new AbstractFigure[4];
            masFig[0] = p1;
            masFig[1] = cp1;
            masFig[2] = l1;
            masFig[3] = tr;
            //masFig[4] = new AbstractFigure();

            IColorAble[] masColor = new IColorAble[masFig.Length];
            //int colorCount 

            foreach (var item in masFig)
            {
                //Console.WriteLine(item);
                if (item is Point)
                {
                    Console.WriteLine(((Point)item).X);
                }
                IColorAble colorAble = item as IColorAble;
            }
            Console.WriteLine(new string('-', 40));
            //Line[] arrayLine = new Line[] { new Line(p1, p2), l1, l2 };
            Line[] arrayLine = new Line[] { tr.SideAB, tr.SideAC, tr.SideBC };
            Console.WriteLine(FigureControl.GetMaxLength(arrayLine));

            Console.ReadKey();
        }
    }
}
