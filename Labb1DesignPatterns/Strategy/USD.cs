using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Strategy
{
    public class USD : ICurrency
    {
        public double CalculateCurrency(double amount)
        {
            Console.WriteLine("Rate: 1Sek = $0.093");
            return amount * 0.093;
        }
    }
}
