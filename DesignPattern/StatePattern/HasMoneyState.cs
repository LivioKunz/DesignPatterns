using System;

namespace StatePattern
{
    public class HasMoneyState : IVendingMachineState
    {
        public VendingMachine Machine { get; set; }

        public HasMoneyState(VendingMachine vendingMachine)
        {
            this.Machine = vendingMachine;
        }

        public void HasMoney()
        {
            Console.WriteLine("Money is there");
        }

        public void HasItem()
        {
            this.Machine.CurrentState = this.Machine.SoldState;
        }

        public void Dispense()
        {
            Console.WriteLine("Not yet dispensed");
        }
    }
}