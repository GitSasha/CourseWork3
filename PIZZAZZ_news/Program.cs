using System;
using PIZZAZZ_news.News;
using PIZZAZZ_news.Subscribers;

namespace PIZZAZZ_news
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAggregator = new NewsAggregator();
            var dariaM = new DariaM();
            var dmitryK = new DmitryK();
            var innaS = new InnaS();
            var kristinaV = new KristinaV();
            var matveyB = new MatveyB();

            newsAggregator.RegisterObserver(dariaM);
            newsAggregator.RegisterObserver(dmitryK);
            newsAggregator.RegisterObserver(innaS);
            newsAggregator.RegisterObserver(kristinaV);
            newsAggregator.RegisterObserver(matveyB);

            Console.WriteLine("First newsletter:");
            newsAggregator.NewNewsAvailable();
            Console.WriteLine();
            Console.WriteLine();
            newsAggregator.RemoveObserver(dariaM);
            newsAggregator.RemoveObserver(kristinaV);
            Console.WriteLine("Second newsletter:");
            newsAggregator.NewNewsAvailable();
            Console.ReadLine();
        }
    }
}
