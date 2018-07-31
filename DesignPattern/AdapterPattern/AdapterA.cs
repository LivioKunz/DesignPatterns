using System.Linq;

namespace AdapterPattern
{
    public class AdapterA : IAdapter
    {
        public AdapterA(OtherProduct otherProduct)
        {
            this.AdapterAProduct = otherProduct;
        }

        private OtherProduct AdapterAProduct { get; }

        public void Update(float width, float height)
        {
            this.AdapterAProduct.UpdateProduct($"{width};{height}");
        }

        public float GetHeight()
        {
            string height = this.AdapterAProduct.WidthHeight.Split(';').Last();
            return float.Parse(height);
        }
    }
}