using Labb1DesignPatterns.Strategy;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Factory
{
    public class WithdrawFactory : IBankActionFactory
    {
        public IBankAction CreateBankAction(ICurrency currency, double amount)
        {
            Console.WriteLine($"Withdrawing {amount} {currency.GetType().Name} from your account");
            Thread.Sleep(4000);
            Console.Clear();
            return new Withdraw();
        }
    }
}
