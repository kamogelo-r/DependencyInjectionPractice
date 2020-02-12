using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    /// <summary>
    /// WRONG
    /// cant send email, logs and sms, can only choose one because they have the same method.
    /// An instance of another class will have to be created, so it can be used
    /// this does not work because if we were to have a new requirement,
    /// adding an instance of another class (in the ctor) will violate the DIP.    ///
    /// A high level module will depend on a lower level module instead of
    /// an abstraction of it
    /// To add another feature, it means adding another instance of that 
    /// class, so at any point we are using one object and not both at once
    /// </summary>
    public class EventLogWriter
    {
        public void Write(string message)
        {
        }
    }

    public class AppPoolWriter
    {
        EventLogWriter writer = null;
        public string mydate;

        private decimal two;

        public AppPoolWriter(decimal two)
        {
            this.two = two;
        }

        public AppPoolWriter()
        {
            this.writer = new EventLogWriter();
            this.mydate = "hello";
        }

        public void Notify(string message)
        {
            if (writer == null)
            {
                writer = new EventLogWriter();
            }

            writer.Write(message);
        }
    }
}


