namespace NullObjectPattern
{
    //https://www.codeproject.com/Articles/1042674/NULL-Object-Design-Pattern
    internal class Program
    {
        private static void Main(string[] args)
        {
            Order premiumOrder = new Order(new PremiumDiscount());
            premiumOrder.CalculateDiscount();

            Order festivalOrder = new Order(new FestivalDiscount());
            festivalOrder.CalculateDiscount();

            //here is the pattern
            Order noDiscountOrder = new Order(new NullDiscount());
            noDiscountOrder.CalculateDiscount();
        }
    }
}