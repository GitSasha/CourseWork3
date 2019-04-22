using System;
using PIZZAZZ_news.News;

namespace PIZZAZZ_news.Subscribers
{
    class DmitryK : IObserver
    {
        private string _dmitry_k;

        public void Update(string daria_m, string dmitry_k, string inna_s, string kristina_v, string matvey_b)
        {
            _dmitry_k = dmitry_k;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Dmitry K: {0}", _dmitry_k);
        }
    }
}
