using System;
using PIZZAZZ_news.News;

namespace PIZZAZZ_news.Subscribers
{
    class InnaS : IObserver
    {
        private string _inna_s;

        public void Update(string daria_m, string dmitry_k, string inna_s)
            {
                _inna_s = inna_s;
                Display();
            }

        public void Display()
            {
                Console.WriteLine("Inna S: {0}", _inna_s);
            }
    }
}
