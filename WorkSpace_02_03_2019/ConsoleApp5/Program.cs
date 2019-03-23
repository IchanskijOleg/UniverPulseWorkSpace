using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyNews
{
    class Program
    {
        static void ClasiccObsorver(string[] args)
        {
            //Console.WriteLine(DateTime.Now);
            NewsController kyivNews = new NewsController();
            NewsController lvivNews = new NewsController();
            TV tv = new TV();
            Radio radio = new Radio();
            NewsPaper paper = new NewsPaper();

            kyivNews.Register(tv);
            kyivNews.Register(radio);
            kyivNews.Register(paper);

            lvivNews.Register(tv);
            lvivNews.Register(radio);
            lvivNews.Register(paper);

            for (int i = 0; i < 10; i++)
            {
                kyivNews.ChangeNews(new News { City = "Kiev", Id = i, Info = "Spring", Time = DateTime.Now });
                if (i % 2 == 0)
                {
                    lvivNews.ChangeNews(new News { City = "Lviv", Id = i, Info = "Spring", Time = DateTime.Now });
                }
                if (i == 5)
                {
                    kyivNews.Delete(radio);
                }
                if (i == 6)
                {
                    lvivNews.Delete(tv);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);
            //NewsController kyivNews = new NewsController();
            //NewsController lvivNews = new NewsController();
            TV tv = new TV();
            Radio radio = new Radio();
            NewsPaper paper = new NewsPaper();

            Action<News> actionKyiv = tv.Update;
            actionKyiv += radio.Update;
            actionKyiv += paper.Update;

            Action<News> actionLviv = tv.Update;
            actionLviv += radio.Update;
            actionLviv += paper.Update;

            for (int i = 0; i < 10; i++)
            {
                actionKyiv(new News { City = "Kiev", Id = i, Info = "Spring", Time = DateTime.Now });
                if (i % 2 == 0)
                {
                    actionLviv(new News { City = "Lviv", Id = i, Info = "Spring", Time = DateTime.Now });
                }
                if (i == 5)
                {
                    actionKyiv -= radio.Update;
                }
                if (i == 6)
                {
                    actionLviv -= tv.Update;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
