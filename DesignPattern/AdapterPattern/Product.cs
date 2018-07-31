namespace AdapterPattern
{
    public class Product
    {
        public float Width { get; set; }

        public float Height { get; set; }

        public void UpdateProduct(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}