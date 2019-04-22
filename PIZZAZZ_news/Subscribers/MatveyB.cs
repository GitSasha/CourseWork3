using System;
using PIZZAZZ_news.News;

namespace PIZZAZZ_news.Subscribers
{
    class MatveyB : IObserver
    {
        private string _matvey_b;

        public void Update(string daria_m, string dmitry_k, string inna_s, string kristina_v, string matvey_b)
        {
            _matvey_b = matvey_b;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Kristina V: {0}", _matvey_b);
        }
    }
}
