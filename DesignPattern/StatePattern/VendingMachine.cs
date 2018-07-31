using System;

namespace StatePattern
{
    public class VendingMachine
    {
        public int NumberOfItems;
        public IVendingMachineState SoldOutState;
        public IVendingMachineState NoMoneyState;
        public IVendingMachineState HasMoneyState;
        public IVendingMachineState SoldState;

        public IVendingMachineState CurrentState;

        public VendingMachine(int numberOfItems)
        {
            this.NumberOfItems = numberOfItems;
            this.SoldOutState = new SoldOutState(this);
            this.NoMoneyState = new NoMoneyState(this);
            this.HasMoneyState = new HasMoneyState(this);
            this.SoldState = new SoldState(this);
            if (numberOfItems > 0)
            {
                this.CurrentState = this.NoMoneyState;
            }
        }

        public void InsertMoney()
        {
            this.CurrentState.HasMoney();
        }


        public void ChoseItem()
        {
            this.CurrentState.HasItem();
            this.CurrentState.Dispense();
        }

        public void ReleaseItem()
        {
            Console.WriteLine("Item is in tray");
            if(this.NumberOfItems == 0) return;
            this.NumberOfItems--;
        }
    }
}