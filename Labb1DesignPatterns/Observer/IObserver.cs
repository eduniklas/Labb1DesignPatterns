using Labb1DesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Observer
{
    //Observer
    public interface IObserver
    {
        void Notify(IBankAction bankAction);
    }
}