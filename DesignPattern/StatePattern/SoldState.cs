using System;

namespace StatePattern
{
    public class SoldState : IVendingMachineState
    {
        public VendingMachine Machine { get; set; }

        public SoldState(VendingMachine vendingMachine)
        {
            this.Machine = vendingMachine;
        }

        public void HasMoney()
        {
            Console.WriteLine("Already sold");
        }

        public void HasItem()
        {
            Console.WriteLine("Already sold");
        }

        public void Dispense()
        {
            this.Machine.ReleaseItem();
            if (this.Machine.NumberOfItems > 0)
            {
                this.Machine.CurrentState = this.Machine.NoMoneyState;
            }
            else
            {
                Console.WriteLine("Sold out!");
                this.Machine.CurrentState = this.Machine.SoldOutState;
            }
        }
    }
}