namespace AdapterPattern
{
    public class OtherProduct
    {
        public string WidthHeight { get; set; }

        public void UpdateProduct(string widthHeight)
        {
            this.WidthHeight = widthHeight;
        }
    }
}