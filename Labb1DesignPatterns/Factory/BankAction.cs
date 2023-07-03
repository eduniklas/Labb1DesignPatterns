using Labb1DesignPatterns.Strategy;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns.Factory
{
    public class BankAction
    {
        private List<Tuple<string, IBankActionFactory>> bankActions
            = new List<Tuple<string, IBankActionFactory>>();

        private List<Tuple<string, ICurrency>> currencys
            = new List<Tuple<string, ICurrency>>();

        public BankAction()
        {
            foreach(var action in typeof(BankAction).Assembly.GetTypes())
            {
                if(typeof(IBankActionFactory).IsAssignableFrom(action) && !action.IsInterface)
                {
                    bankActions.Add(Tuple.Create(action.Name.Replace("Factory", string.Empty),
                        (IBankActionFactory)Activator.CreateInstance(action)));
                }
            }
            foreach(var currency in typeof(BankAction).Assembly.GetTypes())
            {
                if(typeof(ICurrency).IsAssignableFrom(currency) && !currency.IsInterface)
                {
                    currencys.Add(Tuple.Create(currency.Name,
                        (ICurrency)Activator.CreateInstance(currency)));
                }
            }
        }
        public IBankAction CreateAction()
        {
            while(true)
            {
                for(var index = 0; index < bankActions.Count; index++)
                {
                    var action = bankActions[index];
                    Console.WriteLine($"{index}: {action.Item1}");
                }
                Console.WriteLine("Select a number");

                string a;
                if ((a = Console.ReadLine()) != null
                    && int.TryParse(a, out int i)
                    && i >= 0
                    && i < bankActions.Count)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine(bankActions[i].Item1 + "\n");
                        Console.WriteLine("What currency?");
                        for (var index = 0; index < currencys.Count; index++)
                        {
                            var action = currencys[index];
                            Console.WriteLine($"{index}: {action.Item1}");
                        }
                        Console.WriteLine("Select a number");
                        a = Console.ReadLine();
                        if (a != null
                            && int.TryParse(a, out int currency)
                            && currency >= 0
                            && currency < currencys.Count)
                        {
                            Console.Clear();
                            Console.WriteLine(currencys[currency].Item1 +"\n");
                            Console.WriteLine($"How much money?");
                            a = Console.ReadLine();
                            if(a != null
                                && int.TryParse(a, out int total)
                                && total >= 0)
                            {
                                return bankActions[i].Item2.CreateBankAction(currencys[currency].Item2, total);
                            }
                        }
                    }   
                }
                Console.WriteLine("Number must exist in the menu");
            }
        }
    }
}
