using Labb1DesignPatterns.Factory;
using Labb1DesignPatterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Singleton
{
    //Singelton
    internal class Application
    {
        private static Application myInstance = null;
        private static readonly object lockObject = new object();

        private Application() 
        {
            var action = new BankAction();
            IBankAction bankAction = action.CreateAction();
            bankAction.Transaction();

            var smsObserver = new SMSObserver();
            smsObserver.Notify(bankAction);
        }
        public static Application Instance()
        {
            if (myInstance == null)
            {
                lock (lockObject)
                {
                    if(myInstance == null) 
                    {
                        myInstance = new Application();
                    }
                }
            }
            return myInstance;   
        }
    }
}
