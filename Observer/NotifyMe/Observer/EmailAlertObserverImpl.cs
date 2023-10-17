using NotifyMe.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyMe.Observer
{
    public class EmailAlertObserverImpl : NotificationAlertObserver
    {
        string emailId;
        StocksObservable observable;
        public EmailAlertObserverImpl(string emailId, StocksObservable observable)
        {
            this.emailId = emailId;
            this.observable = observable;
        }

        public void update()
        {
            sendEmail(emailId, "product is in stock");
        }

        private void sendEmail(string emailId, string v)
        {
            Console.WriteLine("mail sent to: " + emailId);
        }
    }
}
