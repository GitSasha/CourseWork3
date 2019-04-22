using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIZZAZZ_news.News;
using PIZZAZZ_news.Subscribers;

namespace PIZZAZZ_news
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAggegator = new NewsAggregator();
            var dariaM = new DariaM();
            var dmitryK = new DmitryK();
            var innaS = new InnaS();

            newsAggegator.RegisterObserver(dariaM); //вызываем метод для добавления наблюдателей
            newsAggegator.RegisterObserver(dmitryK);
            newsAggegator.RegisterObserver(innaS);

            newsAggegator.NewNewsAvailable();
            Console.WriteLine();

            newsAggegator.RemoveObserver(dariaM);
            newsAggegator.NewNewsAvailable();

            Console.ReadLine();
        }
    }
}
