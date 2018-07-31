namespace NullObjectPattern
{
    public class Order
    {
        private readonly IDiscount Discount;

        public Order(IDiscount discount)
        {
            this.Discount = discount;
        }

        public string ProductName { get; set; }
        public double ProductCost { get; set; }

        public double CalculateDiscount()
        {
            return this.Discount.CalculateDiscount(this.ProductCost);
        }
    }
}