using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class FigureControl
    {
        public static double GetMaxLength(Line[] masLine)
        {
            Line maxLine = masLine[0];
            foreach (var item in masLine)
            {
                if (maxLine.GetLength() < item.GetLength())
                {
                    maxLine = item;
                }
            }
            return maxLine.GetLength();
        }
    }
}
