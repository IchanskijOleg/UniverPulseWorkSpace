using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;


namespace ConsoleAppWCFClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            Uri address = new Uri("http://localhost:8010/Calc");
            //Uri address = new Uri("http://192.168.0.94:8010/Calc");
            Binding bind = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress(address);
            ChannelFactory<ICalc> channelFactory = new ChannelFactory<ICalc>(bind, endpoint);
            ICalc calc = channelFactory.CreateChannel();

            Console.WriteLine(calc.Multy(3, 4));
            Console.WriteLine(calc.Multy(13, 14));
            Console.ReadKey();
        }
    }
}
