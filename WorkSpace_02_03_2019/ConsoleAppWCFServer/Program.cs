using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ConsoleAppWCFServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri address = new Uri("http://localhost:8010/Calc");
            Binding bind = new BasicHttpBinding();
            ServiceHost host = new ServiceHost(typeof(CalcImpl), address);
            host.AddServiceEndpoint(typeof(ICalc), bind, "");
            host.Open();
            Console.WriteLine("Service running");
            Console.ReadLine();
            host.Close();
        }
    }
}
