using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIZZAZZ_news.Subscribers;

namespace PIZZAZZ_news.News
{
    class NewsAggregator
    {
        //закрытые переменные класса
        private static Random _random;
        private List<Subscribers.IObserver> _observers;

        //конструктор класса: позволяет работать с закрытыми переменными вне класса
        public NewsAggregator()
        {
            _random = new Random();
            _observers = new List<IObserver>();
        }

        /* метод добавления новых наблюдателей. Обозначения параметров:
         * Subscribers - название папки
         * IObserver - название класса
         * observer - название переменной, которое обычно должно совпадать с назв класса. работает внутри метода
         */
        public void RegisterObserver(Subscribers.IObserver observer)
        {
            _observers.Add(observer); //Add - встроенный метод для паттерна наблюдатель
        }

        //метод удаления наблюдателей
        public void RemoveObserver(Subscribers.IObserver observer)
        {
            _observers.Remove(observer); //Remove - встроенный метод
        }

        //метод уведомления всех наблюдателей
        public void NotifyObservers()
        {
            string daria_m = GetPizzazzNews();
            string dmitry_k = GetPizzazzNews();
            string inna_s = GetPizzazzNews();
            string kristina_v = GetPizzazzNews();
            string matvey_b = GetPizzazzNews();

            foreach (var observer in _observers)
            {
                observer.Update(daria_m, dmitry_k, inna_s, kristina_v, matvey_b);
            }
        }

        // какие новости будут получать подписчики (тут: рандомные новости о поступлениях пиццы)
        public string GetPizzazzNews()
        {
            var news = new List<string>
            {
                "Ваша пицца готова!",
                "Весенняя акция: каждая пятая пицца в подарок! Все подробности на сайте tasty_pizzazz.com",
                "Акция 'Пятничная': каждую пятницу при покупке пиццы напиток в подарок! Пусть Ваши выходные начнутся вместе с PIZZAZZ!",
                "Бонусы ко Дню Рождения: 50% на любую пиццу из нашего меню!",
                "Заходите на наш сайт и участвуйте в акции, чтобы выиграть бесплатную пиццу!",
                "Обновление меню: вкуснейшие пиццы по приятным ценам! Максимум удовольствия вместе с PIZZAZZ!"
            };

            return news[_random.Next(5)];
        }

        //метод действий "уведомить наблюдателей" если есть доступная новость
        public void NewNewsAvailable()
        {
            NotifyObservers(); //вызываем метод прописанный выше
        }
    }
}
