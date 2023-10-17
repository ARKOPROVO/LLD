using NotifyMe.Observable;
using NotifyMe.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StocksObservable iphoneStocksObservable = new IPhoneObservableImpl();

            NotificationAlertObserver observer1 = new EmailAlertObserverImpl("xyz1@gmail.com", iphoneStocksObservable);
            NotificationAlertObserver observer2 = new MobileAlertObserverImpl("xyz2@gmail.com", iphoneStocksObservable);
            NotificationAlertObserver observer3 = new EmailAlertObserverImpl("xyz3@gmail.com", iphoneStocksObservable);

            iphoneStocksObservable.add(observer1);
            iphoneStocksObservable.add(observer2);
            iphoneStocksObservable.add(observer3);

            iphoneStocksObservable.setStockCount(10);
            Console.ReadKey();
        }
    }
}
