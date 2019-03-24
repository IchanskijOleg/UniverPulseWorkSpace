using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyNews
{
    class NewsEvent
    {
        public event Action<News> EventNewsUpdate;
        public void OnEvent(News news)
        {
            if (EventNewsUpdate != null)
            {
                EventNewsUpdate(news);
            }
            if (news.Id == 4)
            {
                Delegate[] masDel = EventNewsUpdate.GetInvocationList();
                for (int i = 0; i < masDel.Length; i++)
                {
                    if (!(masDel[i].Target is TV))
                    {
                        Console.WriteLine(masDel[i].Target);
                        ;                    }
                }
            }
        }
    }
}
