using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Strategy
{
    public class Yen : ICurrency
    {
        public double CalculateCurrency(double amount)
        {
            Console.WriteLine("Rate: 1Sek = 13.40Yen");
            return amount * 13.40;
        }
    }
}
