namespace NullObjectPattern
{
    public class Order
    {
        public string ProductName { get; set; }
        public double ProductCost { get; set; }

        private IDiscount Discount= null;

        public double CalculateDiscount()
        {
            return this.Discount.CalculateDiscount(this.ProductCost);
        }
        
        public Order(IDiscount discount)
        {
            this.Discount = discount;
        }

    }
}