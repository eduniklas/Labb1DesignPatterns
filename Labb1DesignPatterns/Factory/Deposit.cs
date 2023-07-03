using System;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Factory
{
    public class Deposit : IBankAction
    {
        public void Transaction()
        {
            Console.WriteLine("Money have been added to your account");
        }
    }
}
