using Labb1DesignPatterns.Strategy;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Factory
{
    public class ChangeCurrencyFactory : IBankActionFactory
    {
        public IBankAction CreateBankAction(ICurrency currency, double amount)
        {
            CurrencyContext change = new(currency);
            double newAmount = change.CalculateCurrency(amount);
            Console.WriteLine($"Changing currency from {amount} Sek to {Math.Round(newAmount, 2)} {currency.GetType().Name}");
            Thread.Sleep(4000);
            Console.Clear();
            return new ChangeCurrency();
        }
    }
}
