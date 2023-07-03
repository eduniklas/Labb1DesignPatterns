using System;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Factory
{
    public class ChangeCurrency : IBankAction
    {
        public void Transaction()
        {
            Console.WriteLine("Currency is now changed");
        }
    }
}
