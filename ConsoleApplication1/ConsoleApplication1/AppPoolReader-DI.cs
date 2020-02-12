using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //CORRECT (Dependency Injection: injecting concrete class into class using the abstraction)
    public interface INotificationActions 
    {
        void ActOnNotifications(string message);
    }

    public class EventLogReader : INotificationActions 
    {
        public void ActOnNotifications(string message)
        {
        }
    }

    public class EmailSenders : INotificationActions
    {
        public void ActOnNotifications(string message)
        {
        }
    }

    public class SMSSenders : INotificationActions
    {
        public void ActOnNotifications(string message)
        {
        }
    }
    public class AppPoolReader //high level class
    {
        INotificationActions action = null;

        public AppPoolReader(INotificationActions concreteImpl)
        {
            this.action = concreteImpl;
        }

        public void Notify(string message)
        {
            action.ActOnNotifications(message);
            //Console.WriteLine(message);
        }
    }
}
