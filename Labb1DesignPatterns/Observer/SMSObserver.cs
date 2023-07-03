using Labb1DesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Observer
{
    internal class SMSObserver : IObserver
    {
        public void Notify(IBankAction bankAction)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nEvent happend on your account: {bankAction.GetType().Name} \nSMS with this information have been sent to the owner of this account.");
            Console.ResetColor();
        }
    }
}
