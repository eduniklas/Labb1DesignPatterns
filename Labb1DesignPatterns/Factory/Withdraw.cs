using System;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Factory
{
    public class Withdraw : IBankAction
    {
        public void Transaction()
        {
            Console.WriteLine("Money have been taken out from your account");
        }
    }
}
