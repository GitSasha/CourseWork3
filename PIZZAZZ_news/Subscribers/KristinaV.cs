using System;
using PIZZAZZ_news.News;

namespace PIZZAZZ_news.Subscribers
{
    class KristinaV : IObserver
    {
        private string _kristina_v;

        public void Update(string daria_m, string dmitry_k, string inna_s, string kristina_v, string matvey_b)
        {
            _kristina_v = kristina_v;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Kristina V: {0}", _kristina_v);
        }
    }
}
