namespace AdapterPattern
{
    public class AdapterB : IAdapter
    {
        public AdapterB(Product product)
        {
            this.AdapterBProduct = product;
        }

        private Product AdapterBProduct { get; }

        public void Update(float width, float height)
        {
            this.AdapterBProduct.UpdateProduct(width, height);
        }

        public float GetHeight()
        {
            return this.AdapterBProduct.Height;
        }
    }
}