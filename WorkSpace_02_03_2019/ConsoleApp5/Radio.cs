using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyNews
{
    class Radio : IObserver
    {
        public void Update(News news)
        {
            Console.WriteLine("Radio :" + news);
        }
    }
}
