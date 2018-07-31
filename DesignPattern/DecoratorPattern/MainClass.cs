using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            var merchant = new Merchant();
            merchant.Say();


            var merchantWithCough = new CoughDecorator(merchant);
            merchantWithCough.Say();

            var merchantWithSniffles = new SnifflesDecorator(merchant);
            merchantWithSniffles.Say();

            var merchantWithEverything = new SnifflesDecorator(merchantWithCough);
            merchantWithEverything.Say();
        }
    }

}
