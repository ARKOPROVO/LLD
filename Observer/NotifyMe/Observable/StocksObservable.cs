using NotifyMe.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyMe.Observable
{
    public interface StocksObservable
    {
        void add(NotificationAlertObserver observer);
        void remove(NotificationAlertObserver observer);
        void notifySubscribers();
        void setStockCount(int newStockAdded);
        int getStockCount();
    }
}
