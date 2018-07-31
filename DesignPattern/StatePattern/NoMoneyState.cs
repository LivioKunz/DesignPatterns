using System;

namespace StatePattern
{
    public class NoMoneyState : IVendingMachineState
    {
        public VendingMachine Machine { get; set; }

        public NoMoneyState(VendingMachine vendingMachine)
        {
            this.Machine = vendingMachine;
        }

        public void HasMoney()
        {
            Console.WriteLine("Inserted a Money");
            this.Machine.CurrentState = this.Machine.HasMoneyState;
        }

        public void HasItem()
        {
            Console.WriteLine("No items with no money!");
        }

        public void Dispense()
        {
            Console.WriteLine("Nothing to dispense without money");
        }
    }
}