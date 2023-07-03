using Labb1DesignPatterns.Strategy;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Factory
{
    public interface IBankActionFactory
    {
        IBankAction CreateBankAction(ICurrency currency ,double amount);
    }
}
