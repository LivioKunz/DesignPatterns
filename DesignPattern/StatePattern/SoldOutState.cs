using System;

namespace StatePattern
{
    public class SoldOutState : IVendingMachineState
    {
        public VendingMachine Machine { get; set; }

        public SoldOutState(VendingMachine vendingMachine)
        {
            this.Machine = vendingMachine;
        }

        public void HasMoney()
        {
            Console.WriteLine("Sorry! Sold Out Money doesnt matter");
        }

        public void HasItem()
        {
            Console.WriteLine("Sorry! Sold Out Have no Items");
        }

        public void Dispense()
        {
            Console.WriteLine("Sorry! Sold Out Cant Dispense");
        }
    }
}