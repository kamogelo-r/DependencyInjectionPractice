using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //CORRECT (Inversion of Control: high level modules depend on low level modules)
    //can now send to email, logs and sms
    public interface INotificationAction //abstraction of low level class
    {
        void ActOnNotification(string message); 
    }

    public class EventLogWatcher : INotificationAction //low level class
    {
        public void ActOnNotification(string message)
        {
        }
    }

    public class EmailSender : INotificationAction
    {
        public void ActOnNotification(string message)
        {
        }
    }

    public class SMSSender : INotificationAction
    {
        public void ActOnNotification(string message)
        {
        }
    }
    public class AppPoolWatcher//high level class
    {
        INotificationAction action = null;
                
        public void Notify(string message)
        {
            if (action == null)
            {

            }

            action.ActOnNotification(message);
        }
    }
}
