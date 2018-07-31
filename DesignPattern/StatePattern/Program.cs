using System;

namespace StatePattern
{
    //https://www.dofactory.com/net/state-design-pattern
    internal class Program
    {
        private static void Main(string[] args)
        {
            var vendingMachine = new VendingMachine(numberOfItems: 4);
            vendingMachine.InsertMoney();
            vendingMachine.ChoseItem();

            Console.ReadLine();
        }
    }
}