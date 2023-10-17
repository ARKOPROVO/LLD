using NotifyMe.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyMe.Observer
{
    public class MobileAlertObserverImpl : NotificationAlertObserver
    {
        string emailId;
        StocksObservable observable;
        public MobileAlertObserverImpl(string emailId, StocksObservable observable)
        {
            this.emailId = emailId;
            this.observable = observable;
        }

        public void update()
        {
            sendMsgOnMobile(emailId, "product is in stock");
        }

        private void sendMsgOnMobile(string emailId, string v)
        {
            Console.WriteLine("message sent to: " + emailId);
        }
    }
}
