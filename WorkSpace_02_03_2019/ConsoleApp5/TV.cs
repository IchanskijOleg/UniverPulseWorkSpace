using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyNews
{
    public class TV : IObserver
    {
        public void Update(News news)
        {
            Console.WriteLine("TV :" + news);
        }
    }
}
