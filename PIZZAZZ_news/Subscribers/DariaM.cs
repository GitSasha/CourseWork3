using System;
using PIZZAZZ_news.News;

namespace PIZZAZZ_news.Subscribers
{
    class DariaM : IObserver
    {
        private string _daria_m;

        public void Update(string daria_m, string dmitry_k, string inna_s)
        {
            _daria_m = daria_m;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Daria M: {0}", _daria_m);
        }
    }
}
