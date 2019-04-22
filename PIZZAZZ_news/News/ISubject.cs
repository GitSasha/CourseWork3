using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIZZAZZ_news.Subscribers;

namespace PIZZAZZ_news.News
{
    public interface ISubject
    {
        void RegisterObserver(Subscribers.IObserver observer);
        void RemoveObserver(Subscribers.IObserver observer);
        void NotifyObservers();
    }
}
