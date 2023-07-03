using Labb1DesignPatterns.Strategy;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Factory
{
    internal class DepositFactory : IBankActionFactory
    {
        public IBankAction CreateBankAction(ICurrency currency, double amount)
        {
            Console.WriteLine($"Adding {amount} {currency.GetType().Name} to your account");
            Thread.Sleep(4000);
            Console.Clear();
            return new Deposit();
        }
    }
}
