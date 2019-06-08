using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWCFServer
{
    public class CalcImpl : ICalc
    {
        public double Multy(double x, double y)
        {
            return x * y;
        }

        public double Sum(double x, double y)
        {
            return x + y;
        }
    }
}
