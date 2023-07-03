using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Strategy
{
    public class GBP : ICurrency
    {
        public double CalculateCurrency(double amount)
        {
            Console.WriteLine("Rate: 1Sek = 0.073£");
            return amount * 0.073;
        }
    }
}
