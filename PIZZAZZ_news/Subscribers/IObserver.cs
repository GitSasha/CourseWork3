using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIZZAZZ_news.News;

namespace PIZZAZZ_news.Subscribers
{
    public interface IObserver
    {
        void Update(string daria_m, string dmitry_k, string inna_s, string kristina_v, string matvey_b);
        void Display();
    }
}
