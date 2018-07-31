namespace StatePattern
{
    public interface IVendingMachineState
    {
        void HasMoney();

        void HasItem();
        
        void Dispense();
    }
}