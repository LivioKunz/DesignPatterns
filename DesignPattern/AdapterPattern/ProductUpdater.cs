using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ProductUpdater
    {
        public static void Main(string[] args)
        {
           
        }
    }


    public interface IAdapter
    {
        void Update(float width, float height);
    }


    public class AdapterA : IAdapter
    {
        private OtherProduct AdapterAProduct { get; set; }

        public AdapterA(OtherProduct otherProduct)
        {
            AdapterAProduct = otherProduct;
        }

        public void Update(float width, float height)
        {
            AdapterAProduct.UpdateProduct($"{width};{height}");
        }

        public float GetHeight()
        {
            string height = AdapterAProduct.WidthHeight.Split(';').Last();
            return float.Parse(height);
        }
    }

    public class AdapterB : IAdapter
    {
        private Product AdapterBProduct { get; set; }

        public AdapterB(Product product)
        {
            AdapterBProduct = product;
        }

        public void Update(float width, float height)
        {
            AdapterBProduct.UpdateProduct(width,height);
        }

        public float GetHeight()
        {
            return AdapterBProduct.Height;
        }
    }
    

    public class OtherProduct
    {
        public void UpdateProduct(string widthHeight)
        {
            WidthHeight = widthHeight;
        }

        public string WidthHeight { get; set; }
    }

    public class Product
    {
        public void UpdateProduct(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public float Width { get; set; }

        public float Height { get; set; }
    }
}
