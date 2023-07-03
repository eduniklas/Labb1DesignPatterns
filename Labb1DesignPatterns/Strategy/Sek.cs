using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Strategy
{
    public class Sek : ICurrency
    {
        public double CalculateCurrency(double amount)
        {
            return amount * 1;
        }
    }
}
