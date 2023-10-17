using NotifyMe.Observer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyMe.Observable
{
    public class IPhoneObservableImpl : StocksObservable
    {
        public List<NotificationAlertObserver> observerList = new List<NotificationAlertObserver>();
        public int stockCount = 0;
        public void add(NotificationAlertObserver observer)
        {
            observerList.Add(observer);
        }

        public int getStockCount()
        {
            return stockCount;
        }
        public void remove(NotificationAlertObserver observer)
        {
            observerList.Remove(observer);
        }

        public void setStockCount(int newStockAdded)
        {
            if(stockCount == 0)
            {
                notifySubscribers();
            }
            stockCount = stockCount + newStockAdded;
        }
        public void notifySubscribers()
        {
            foreach(NotificationAlertObserver observer in observerList)
            {
                observer.update();
            }
        }
    }
}
