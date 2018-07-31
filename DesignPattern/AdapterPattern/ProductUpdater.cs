using System;

namespace AdapterPattern
{
    public class ProductUpdater
    {
        public static void Main(string[] args)
        {
            AdapterA adapterA = new AdapterA(new OtherProduct());
            adapterA.Update(12f, 12f);
            Console.WriteLine(adapterA.GetHeight());


            AdapterB adapterB = new AdapterB(new Product());
            adapterB.Update(55f, 55f);
            Console.WriteLine(adapterB.GetHeight());
        }
    }
}