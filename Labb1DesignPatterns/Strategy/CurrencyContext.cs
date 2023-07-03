using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Strategy
{
    //Strategy
    public class CurrencyContext
    {
        private readonly ICurrency _currency;
        public CurrencyContext(ICurrency currency) 
        {
            _currency = currency;
        }
        public double CalculateCurrency(double amount)
        {
            return _currency.CalculateCurrency(amount);
        }
    }
}
