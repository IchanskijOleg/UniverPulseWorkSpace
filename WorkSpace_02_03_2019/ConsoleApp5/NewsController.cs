using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyNews
{
    class NewsController : IObseverable
    {
        //розсилка наблюдателям
        //регестриция наблюд
        //выдписка

        private News news;
        public List<IObserver> observer = new List<IObserver>();
       
        //удалить
        public void Delete(IObserver obs)
        {
            observer.Remove(obs);
        }

        //уведомить
        public void Notify()
        {
            foreach (var item in observer)
            {
                item.Update(news);
            }
        }

        public void Register(IObserver obs)
        {
            observer.Add(obs);
        }

        public void ChangeNews(News news)
        {
            this.news = news;
            Notify();
        }
    }
}
