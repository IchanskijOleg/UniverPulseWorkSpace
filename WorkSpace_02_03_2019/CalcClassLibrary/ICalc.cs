using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ConsoleAppWCFServer
{
    [ServiceContract]
    public interface ICalc
    {
        double Sum(double x, double y);
        double Multy(double x, double y);
    }
}
