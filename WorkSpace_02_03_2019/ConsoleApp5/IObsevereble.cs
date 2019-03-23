using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyNews
{
    //наблюдаемое
    public interface IObsevereble
    {
        void Register(IObserver obs);
        void Delete(IObserver obs);
        void Notify();//отключение
    }
}
