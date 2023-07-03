using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Strategy
{
    //Strategy
    public interface ICurrency
    {
        double CalculateCurrency(double amount);
    }
}
